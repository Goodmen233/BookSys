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
    public partial class UserInfoForm : Form
    {
        public User admin = null;
        public UserInfoForm()
        {
            InitializeComponent();
            updateView();
        }

        public UserInfoForm(User user)
        {
            this.admin = user;
            InitializeComponent();
            updateView();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // 查询按钮是否可用
            if (queryTxt.Text == "") queryBtn.Enabled = false;
            else queryBtn.Enabled = true;

            if (userView.SelectedItems.Count == 0)
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

        // 刷新表格数据
        private void updateView()
        {
            String sql = "select * from t_user";
            List<User> users = User.ToBeanList(DButil.query(sql));
            DButil.close();
            userView.Items.Clear();// 清空
            for (int i = 0; i < users.ToArray().Length; i++)
            {
                User user = users[i];
                ListViewItem items = new ListViewItem(user.Uid);
                items.SubItems.Add(user.Username);
                items.SubItems.Add(user.Phone);
                items.SubItems.Add(user.Sex == "boy" ? "男" : "女");
                items.SubItems.Add(user.Email);
                items.SubItems.Add(user.Major);
                items.SubItems.Add(user.Password);
                items.SubItems.Add(user.IsAdmin.ToString());
                items.SubItems.Add(user.IsBlack.ToString());
                this.userView.Items.Add(items);
            }
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
            String sql = "select * from t_user where uid = @uid";
            List<User> users = User.ToBeanList(DButil.query(sql, uid));
            DButil.close();
            if (users.ToArray().Length == 0)
            {
                MessageBox.Show("查询结果为空，请重试！");
            }
            else
            {
                userView.Items.Clear();// 清空
                for (int i = 0; i < users.ToArray().Length; i++)
                {
                    User user = users[i];
                    ListViewItem items = new ListViewItem(user.Uid);
                    items.SubItems.Add(user.Username);
                    items.SubItems.Add(user.Phone);
                    items.SubItems.Add(user.Sex == "boy" ? "男" : "女");
                    items.SubItems.Add(user.Email);
                    items.SubItems.Add(user.Major);
                    items.SubItems.Add(user.Password);
                    items.SubItems.Add(user.IsAdmin.ToString());
                    items.SubItems.Add(user.IsBlack.ToString());
                    this.userView.Items.Add(items);
                }
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            String uid0 = userView.SelectedItems[0].SubItems[0].Text;
            DialogResult result = MessageBox.Show("确定要删除id为" + uid0 + "的用户吗？", "Tips", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result.ToString() == "Yes")
            {
                String sql = "delete from t_user where uid=@uid";
                SqlParameter uid = new SqlParameter("@uid", uid0);
                int i = DButil.update(sql, uid);
                DButil.close();
                if (i == 0) MessageBox.Show("后台出错，请联系相关人员解决");
                else MessageBox.Show("删除成功！");
                updateView();
            }
           
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            String uid = userView.SelectedItems[0].SubItems[0].Text;
            String username = userView.SelectedItems[0].SubItems[1].Text;
            String phone = userView.SelectedItems[0].SubItems[2].Text;
            String sex = (userView.SelectedItems[0].SubItems[3].Text == "男" ? "boy" : "girl");
            String email = userView.SelectedItems[0].SubItems[4].Text;
            String major = userView.SelectedItems[0].SubItems[5].Text;
            String password = userView.SelectedItems[0].SubItems[6].Text;
            Boolean isAdmin = Convert.ToBoolean(userView.SelectedItems[0].SubItems[7].Text);
            Boolean isBlack = Convert.ToBoolean(userView.SelectedItems[0].SubItems[8].Text);
            User user = new User(uid, username, phone, sex, email, major, password, isAdmin, isBlack);
            EditUserForm form = new EditUserForm();
            form.user = this.admin;
            form.eUser = user;
            form.Show();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            updateView();
        }
    }
}
