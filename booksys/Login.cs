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
    public partial class Login : Form
    {
        public static int loginCount = 3;// 登陆后或退出后重置
        public String uidStr = null;
        public Login()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // 如果输入了用户id和密码，登录按钮才能用并且用户存在，其余都不能用
            if (uidTxt.Text != "" && passwordTxt.Text != "" && !isExitIdTips.Visible)
            {
                loginBtn.Enabled = true;
                tips.Text = "";
            }
            else
            {
                loginBtn.Enabled = false;
                tips.Text = "请输入用户Id和密码";
            }

        }

        private void registBtn_Click(object sender, EventArgs e)
        {
            // 注册按钮实现
            Register registerForm = new Register();
            registerForm.Show();
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // 实现登录按钮
            String sql = "select uid, username, phone, sex, email, password, major, isAdmin, isBlack from t_user where " +
                "uid = @uid and password = @password";
            SqlParameter uid = new SqlParameter("@uid", uidTxt.Text);
            SqlParameter password = new SqlParameter("@password", passwordTxt.Text);
            SqlDataReader reader = DButil.query(sql, uid, password);
            User user = User.ToBean(reader);
            DButil.close();// 关闭连接
            if (user != null)
            {
                if(user.IsAdmin)
                {
                    // 用户是管理员
                    AdminForm aForm = new AdminForm();
                    aForm.user = user;
                    aForm.Show();
                    this.Close();

                }
                else
                {
                    // 用户是普通用户，判断是不是黑名单内
                    if (user.IsBlack)
                    {
                        MessageBox.Show("对不起，你当前在黑名单中，无法进入，请联系管理员解决");
                    }
                    else
                    {
                        // 进入用户界面
                        loginCount = 3;
                        UserForm userForm = new UserForm();
                        userForm.user = user;
                        this.Close();
                        userForm.Show();
                    }
                }
            }
            else
            {
                loginCount--;
                if(loginCount <= 0)
                {
                    MessageBox.Show("登录次数上限，请联系管理员修改账户信息");
                    loginCount = 3;
                    this.Close();// 关闭窗体
                    return;
                }
                MessageBox.Show("登录失败，请重新输入,您目前还有" + loginCount + "次机会！");
                this.passwordTxt.Text = "";
            }
        }

        private void uidTxt_Leave(object sender, EventArgs e)
        {
            // 判断用户id是否存在
            SqlParameter uid = new SqlParameter("@uid", uidTxt.Text);
            String sql = "select uid, username, phone, sex, email, password, major, isAdmin, isBlack from t_user where " +
                "uid = @uid";
            SqlDataReader reader = DButil.query(sql, uid);
            if (! reader.Read())
            {
                isExitIdTips.Visible = true;
                loginBtn.Enabled = false;
            }
            else
            {
                isExitIdTips.Visible = false;
                loginBtn.Enabled = false;
            }
            DButil.close();
        }

        private void Login_Activated(object sender, EventArgs e)
        {
            // 回显账号，如果有
            uidTxt.Text = (uidStr == null) ? "" : uidStr;
        }
    }
}
