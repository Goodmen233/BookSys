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
    public partial class LossManageForm : Form
    {
        public Boolean isViewDeal = false;
        public LossManageForm()
        {
            InitializeComponent();
            updateView();
            this.lossSheetView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // 查询按钮是否可用
            if (queryTxt.Text == "") queryBtn.Enabled = false;
            else queryBtn.Enabled = true ;

            if (lossSheetView.SelectedItems.Count == 0)
            {
                dealBtn.Enabled = false;
            }
            else
            {
                dealBtn.Enabled = true;
            }
        }

        // 更新表内容
        private void updateView()
        {
            lossSheetView.Items.Clear();// 清空
            String sql = null;
            if (isViewDeal)
            {
                sql = "select uid, username, bookname, lossDate, isDeal from t_lossSheet where isDeal = 0 order by lossDate desc";
            }
            else
            {
                sql = "select uid, username, bookname, lossDate, isDeal from t_lossSheet order by lossDate desc";
            }
            List<LossList> losses = LossList.toBeanList(DButil.query(sql));
            DButil.close();
            for (int i = 0; i < losses.ToArray().Length; i++)
            {
                LossList loss = losses[i];
                ListViewItem items = new ListViewItem(loss.Uid);
                items.SubItems.Add(loss.Username);
                items.SubItems.Add(loss.Bookname);
                items.SubItems.Add(loss.LossDate.ToString());
                items.SubItems.Add(loss.IsDeal ? "已处理" : "未处理");
                this.lossSheetView.Items.Add(items);
            }
        }

        private void dealBtn_Click(object sender, EventArgs e)
        {
            // 处理按钮
            DialogResult result = MessageBox.Show("确定要已处理了吗？", "Tips", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result.ToString() == "Yes")
            {
                String uid0 = lossSheetView.SelectedItems[0].SubItems[0].Text;
                String bookname0 = lossSheetView.SelectedItems[0].SubItems[2].Text;
                String sql = "update t_lossSheet set isDeal = 1 where uid=@uid and bookname=@bookname";
                SqlParameter uid = new SqlParameter("@uid", uid0);
                SqlParameter bookname = new SqlParameter("@bookname", bookname0);
                int i = DButil.update(sql, uid, bookname);
                DButil.close();
                if (i == 0)
                {
                    MessageBox.Show("后台服务器异常，请联系程序员解决");
                }
                else
                {
                    MessageBox.Show("处理成功！");
                }
                updateView();
            }
        }

        private void viewDealBox_CheckedChanged(object sender, EventArgs e)
        {
            // 已处理
            isViewDeal = !isViewDeal;
            updateView();
        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            // 查询按钮
            String uid0 = queryTxt.Text;
            SqlParameter uid = new SqlParameter("@uid", uid0);
            String sql = "select uid, username, bookname, lossDate, isDeal from t_lossSheet where uid = @uid";
            List<LossList> losses = LossList.toBeanList(DButil.query(sql, uid));
            DButil.close();
            if(losses.ToArray().Length == 0)
            {
                MessageBox.Show("查询结果为空，请重试！");
            }
            else
            {
                lossSheetView.Items.Clear();// 清空
                for (int i = 0; i < losses.ToArray().Length; i++)
                {
                    LossList loss = losses[i];
                    ListViewItem items = new ListViewItem(loss.Uid);
                    items.SubItems.Add(loss.Username);
                    items.SubItems.Add(loss.Bookname);
                    items.SubItems.Add(loss.LossDate.ToString());
                    items.SubItems.Add(loss.IsDeal ? "已处理" : "未处理");
                    this.lossSheetView.Items.Add(items);
                }
            }
            
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            // 重置按钮
            queryTxt.Text = "";
            updateView();
        }
    }
}
