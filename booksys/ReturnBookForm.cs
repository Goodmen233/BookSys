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
    public partial class ReturnBookForm : Form
    {
        public User user;
        private Boolean isAsc = true;// 默认借书历史的排序方式
        private Boolean isViewReturn = false;
        public ReturnBookForm()
        {
            InitializeComponent();
        }

        private void ReturnBookForm_Load(object sender, EventArgs e)
        {
            updateLogSheet();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // 判断查询书名的按钮能不能用
            if(booknameTxt.Text != "")
            {
                queryBtn.Enabled = true;
            }
            else
            {
                queryBtn.Enabled = false;
            }
            // 如果没有选中的话 还书和挂失按钮不能用
            if(bookView.SelectedItems.Count == 0)
            {
                returnBookBtn.Enabled = false;
                lossBtn.Enabled = false;
            }
            else
            {
                returnBookBtn.Enabled = true;
                lossBtn.Enabled = true;
            }
        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            String sql = "select uid, username, bid, bookname, borrowTime, returnTime, isReturn from t_logSheet where uid=@uid and bookname like @bookname";
            SqlParameter uid = new SqlParameter("@uid", user.Uid);
            SqlParameter bookname = new SqlParameter("@bookname", "%" + booknameTxt.Text + "%");
            List<LogSheet> logSheets = LogSheet.toBeanList(DButil.query(sql, uid, bookname));
            DButil.close();
            if(logSheets.ToArray().Length == 0)
            {
                MessageBox.Show("没有查找到相关记录，请重新输入！");
                return;
            }
            bookView.Items.Clear();// 清空
            for (int i = 0; i < logSheets.ToArray().Length; i++)
            {
                LogSheet logSheet = logSheets[i];
                ListViewItem items = new ListViewItem(logSheet.Bookname);
                items.SubItems.Add(logSheet.BorrowTime.ToString());
                items.SubItems.Add(logSheet.ReturnTime.ToString());
                items.SubItems.Add(logSheet.IsReturn ? "还书成功" : "未还或待管理员处理");
                items.SubItems.Add(logSheet.Bid.ToString());
                this.bookView.Items.Add(items);
            }
        }

        private void updateLogSheet()
        {
            // 查看当前用户的借书记录
            bookView.Items.Clear();// 清空
            // 显示数据
            String sql = null;
            if (isAsc) 
                if(isViewReturn)
                    sql = "select uid, username, bid, bookname, borrowTime, returnTime, isReturn from t_logSheet where uid=@uid and isReturn=0 order by borrowTime asc";
                else
                    sql = "select uid, username, bid, bookname, borrowTime, returnTime, isReturn from t_logSheet where uid=@uid order by borrowTime asc";
            else
                if(isViewReturn)
                    sql = "select uid, username, bid, bookname, borrowTime, returnTime, isReturn from t_logSheet where uid=@uid and isReturn=0 order by borrowTime desc";
            else
                    sql = "select uid, username, bid, bookname, borrowTime, returnTime, isReturn from t_logSheet where uid=@uid order by borrowTime desc";
            SqlParameter uid = new SqlParameter("@uid", user.Uid);
            List<LogSheet> logSheets = LogSheet.toBeanList(DButil.query(sql, uid));
            DButil.close();

            for (int i = 0; i < logSheets.ToArray().Length; i++)
            {
                LogSheet logSheet = logSheets[i];
                ListViewItem items = new ListViewItem(logSheet.Bookname);
                items.SubItems.Add(logSheet.BorrowTime.ToString());
                items.SubItems.Add(logSheet.ReturnTime.Year == 1978 ? "" : logSheet.ReturnTime.ToString());
                items.SubItems.Add(logSheet.IsReturn ? "还书成功" : "未还或待管理员处理");
                items.SubItems.Add(logSheet.Bid.ToString());
                this.bookView.Items.Add(items);
            }
        }


        private void exchangeSortBtn_Click(object sender, EventArgs e)
        {
            isAsc = !isAsc;
            updateLogSheet();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            booknameTxt.Text = "";
            updateLogSheet();
        }

        private void returnBookBtn_Click(object sender, EventArgs e)
        {
            if (bookView.SelectedItems[0].SubItems[3].Text == "还书成功")
            {
                MessageBox.Show("还书成功，不能再还了！");
                return;
            }
            // 还书按钮
            String bid0 = bookView.SelectedItems[0].SubItems[4].Text;
            DateTime returnTime = DateTime.Now;
            String sql = "update t_logSheet set returnTime=@returnTime where bid = @bid";
            SqlParameter returnTimeParam = new SqlParameter("@returnTime", returnTime);
            SqlParameter bid = new SqlParameter("@bid", bid0);
            int i = DButil.update(sql, returnTimeParam, bid);
            DButil.close();
            if(i == 0)
            {
                MessageBox.Show("后台服务器出错，请联系后台管理员处理！");
            }
            else
            {
                MessageBox.Show("还书申请成功，等待管理员处理！");
            }
            updateLogSheet();// 刷新
        
        }

        private void lossBtn_Click(object sender, EventArgs e)
        {
            // 挂失界面
            // 判断如果已还书就不能挂失
            if(bookView.SelectedItems[0].SubItems[3].Text == "还书成功")
            {
                MessageBox.Show("还书成功，不能挂失！");
                return;
            }
            DialogResult result = MessageBox.Show("确定要挂失吗？", "Tips", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result.ToString() == "Yes")
            {
                SqlConnection conn = DButil.getSqlConnection();
                // 插入挂失表
                String sql = "insert into t_lossSheet values(@uid, @username, @bookname, @lossDate, 0)";
                String bid0 = bookView.SelectedItems[0].SubItems[4].Text;
                String bookname0 = bookView.SelectedItems[0].SubItems[0].Text;
                SqlParameter bid = new SqlParameter("@bid", bid0);
                SqlParameter bookname = new SqlParameter("@bookname", bookname0);
                SqlParameter uid = new SqlParameter("@uid", user.Uid);
                SqlParameter username = new SqlParameter("@username", user.Username);
                SqlParameter lossDate = new SqlParameter("@lossDate", DateTime.Now);
                DButil.update(conn, sql, uid, username, bookname, lossDate);
                // 删除借阅记录
                sql = "delete from t_logSheet where bid=@bid";
                DButil.update(conn, sql, bid);
                
                // 判断用户挂失5次，并且都未处理，拉入黑名单
                sql = "select count(*) from t_lossSheet where uid=@uid and isDeal=0";
                int lossCount = DButil.queryScalar(conn, sql, uid);
                if(lossCount >= 5)
                {
                    sql = "update t_user set isBlack=1 where uid=@uid";
                    DButil.update(conn, sql, uid);
                    DButil.close();
                    MessageBox.Show("挂失数大于等于5次，已被拉入黑名单！请尽快联系管理员处理");
                    List<Form> forms0 = new List<Form>();
                    foreach (Form item in Application.OpenForms)
                    {
                        forms0.Add(item);
                    }
                    Array forms = forms0.ToArray<Form>();
                    foreach (Form form in forms)
                    {
                        if (form.Name != "Welcome") form.Close();
                    }
                    return;
                }
                DButil.close();
                MessageBox.Show("已成功挂失，请联系管理员尽快进行处理\n" +
                    "(目前已挂失" + lossCount + "本书)\n" +
                    "挂失数超过5次会被拉入黑名单噢！");
            }
            updateLogSheet();
        }

        private void viewReturnBtn_CheckedChanged(object sender, EventArgs e)
        {
            isViewReturn = !isViewReturn;
            updateLogSheet();
        }
    }
}
