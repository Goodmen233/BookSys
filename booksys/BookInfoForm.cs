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
    public partial class BookInfoForm : Form
    {
        public BookInfoForm()
        {
            InitializeComponent();
        }

        private void BookInfoForm_Load(object sender, EventArgs e)
        {
            updateView();
        }

        // 更新表格
        private void updateView()
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

        private void timer_Tick(object sender, EventArgs e)
        {
            // 查询按钮是否可用
            if (queryTxt.Text == "") queryBtn.Enabled = false;
            else queryBtn.Enabled = true;

            if (bookView.SelectedItems.Count == 0)
            {
                delBtn.Enabled = false;
                editBtn.Enabled = false;
            }
            else
            {
                delBtn.Enabled = true;
                editBtn.Enabled = true;
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            // 重置按钮
            queryTxt.Text = "";
            updateView();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            updateView();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            // 删除按钮
            String bid0 = bookView.SelectedItems[0].SubItems[0].Text;
            DialogResult result = MessageBox.Show("确定要删除id为" + bid0 + "的图书吗？", "Tips", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result.ToString() == "Yes")
            {
                String sql = "delete from t_book where bid=@bid";
                SqlParameter bid = new SqlParameter("@bid", bid0);
                int i = DButil.update(sql, bid);
                DButil.close();
                if (i == 0) MessageBox.Show("后台出错，请联系相关人员解决");
                else MessageBox.Show("删除成功！");
                updateView();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            String bid = bookView.SelectedItems[0].SubItems[0].Text;
            String bookname = bookView.SelectedItems[0].SubItems[1].Text;
            String author = bookView.SelectedItems[0].SubItems[2].Text;
            int leftnum = Convert.ToInt32(bookView.SelectedItems[0].SubItems[3].Text);
            Decimal price = Convert.ToDecimal(bookView.SelectedItems[0].SubItems[4].Text);
            String bType = bookView.SelectedItems[0].SubItems[5].Text;
            Book book = new Book(bid, bookname, author, leftnum, price, bType);
            new EditBookForm(book).Show();
        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            // 查询按钮
            String bid0 = queryTxt.Text;
            SqlParameter bid = new SqlParameter("@bid", bid0);
            String sql = "select * from t_book where bid = @bid";
            List<Book> books = Book.ToBeanList(DButil.query(sql, bid));
            DButil.close();
            if (books.ToArray().Length == 0)
            {
                MessageBox.Show("查询结果为空，请重试！");
            }
            else
            {
                bookView.Items.Clear();// 清空
                for (int i = 0; i < books.ToArray().Length; i++)
                {
                    Book book= books[i];
                    ListViewItem items = new ListViewItem(book.Bid);
                    items.SubItems.Add(book.Bookname);
                    items.SubItems.Add(book.Author);
                    items.SubItems.Add(book.Leftnum + "");
                    items.SubItems.Add(book.Price + "");
                    items.SubItems.Add(book.BType);
                    this.bookView.Items.Add(items);
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            new EditBookForm().Show();
        }
    }
}
