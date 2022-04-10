using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace booksys
{
    public partial class UserForm : Form
    {
        public User user = null;
        public UserForm()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateLbl.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            // 查询为空，按钮不能用
            if(booknameTxt.Text == "" && authorTxt.Text == "" && minPriceTxt.Text == "" && maxPriceTxt.Text == "" &&
                bTypeTxt.Text == "")
            {
                exactQueryBtn.Enabled = false;
                vagueQueryBtn.Enabled = false;
            }
            else
            {
                exactQueryBtn.Enabled = true;
            }
            // 只有一个文本框有输入才能用模糊查询
            int i = 0;
            if (booknameTxt.Text != "") i++;
            if (authorTxt.Text != "") i++;
            if (minPriceTxt.Text != "") i++;
            if (maxPriceTxt.Text != "") i++;
            if (bTypeTxt.Text != "") i++;
            if(i == 1)
            {
                vagueQueryBtn.Enabled = true;
            }
            else
            {
                vagueQueryBtn.Enabled = false;
            }
            // 只要有价格，就不模糊
            if(minPriceTxt.Text != "" || maxPriceTxt.Text != "") vagueQueryBtn.Enabled = false;
            // 如果没有选中的话 借书书和挂失按钮不能用
            if (bookView.SelectedItems.Count == 0)
            {
                borrowBookBtn.Enabled = false;
            }
            else
            {
                if(user != null)
                    borrowBookBtn.Enabled = true;
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // 判断当前是否有用户登录,控制相应权限
            if(this.user == null)
            {
                this.Text = "欢迎光临HQU图书馆！";
                this.borrowBookBtn.Enabled = false;
                this.editStrip.Enabled = false;
                this.borrowedBookStrip.Enabled = false;
                this.loginStrip.Enabled = true;
            }
            else
            {
                this.Text = "欢迎 " + user.Username + " 光临HQU图书馆！";
                this.borrowBookBtn.Enabled = true;
                this.editStrip.Enabled = true;
                this.borrowedBookStrip.Enabled = true;
                this.loginStrip.Enabled = false;
            }

            // 显示所有书籍信息
            this.refreshBookView();

        }

        private void logoutStrip_Click(object sender, EventArgs e)
        {
            // 注销提醒
            DialogResult result = MessageBox.Show("确定要退出吗？", "Tips", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result.ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void refreshStrip_Click(object sender, EventArgs e)
        {
            // 刷新功能
            this.refreshBookView();
            // this.bookView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void helpStrip_Click(object sender, EventArgs e)
        {
            // 信息提示功能
            MessageBox.Show("点击查看按钮可以选择查看已借书籍及选择排序类型\n" +
                "点击注销退回主页面\n" +
                "点击修改信息可以修改自己的信息\n" +
                "下方的搜索引擎支持模糊查询及精确查询\n" +
                "还书需要在还书界面中才能使用\n" +
                "反馈Bug请联系QQ:841306289");
        }

        private void loginStrip_Click(object sender, EventArgs e)
        {
            // 登录功能
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void borrowBookBtn_Click(object sender, EventArgs e)
        {
            // 借书操作
            Book book = new Book(this.bookView.SelectedItems[0].SubItems[0].Text,
                this.bookView.SelectedItems[0].SubItems[1].Text,
                this.bookView.SelectedItems[0].SubItems[2].Text,
                Convert.ToInt32(this.bookView.SelectedItems[0].SubItems[3].Text),
                Convert.ToDecimal(this.bookView.SelectedItems[0].SubItems[4].Text),
                this.bookView.SelectedItems[0].SubItems[5].Text
                );
            SqlParameter uid = new SqlParameter("@uid", user.Uid);
            SqlParameter username = new SqlParameter("@username", user.Username);
            SqlParameter bid = new SqlParameter("@bid", book.Bid);
            SqlParameter bookname = new SqlParameter("@bookname", book.Bookname);
            SqlParameter borrowTime = new SqlParameter("@borrowTime", DateTime.Now);
            SqlParameter returnTime = new SqlParameter("@returnTime", new DateTime(1978, 12, 31, 12, 12, 12));
            // 判断是否还有书
            if (book.Leftnum == 0)
            {
                MessageBox.Show("图书库存不足，再等等吧");
                return;
            }
            // 判断是否借过该书--只能借一本同名书
            String sql1 = "select borrowTime from t_logSheet where uid=@uid and bookname=@bookname and isReturn=0 and bid=@bid";
            SqlDataReader reader = DButil.query(sql1, bookname, uid, bid);
            if (reader.Read())
            {
                MessageBox.Show("对不起，您已结果该书籍，不能再借同样的书了！");
                return;
            }
            // 插入记录
            String sql = "insert into t_logSheet values(@uid, @username, @bid, @bookname, @borrowTime, @returnTime, 0)";
            int i = DButil.update(sql, uid, username, bid, bookname, borrowTime, returnTime);
            DButil.close();
            // 修改图书数量
            String sql0 = "update t_book set leftnum = @leftnum where bid = @bid";
            book.Leftnum -= 1;
            SqlParameter leftnum = new SqlParameter("@leftnum", book.Leftnum);
            int i0 = DButil.update(sql0, leftnum, bid);
            DButil.close();
            if (i == 0 || i0 == 0)
            {
                MessageBox.Show("借书失败，请联系后台管理员处理");
            }
            else
            {
                MessageBox.Show("借书成功！请按时还书");
            }
            this.refreshBookView();
        }

        private void borrowedBookStrip_Click(object sender, EventArgs e)
        {
            // 查看已借书籍窗口
            ReturnBookForm retForm = new ReturnBookForm();
            retForm.user = user;
            retForm.Show();
        }

        // 刷新bookView
        public  void refreshBookView()
        {
            bookView.Items.Clear();// 清空
            String sql = "select bid, bookname, author, leftnum, price, bType from t_book";
            List<Book> books = Book.ToBeanList(DButil.query(sql));
            DButil.close();
            for (int i = 0; i < books.ToArray().Length; i++)
            {
                Book book = books[i];
                ListViewItem items = new ListViewItem(book.Bid);
                items.SubItems.Add(book.Bookname);
                items.SubItems.Add(book.Author);
                items.SubItems.Add(book.Leftnum.ToString());
                items.SubItems.Add(book.Price.ToString());
                items.SubItems.Add(book.BType);
                this.bookView.Items.Add(items);
            }
        }

        private void viewAllBookStrip_Click(object sender, EventArgs e)
        {
            this.refreshBookView();
        }

        private void sortBTypeStrip_Click(object sender, EventArgs e)
        {
            bookView.Items.Clear();// 清空
            String sql = "select bid, bookname, author, leftnum, price, bType from t_book order by bType";
            List<Book> books = Book.ToBeanList(DButil.query(sql));
            DButil.close();
            for (int i = 0; i < books.ToArray().Length; i++)
            {
                Book book = books[i];
                ListViewItem items = new ListViewItem(book.Bid);
                items.SubItems.Add(book.Bookname);
                items.SubItems.Add(book.Author);
                items.SubItems.Add(book.Leftnum.ToString());
                items.SubItems.Add(book.Price.ToString());
                items.SubItems.Add(book.BType);
                this.bookView.Items.Add(items);
            }
        }

        private void sortAuthorStrip_Click(object sender, EventArgs e)
        {
            bookView.Items.Clear();// 清空
            String sql = "select bid, bookname, author, leftnum, price, bType from t_book order by author";
            List<Book> books = Book.ToBeanList(DButil.query(sql));
            DButil.close();
            for (int i = 0; i < books.ToArray().Length; i++)
            {
                Book book = books[i];
                ListViewItem items = new ListViewItem(book.Bid);
                items.SubItems.Add(book.Bookname);
                items.SubItems.Add(book.Author);
                items.SubItems.Add(book.Leftnum.ToString());
                items.SubItems.Add(book.Price.ToString());
                items.SubItems.Add(book.BType);
                this.bookView.Items.Add(items);
            }
        }

        private void sortPriceAscStrip_Click(object sender, EventArgs e)
        {
            bookView.Items.Clear();// 清空
            String sql = "select bid, bookname, author, leftnum, price, bType from t_book order by price asc";
            List<Book> books = Book.ToBeanList(DButil.query(sql));
            DButil.close();
            for (int i = 0; i < books.ToArray().Length; i++)
            {
                Book book = books[i];
                ListViewItem items = new ListViewItem(book.Bid);
                items.SubItems.Add(book.Bookname);
                items.SubItems.Add(book.Author);
                items.SubItems.Add(book.Leftnum.ToString());
                items.SubItems.Add(book.Price.ToString());
                items.SubItems.Add(book.BType);
                this.bookView.Items.Add(items);
            }
        }

        private void sortPriceDescStrip_Click(object sender, EventArgs e)
        {
            bookView.Items.Clear();// 清空
            String sql = "select bid, bookname, author, leftnum, price, bType from t_book order by price desc";
            List<Book> books = Book.ToBeanList(DButil.query(sql));
            DButil.close();
            for (int i = 0; i < books.ToArray().Length; i++)
            {
                Book book = books[i];
                ListViewItem items = new ListViewItem(book.Bid);
                items.SubItems.Add(book.Bookname);
                items.SubItems.Add(book.Author);
                items.SubItems.Add(book.Leftnum.ToString());
                items.SubItems.Add(book.Price.ToString());
                items.SubItems.Add(book.BType);
                this.bookView.Items.Add(items);
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            booknameTxt.Text = "";
            authorTxt.Text = "";
            minPriceTxt.Text = "";
            maxPriceTxt.Text = "";
            bTypeTxt.Text = "";
            refreshBookView();
        }

        private void exactQueryBtn_Click(object sender, EventArgs e)
        {
            // 精确查询
            String bookname = booknameTxt.Text;
            String author = authorTxt.Text;
            String minPrice = minPriceTxt.Text;
            String maxPrice = maxPriceTxt.Text;
            String bType = bTypeTxt.Text;
            StringBuilder sb = new StringBuilder("select bid, bookname, author, leftnum, price, bType from t_book where ");
            SqlParameter booknameParam = null;
            SqlParameter authorParam = null;
            SqlParameter minPriceParam = null;
            SqlParameter maxPriceParam = null;
            SqlParameter bTypeParam = null;
            if (bookname != "")
            {
                sb.Append("bookname = @bookname and ");
                booknameParam = new SqlParameter("@bookname", bookname);
            }
            if (author != "")
            {
                sb.Append("author = @author and ");
                authorParam = new SqlParameter("@author", author);
            }
            if (bType != "")
            {
                sb.Append("bType = @bType and ");
                bTypeParam = new SqlParameter("@bType", bType);
            }
            if (minPrice != "")
            {
                sb.Append("price between @minPrice and ");
                minPriceParam = new SqlParameter("@minPrice", minPrice);
            }
            else
            {
                sb.Append("price between 0 and ");
            }
            if(maxPrice != "")
            {
                sb.Append("@maxPrice and ");
                maxPriceParam = new SqlParameter("@maxPrice", maxPrice);
            }
            else
            {
                sb.Append(int.MaxValue + " and ");
            }
            sb.Append("1=1");
            // 将非空的SqlParammeter封装成数组，传进去
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            if(booknameParam != null){
                sqlParams.Add(booknameParam);
            }
            if (authorParam != null)
            {
                sqlParams.Add(authorParam);
            }
            if (minPriceParam != null)
            {
                sqlParams.Add(minPriceParam);
            }
            if (maxPriceParam != null)
            {
                sqlParams.Add(maxPriceParam);
            }
            if (bTypeParam != null)
            {
                sqlParams.Add(bTypeParam);
            }
            // 执行语句，显示
            String sql = sb.ToString();
            List<Book> books = Book.ToBeanList(DButil.query(sql, sqlParams.ToArray()));
            DButil.close();
            // 查询结果为空，友好提示
            if(books.ToArray().Length == 0)
            {
                MessageBox.Show("查询结果为空，请重新输入！！！");
                return;
            }
            bookView.Items.Clear();// 清空
            for (int i = 0; i < books.ToArray().Length; i++)
            {
                Book book = books[i];
                ListViewItem items = new ListViewItem(book.Bid);
                items.SubItems.Add(book.Bookname);
                items.SubItems.Add(book.Author);
                items.SubItems.Add(book.Leftnum.ToString());
                items.SubItems.Add(book.Price.ToString());
                items.SubItems.Add(book.BType);
                this.bookView.Items.Add(items);
            }

        }

        private void vagueQueryBtn_Click(object sender, EventArgs e)
        {
            // 书名模糊
            if(booknameTxt.Text != "")
            {
                String sql = "select bid, bookname, author, leftnum, price, bType from t_book where bookname like @bookname";
                SqlParameter bookname = new SqlParameter("@bookname", "%" + booknameTxt.Text + "%");
                // 执行语句，显示
                List<Book> books = Book.ToBeanList(DButil.query(sql, bookname));
                DButil.close();
                // 查询结果为空，友好提示
                if (books.ToArray().Length == 0)
                {
                    MessageBox.Show("查询结果为空，请重新输入！！！");
                    return;
                }
                bookView.Items.Clear();// 清空
                for (int i = 0; i < books.ToArray().Length; i++)
                {
                    Book book = books[i];
                    ListViewItem items = new ListViewItem(book.Bid);
                    items.SubItems.Add(book.Bookname);
                    items.SubItems.Add(book.Author);
                    items.SubItems.Add(book.Leftnum.ToString());
                    items.SubItems.Add(book.Price.ToString());
                    items.SubItems.Add(book.BType);
                    this.bookView.Items.Add(items);
                }
                return;
            }
            // 作者模糊
            if (authorTxt.Text != "")
            {
                String sql = "select bid, bookname, author, leftnum, price, bType from t_book where author like @author";
                SqlParameter author = new SqlParameter("@author", "%" + authorTxt.Text + "%");
                // 执行语句，显示
                List<Book> books = Book.ToBeanList(DButil.query(sql, author));
                DButil.close();
                // 查询结果为空，友好提示
                if (books.ToArray().Length == 0)
                {
                    MessageBox.Show("查询结果为空，请重新输入！！！");
                    return;
                }
                bookView.Items.Clear();// 清空
                for (int i = 0; i < books.ToArray().Length; i++)
                {
                    Book book = books[i];
                    ListViewItem items = new ListViewItem(book.Bid);
                    items.SubItems.Add(book.Bookname);
                    items.SubItems.Add(book.Author);
                    items.SubItems.Add(book.Leftnum.ToString());
                    items.SubItems.Add(book.Price.ToString());
                    items.SubItems.Add(book.BType);
                    this.bookView.Items.Add(items);
                }
                return;
            }
            // 类型模糊
            if (bTypeTxt.Text != "")
            {
                String sql = "select bid, bookname, author, leftnum, price, bType from t_book where bType like @bType";
                SqlParameter bType = new SqlParameter("@bType", "%" + bTypeTxt.Text + "%");
                // 执行语句，显示
                List<Book> books = Book.ToBeanList(DButil.query(sql, bType));
                DButil.close();
                // 查询结果为空，友好提示
                if (books.ToArray().Length == 0)
                {
                    MessageBox.Show("查询结果为空，请重新输入！！！");
                    return;
                }
                bookView.Items.Clear();// 清空
                for (int i = 0; i < books.ToArray().Length; i++)
                {
                    Book book = books[i];
                    ListViewItem items = new ListViewItem(book.Bid);
                    items.SubItems.Add(book.Bookname);
                    items.SubItems.Add(book.Author);
                    items.SubItems.Add(book.Leftnum.ToString());
                    items.SubItems.Add(book.Price.ToString());
                    items.SubItems.Add(book.BType);
                    this.bookView.Items.Add(items);
                }
                return;
            }
        }

        private void editStrip_Click(object sender, EventArgs e)
        {
            EditUserForm editUserForm = new EditUserForm();
            editUserForm.user = user;
            editUserForm.eUser = user;
            editUserForm.Show();
        }
    }
}
