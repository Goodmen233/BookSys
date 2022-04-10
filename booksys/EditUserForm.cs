using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace booksys
{
    public partial class EditUserForm : Form
    {
        public User user = new User();// 当前登录的用户对象
        public User eUser = new User();// 要修改的对象
        public User user0 = null;// 修改后的用户对象
        public EditUserForm()
        {
            user0 = eUser;
            InitializeComponent();
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            user0 = eUser;
            // 检查用户是否有权限修改 管理员和黑名单
            if (user.IsAdmin)
            {
                isAdminBox.Visible = true;
                isBlackBox.Visible = true;
                majorTxt.Enabled = true;
                originPassTxt.Text = eUser.Password;
            }
            majorTxt.Text = eUser.Major;
            if (eUser.Sex == "boy") boyRBtn.Checked = true;
            else girlRBTn.Checked = true;
            nameTxt.Text = eUser.Username;
            phoneTxt.Text = eUser.Phone;
            emailTxt.Text = eUser.Email;
            isAdminBox.Checked = eUser.IsAdmin;
            isBlackBox.Checked = eUser.IsBlack;
        }

        private void nameTxt_Leave(object sender, EventArgs e)
        {
            // 姓名是否合法
            String name = nameTxt.Text;
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
                nameIllegalTIpsLbl.Visible = true;
            }
            else
            {
                nameIllegalTIpsLbl.Visible = false;
            }
            updateUser();
        }

        private void phoneTxt_Leave(object sender, EventArgs e)
        {
            // 手机号是否合法
            String phone = phoneTxt.Text;
            if (phone.Length != 11 || phone == "")
            {
                phoneIllegalTipsLbl.Visible = true;
            }
            else
            {
                phoneIllegalTipsLbl.Visible = false;
            }
            updateUser();
        }

        private void emailTxt_Leave(object sender, EventArgs e)
        {
            // 邮箱是否合法
            String email = emailTxt.Text;
            Regex regex = new Regex(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            if (!regex.IsMatch(email))
            {
                emailIllegalTIpsLbl.Visible = true;
            }
            else
            {
                emailIllegalTIpsLbl.Visible = false;
            }
            updateUser();
        }

        private void originPassTxt_Leave(object sender, EventArgs e)
        {
            // 判断原始密码是否符合
            String pass = originPassTxt.Text;
            if(pass != "" && pass != eUser.Password)
            {
                wrongOriginPassTips.Visible = true;
            }
            else
            {
                wrongOriginPassTips.Visible = false;
            }
            updateUser();
        }

        private void confirmPassTxt_Leave(object sender, EventArgs e)
        {
            // 密码是否一致
            String pass = passTxt.Text;
            String pass0 = confirmPassTxt.Text;
            if (pass != "" && pass0 != "" && !(pass == pass0))
            {
                wrongPassTipsLbl.Visible = true;
            }
            else
            {
                wrongPassTipsLbl.Visible = false;
            }
            updateUser();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            // 修改
            SqlConnection conn = DButil.getSqlConnection();
            String sql = "";
            SqlParameter uid = new SqlParameter("@uid", user0.Uid);
            SqlParameter username = new SqlParameter("@username", user0.Username);
            sql = "update t_user set username = @username where uid = @uid";
            DButil.update(conn, sql, uid, username);
            SqlParameter phone = new SqlParameter("@phone", user0.Phone);
            sql = "update t_user set phone = @phone where uid = @uid";
            DButil.update(conn, sql, uid, phone);
            SqlParameter sex = new SqlParameter("@sex", user0.Sex);
            sql = "update t_user set sex = @sex where uid = @uid";
            DButil.update(conn, sql, uid, sex);
            SqlParameter email = new SqlParameter("@email", user0.Email);
            sql = "update t_user set email = @email where uid = @uid";
            DButil.update(conn, sql, uid, email);
            SqlParameter major = new SqlParameter("@major", user0.Major);
            sql = "update t_user set major = @major where uid = @uid";
            DButil.update(conn, sql, uid, major);
            SqlParameter password = new SqlParameter("@password", user0.Password);
            sql = "update t_user set password = @password where uid = @uid";
            DButil.update(conn, sql, uid, password);
            SqlParameter isAdmin = new SqlParameter("@isAdmin", user0.IsAdmin);
            sql = "update t_user set isAdmin = @isAdmin where uid = @uid";
            DButil.update(conn, sql, uid, isAdmin);
            SqlParameter isBlack = new SqlParameter("@isBlack", user0.IsBlack);
            sql = "update t_user set isBlack = @isBlack where uid = @uid";
            DButil.update(conn, sql, uid, isBlack);
            DButil.close();

            MessageBox.Show("修改成功！");
            EditUserForm form = new EditUserForm();
            form.user = user;
            form.eUser = user0;
            this.Close();
            form.Show();
        }

        private void passTxt_Leave(object sender, EventArgs e)
        {
            // 密码是否一致
            String pass = passTxt.Text;
            String pass0 = confirmPassTxt.Text;
            if (!(pass == pass0))
            {
                wrongPassTipsLbl.Visible = true;
            }
            else
            {
                wrongPassTipsLbl.Visible = false;
            }
            updateUser();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // 没有报红，按钮可用，并且两个“用户”不相等
            if (!eUser.Equals(user0) && !nameIllegalTIpsLbl.Visible && !phoneIllegalTipsLbl.Visible && !emailIllegalTIpsLbl.Visible && !wrongOriginPassTips.Visible &&
                !wrongPassTipsLbl.Visible)
            {
                confirmBtn.Enabled = true;
            }
            else
            {
                confirmBtn.Enabled = false;
            }

        }

        private void updateUser()
        {
            // 更新用户修改数据
            String sex0 = (boyRBtn.Checked) ? "boy" : "girl";
            Boolean isAdmin0 = isAdminBox.Checked;
            Boolean isBlack0 = isBlackBox.Checked;
            String password0 = eUser.Password;
            if (confirmPassTxt.Text != "" && originPassTxt.Text != "")
            {
                password0 = confirmPassTxt.Text;
            }
            user0 = new User(eUser.Uid, nameTxt.Text, phoneTxt.Text, sex0, emailTxt.Text, majorTxt.Text, password0, isAdmin0, isBlack0);

        }

        private void boyRBtn_Click(object sender, EventArgs e)
        {
            updateUser();
        }

        private void girlRBTn_Click(object sender, EventArgs e)
        {
            updateUser();
        }

        private void confirmPassTxt_MouseLeave(object sender, EventArgs e)
        {
            // 密码是否一致
            String pass = passTxt.Text;
            String pass0 = confirmPassTxt.Text;
            if (!(pass == pass0))
            {
                wrongPassTipsLbl.Visible = true;
            }
            else
            {
                wrongPassTipsLbl.Visible = false;
            }
            updateUser();
        }

        private void isAdminBox_Click(object sender, EventArgs e)
        {
            updateUser();
        }

        private void isBlackBox_Click(object sender, EventArgs e)
        {
            updateUser();
        }

        private void majorTxt_Leave(object sender, EventArgs e)
        {
            if (majorTxt.Text != eUser.Major)
            {
                updateUser();
            }
        }
    }
}
