using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace booksys
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // 刷新状态栏中的时间
            this.toolStripTime.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            // 退出按钮实现
            DialogResult result = MessageBox.Show("确定要退出吗？", "Tips", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result.ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // 登录按钮实现
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void register_Click(object sender, EventArgs e)
        {
            // 注册按钮实现
            Register registerForm = new Register();
            registerForm.Show();
        }

        private void checkBookBtn_Click(object sender, EventArgs e)
        {
            new UserForm().Show();
        }
    }
}
