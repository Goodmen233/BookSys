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
    public partial class LogManageForm : Form
    {
        private Boolean isViewReturn = false;
        public LogManageForm()
        {
            InitializeComponent();
        }

        private void LogManageForm_Load(object sender, EventArgs e)
        {
            updateView();
        }

        // 更新表格
        private void updateView()
        {
            logSheetView.Items.Clear();// 清空
            String sql = null;
            if (isViewReturn)
            {
                sql = "select uid, username, bid, bookname, borrowTime, returnTime, isReturn from t_logSheet where isReturn = 0 and returnTime!='1978-12-31 12:12:12.000' order by returnTime desc";
            }
            else
            {
                sql = "select uid, username, bid, bookname, borrowTime, returnTime, isReturn from t_logSheet order by returnTime desc";
            }
            List<LogSheet> logs = LogSheet.toBeanList(DButil.query(sql));
            DButil.close();
            for (int i = 0; i < logs.ToArray().Length; i++)
            {
                LogSheet log = logs[i];
                ListViewItem items = new ListViewItem(log.Uid);
                items.SubItems.Add(log.Username);
                items.SubItems.Add(log.Bookname);
                items.SubItems.Add(log.BorrowTime.ToString());
                items.SubItems.Add(log.ReturnTime.Year == 1978 ? "" : log.ReturnTime.ToString());
                items.SubItems.Add(log.IsReturn ? "已还书" : "未还书");
                items.SubItems.Add(log.Bid.ToString());
                this.logSheetView.Items.Add(items);
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            // 判断是否提交还书申请
            if (logSheetView.SelectedItems[0].SubItems[4].Text == "")
            {
                MessageBox.Show("用户未提交还书申请，暂不能还书");
                return;
            }

            DialogResult result = MessageBox.Show("确定还书了吗？", "Tips", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result.ToString() == "Yes")
            {
                String sql = "update t_logSheet set isReturn = 1 where uid = @uid and bid=@bid";
                String uid0 = logSheetView.SelectedItems[0].SubItems[0].Text;
                String bid0 = logSheetView.SelectedItems[0].SubItems[6].Text;
                SqlParameter uid = new SqlParameter("@uid", uid0);
                SqlParameter bid = new SqlParameter("@bid", bid0);
                int i = DButil.update(sql, uid, bid);
                DButil.close();
                if (i == 0)
                {
                    MessageBox.Show("后台服务器异常，请联系程序员解决");
                }
                else
                {
                    MessageBox.Show("还书成功！");
                    // 更新书本---------------------------------------------------
                    SqlConnection conn = DButil.getSqlConnection();
                    sql = "select * from t_book where bid=@bid";
                    Book book = Book.ToBean(DButil.query(conn, sql, bid));
                    book.Leftnum += 1;
                    sql = "update t_book set leftnum = @leftnum where bid=@bid";
                    DButil.update(sql, new SqlParameter("@leftnum", book.Leftnum), bid);
                }
                updateView();
            }
        }

        private void viewReturnBox_CheckedChanged(object sender, EventArgs e)
        {
            isViewReturn = !isViewReturn;
            updateView();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            // 重置按钮
            queryTxt.Text = "";
            updateView();
        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            // 查询按钮
            String uid0 = queryTxt.Text;
            SqlParameter uid = new SqlParameter("@uid", uid0);
            String sql = null;
            if (isViewReturn)
            {
                sql = "select uid, username, bid, bookname, borrowTime, returnTime, isReturn from t_logSheet where isReturn = 0 and returnTime!='1978-12-31 12:12:12.000' and uid = @uid order by returnTime desc";
            }
            else
            {
                sql = "select uid, username, bid, bookname, borrowTime, returnTime, isReturn from t_logSheet where uid = @uid order by returnTime desc";
            }
            List<LogSheet> logs = LogSheet.toBeanList(DButil.query(sql, uid));
            DButil.close();
            if (logs.ToArray().Length == 0)
            {
                MessageBox.Show("查询结果为空，请重试！");
            }
            else
            {
                logSheetView.Items.Clear();// 清空
                for (int i = 0; i < logs.ToArray().Length; i++)
                {
                    LogSheet log = logs[i];
                    ListViewItem items = new ListViewItem(log.Uid);
                    items.SubItems.Add(log.Username);
                    items.SubItems.Add(log.Bookname);
                    items.SubItems.Add(log.BorrowTime.ToString());
                    items.SubItems.Add(log.ReturnTime.Year == 1978 ? "" : log.ReturnTime.ToString());
                    items.SubItems.Add(log.IsReturn ? "已还书" : "未还书");
                    items.SubItems.Add(log.Bid.ToString());
                    this.logSheetView.Items.Add(items);
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // 查询按钮是否可用
            if (queryTxt.Text == "") queryBtn.Enabled = false;
            else queryBtn.Enabled = true ;

            if (logSheetView.SelectedItems.Count == 0)
            {
                returnBtn.Enabled = false;
            }
            else
            {
                returnBtn.Enabled = true;
            }
        }
    }
}
