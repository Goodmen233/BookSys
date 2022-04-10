namespace booksys
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.uid = new System.Windows.Forms.Label();
            this.uidTxt = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.registBtn = new System.Windows.Forms.Button();
            this.tips = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.isExitIdTips = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uid
            // 
            this.uid.BackColor = System.Drawing.Color.Transparent;
            this.uid.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uid.Location = new System.Drawing.Point(106, 72);
            this.uid.Name = "uid";
            this.uid.Size = new System.Drawing.Size(141, 62);
            this.uid.TabIndex = 0;
            this.uid.Text = "用户Id：";
            this.uid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uidTxt
            // 
            this.uidTxt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uidTxt.Location = new System.Drawing.Point(217, 86);
            this.uidTxt.Name = "uidTxt";
            this.uidTxt.Size = new System.Drawing.Size(222, 39);
            this.uidTxt.TabIndex = 2;
            this.uidTxt.Leave += new System.EventHandler(this.uidTxt_Leave);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.Location = new System.Drawing.Point(128, 165);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(119, 62);
            this.password.TabIndex = 3;
            this.password.Text = "密码：";
            this.password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwordTxt.Location = new System.Drawing.Point(217, 179);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(222, 39);
            this.passwordTxt.TabIndex = 4;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.Enabled = false;
            this.loginBtn.Location = new System.Drawing.Point(330, 251);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(120, 43);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "登录";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // registBtn
            // 
            this.registBtn.BackColor = System.Drawing.Color.Transparent;
            this.registBtn.Location = new System.Drawing.Point(469, 251);
            this.registBtn.Name = "registBtn";
            this.registBtn.Size = new System.Drawing.Size(120, 43);
            this.registBtn.TabIndex = 6;
            this.registBtn.Text = "注册";
            this.registBtn.UseVisualStyleBackColor = false;
            this.registBtn.Click += new System.EventHandler(this.registBtn_Click);
            // 
            // tips
            // 
            this.tips.AutoSize = true;
            this.tips.BackColor = System.Drawing.Color.Transparent;
            this.tips.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tips.ForeColor = System.Drawing.Color.Red;
            this.tips.Location = new System.Drawing.Point(129, 25);
            this.tips.Name = "tips";
            this.tips.Size = new System.Drawing.Size(321, 34);
            this.tips.TabIndex = 7;
            this.tips.Text = "请输入用户Id和密码";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // isExitIdTips
            // 
            this.isExitIdTips.AutoSize = true;
            this.isExitIdTips.BackColor = System.Drawing.Color.Transparent;
            this.isExitIdTips.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.isExitIdTips.ForeColor = System.Drawing.Color.Red;
            this.isExitIdTips.Location = new System.Drawing.Point(211, 134);
            this.isExitIdTips.Name = "isExitIdTips";
            this.isExitIdTips.Size = new System.Drawing.Size(219, 34);
            this.isExitIdTips.TabIndex = 8;
            this.isExitIdTips.Text = "用户Id不存在";
            this.isExitIdTips.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::booksys.Properties.Resources.login1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(611, 331);
            this.Controls.Add(this.isExitIdTips);
            this.Controls.Add(this.tips);
            this.Controls.Add(this.registBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.password);
            this.Controls.Add(this.uidTxt);
            this.Controls.Add(this.uid);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Activated += new System.EventHandler(this.Login_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uid;
        private System.Windows.Forms.TextBox uidTxt;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button registBtn;
        private System.Windows.Forms.Label tips;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label isExitIdTips;
    }
}