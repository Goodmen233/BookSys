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
using System.Text.RegularExpressions;

namespace booksys
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            // 注册功能实现
            SqlParameter uid = new SqlParameter("@uid", uidTxt.Text);
            SqlParameter major = new SqlParameter("@major", majorTxt.Text);
            String sexStr = (boyRBtn.Checked) ? "boy" : "girl" ;
            SqlParameter sex = new SqlParameter("@sex", sexStr);
            SqlParameter username = new SqlParameter("@username", nameTxt.Text);
            SqlParameter phone = new SqlParameter("@phone", phoneTxt.Text);
            SqlParameter email = new SqlParameter("@email", emailTxt.Text);
            SqlParameter password = new SqlParameter("@password", passTxt.Text);
            String sql = "insert into t_user values(@uid, @username, @phone, @sex, @email, @major, @password, 0, 0)";
            int i = DButil.update(sql, uid, major, sex, username, phone, email, password);
            DButil.close();
            if(i == 0)
            {
                MessageBox.Show("注册失败，请联系后台管理员处理");
            }
            else
            {
                MessageBox.Show("注册成功");
                // 跳到登录页面,回显账户信息
                Login login = new Login();
                login.uidStr = uidTxt.Text;
                this.Close();
                login.Show();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // 检测注册按钮是否可用
            if(uidTxt.Text != "" && majorTxt.Text != "" && (boyRBtn.Checked || girlRBTn.Checked) &&
                nameTxt.Text != "" && phoneTxt.Text != "" && emailTxt.Text != "" && passTxt.Text != "" &&
                    confirmPassTxt.Text != "" && !exitUidTipsLbl.Visible && !nameIllegalTIpsLbl.Visible &&
                        !phoneIllegalTipsLbl.Visible && !emailIllegalTIpsLbl.Visible && !wrongPassTipsLbl.Visible)
            {
                registerBtn.Enabled = true;
            }
            else
            {
                registerBtn.Enabled = false;
            }

        }

        private void uidTxt_Leave(object sender, EventArgs e)
        {
            // 用户是否存在
            String sql = "select uid from t_user where uid = @uid";
            SqlParameter uid = new SqlParameter("@uid", uidTxt.Text);
            SqlDataReader reader = DButil.query(sql, uid);
            if(reader.Read())
            {
                exitUidTipsLbl.Visible = true;
                registerBtn.Enabled = false;
            }
            else
            {
                exitUidTipsLbl.Visible = false;
            }
            DButil.close();
        }

        private void nameTxt_Leave(object sender, EventArgs e)
        {
            // 姓名是否合法
            String name = nameTxt.Text;
            Boolean isLegal = true;
            foreach(char c in name)
            {
                if(Char.IsNumber(c))
                {
                    isLegal = false;
                }
            }
            if (! isLegal)
            {
                nameIllegalTIpsLbl.Visible = true;
                registerBtn.Enabled = false;
            }
            else
            {
                nameIllegalTIpsLbl.Visible = false;
            }
        }

        private void phoneTxt_Leave(object sender, EventArgs e)
        {
            // 手机号是否合法
            String phone = phoneTxt.Text;
            if(phone.Length != 11 || phone == "")
            {
                phoneIllegalTipsLbl.Visible = true;
                registerBtn.Enabled = false;
            }
            else
            {
                phoneIllegalTipsLbl.Visible = false;
            }
        }

        private void emailTxt_Leave(object sender, EventArgs e)
        {
            // 邮箱是否合法
            String email = emailTxt.Text;
            Regex regex = new Regex(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            if(!regex.IsMatch(email))
            {
                emailIllegalTIpsLbl.Visible = true;
                registerBtn.Enabled = false;
            }
            else
            {
                emailIllegalTIpsLbl.Visible = false;
            }
        }

        private void confirmPassTxt_Leave(object sender, EventArgs e)
        {
            // 密码是否一致
            String pass = passTxt.Text;
            String pass0 = confirmPassTxt.Text;
            if(! (pass == pass0))
            {
                wrongPassTipsLbl.Visible = true;
                registerBtn.Enabled = false;
            }
            else
            {
                wrongPassTipsLbl.Visible = false;
            }
        }
    }
}
