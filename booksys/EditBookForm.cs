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
    public partial class EditBookForm : Form
    {
        Book book = null;// 要修改的书籍，要添加的图书信息
        Book book0 = new Book();// 修改的书籍信息
        public EditBookForm()
        {
            InitializeComponent();
        }

        public EditBookForm(Book book)
        {
            InitializeComponent();
            this.book = book;
        }

        private void EditBookForm_Load(object sender, EventArgs e)
        {
            if(book != null)
            {
                // 修改书籍，回显信息
                bidTxt.Text = book.Bid;
                booknameTxt.Text = book.Bookname;
                authorTxt.Text = book.Author;
                leftnumTxt.Text = book.Leftnum.ToString();
                priceTxt.Text = book.Price.ToString();
                bTypeTxt.Text = book.BType;
                bidTxt.Enabled = false;// 书本id不可改
                return;
            }
            // 增加书籍，不用回显信息
        }

        // 更新修改的书籍对象
        private void updateBook()
        {
            book0 = new Book(book.Bid, booknameTxt.Text, authorTxt.Text, Convert.ToInt32(leftnumTxt.Text), Convert.ToDecimal(priceTxt.Text), bTypeTxt.Text);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(book == null)
            {
                // 增加功能
                // 判断没有爆红，并且都不为空，按钮可用
                if (!wrongIdLbl.Visible && !wrongAuthorLbl.Visible && !wrongLeftnumLbl.Visible && !wrongPriceLbl.Visible &&
                    bidTxt.Text != "" && booknameTxt.Text != "" && authorTxt.Text != "" && leftnumTxt.Text != "" && priceTxt.Text != "" && bTypeTxt.Text != "")
                    sureBtn.Enabled = true;
                else sureBtn.Enabled = false;
                return;
            }
            // 编辑功能
            // 没有报红，按钮可用，并且两个“用户”不相等
            if (!book.Equals(book0) && !wrongIdLbl.Visible && !wrongAuthorLbl.Visible && !wrongLeftnumLbl.Visible && !wrongPriceLbl.Visible)
            {
                sureBtn.Enabled = true;
            }
            else
            {
                sureBtn.Enabled = false;
            }
        }

        private void bidTxt_Leave(object sender, EventArgs e)
        {
            SqlParameter bid = new SqlParameter("@bid", bidTxt.Text);
            String sql = "select bid from t_book where bid = @bid";
            SqlDataReader reader = DButil.query(sql, bid);
            if (reader.Read()) wrongIdLbl.Visible = true;
            else wrongIdLbl.Visible = false;
            if(book != null) updateBook();
        }

        private void authorTxt_Leave(object sender, EventArgs e)
        {
            // 作者是否合法
            String name = authorTxt.Text;
            Boolean isLegal = true;
            foreach (char c in name)
            {
                if (Char.IsNumber(c))
                {
                    isLegal = false;
                }
            }
            if (!isLegal)
            {
                wrongAuthorLbl.Visible = true;
            }
            else
            {
                wrongAuthorLbl.Visible = false;
            }
            if (book != null) updateBook();
        }

        private void leftnumTxt_Leave(object sender, EventArgs e)
        {
            String leftnum0 = leftnumTxt.Text;
            Boolean isLegal = true;
            foreach (char c in leftnum0)
            {
                if ( !Char.IsNumber(c))
                {
                    isLegal = false;
                }
            }
            if (!isLegal)
            {
                wrongLeftnumLbl.Visible = true;
            }
            else
            {
                wrongLeftnumLbl.Visible = false;
            }
            if (book != null) updateBook();
        }

        private void priceTxt_Leave(object sender, EventArgs e)
        {
            String price0 = priceTxt.Text;
            Boolean isLegal = true;
            foreach (char c in price0)
            {
                if (c == '.') continue;
                if (!Char.IsNumber(c))
                {
                    isLegal = false;
                }
            }
            if (!isLegal)
            {
                wrongPriceLbl.Visible = true;
            }
            else
            {
                wrongPriceLbl.Visible = false;
            }
            if (book != null) updateBook();
        }
        private void booknameTxt_Leave(object sender, EventArgs e)
        {
            if (book != null) updateBook();
        }
        private void bTypeTxt_Leave(object sender, EventArgs e)
        {
            if (book != null) updateBook();
        }
        private void sureBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DButil.getSqlConnection();
            String sql = null;
            SqlParameter bid = new SqlParameter("@bid", bidTxt.Text);
            SqlParameter bookname = new SqlParameter("@bookname", booknameTxt.Text);
            SqlParameter author = new SqlParameter("@author", authorTxt.Text);
            SqlParameter leftnum = new SqlParameter("@leftnum", leftnumTxt.Text);
            SqlParameter price = new SqlParameter("@price", priceTxt.Text);
            SqlParameter bType = new SqlParameter("@bType", bTypeTxt.Text);
            if(book == null)
            {
                // 添加功能
                sql = "insert into t_book values(@bid, @bookname, @author, @leftnum, @price, @bType)";
                int i = DButil.update(conn, sql, bid, bookname, author, leftnum, price, bType);
                if(i == 0)
                {
                    MessageBox.Show("后台服务器出错，请联系维护人员！");
                }
                else
                {
                    MessageBox.Show("增加成功！");
                    this.Close();
                }
                DButil.close();
                return;
            }
            // 提交修改功能
            sql = "update t_book set bookname=@bookname where bid= @bid";
            DButil.update(conn, sql, bid, bookname);
            sql = "update t_book set author=@author where bid= @bid";
            DButil.update(conn, sql, bid, author);
            sql = "update t_book set leftnum=@leftnum where bid= @bid";
            DButil.update(conn, sql, bid, leftnum);
            sql = "update t_book set price=@price where bid= @bid";
            DButil.update(conn, sql, bid, price);
            sql = "update t_book set bType=@bType where bid= @bid";
            DButil.update(conn, sql, bid, bType);
            MessageBox.Show("修改成功");
            this.Close();
            DButil.close();
        }

    }
}
