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
    public partial class AdminForm : Form
    {
        public User user = null;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.Text = "欢迎 " + user.Username + " 管理员！";
            // 挂失代办提示
            String sql = "select count(*) from t_lossSheet where isDeal=0";
            int count = DButil.queryScalar(sql);
            unDoLbl.Text = count + "";
            // 借阅代办提示
            sql = "select count(*) from t_logSheet where isReturn=0 and returnTime!='1978-12-31 12:12:12.000'";
            int count0 = DButil.queryScalar(sql);
            unDoLogLbl.Text = count0 + "";
        }

        private void lossManageBtn_Click(object sender, EventArgs e)
        {
            new LossManageForm().Show();
        }

        private void AdminForm_Activated(object sender, EventArgs e)
        {
            // 挂失代办提示
            String sql = "select count(*) from t_lossSheet where isDeal=0";
            int count = DButil.queryScalar(sql);
            unDoLbl.Text = count + "";
            // 借阅代办提示
            sql = "select count(*) from t_logSheet where isReturn=0 and returnTime!='1978-12-31 12:12:12.000'";
            int count0 = DButil.queryScalar(sql);
            unDoLogLbl.Text = count0 + "";
        }

        private void logManageBtn_Click(object sender, EventArgs e)
        {
            new LogManageForm().Show();
        }

        private void userManageBtn_Click(object sender, EventArgs e)
        {
            UserInfoForm form = new UserInfoForm(user);
            form.Show();
        }

        private void bookManageBtn_Click(object sender, EventArgs e)
        {
            new BookInfoForm().Show();
        }
    }
}
