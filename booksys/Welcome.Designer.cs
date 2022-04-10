namespace booksys
{
    partial class Welcome
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.loginBtn = new System.Windows.Forms.Button();
            this.checkBookBtn = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.statusStripDetail = new System.Windows.Forms.StatusStrip();
            this.toolStripName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripClass = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripId = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripPhoneNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusStripDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(81, 87);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(235, 64);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "登录";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // checkBookBtn
            // 
            this.checkBookBtn.Location = new System.Drawing.Point(461, 87);
            this.checkBookBtn.Name = "checkBookBtn";
            this.checkBookBtn.Size = new System.Drawing.Size(235, 64);
            this.checkBookBtn.TabIndex = 1;
            this.checkBookBtn.Text = "查看书籍";
            this.checkBookBtn.UseVisualStyleBackColor = true;
            this.checkBookBtn.Click += new System.EventHandler(this.checkBookBtn_Click);
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(81, 256);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(235, 64);
            this.register.TabIndex = 2;
            this.register.Text = "注册";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(461, 256);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(235, 64);
            this.exit.TabIndex = 3;
            this.exit.Text = "退出";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // statusStripDetail
            // 
            this.statusStripDetail.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStripDetail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripName,
            this.toolStripClass,
            this.toolStripId,
            this.toolStripPhoneNum,
            this.toolStripTime});
            this.statusStripDetail.Location = new System.Drawing.Point(0, 417);
            this.statusStripDetail.Name = "statusStripDetail";
            this.statusStripDetail.Size = new System.Drawing.Size(800, 33);
            this.statusStripDetail.TabIndex = 4;
            this.statusStripDetail.Text = "statusStrip1";
            // 
            // toolStripName
            // 
            this.toolStripName.Name = "toolStripName";
            this.toolStripName.Size = new System.Drawing.Size(53, 28);
            this.toolStripName.Text = "CCB";
            // 
            // toolStripClass
            // 
            this.toolStripClass.Name = "toolStripClass";
            this.toolStripClass.Size = new System.Drawing.Size(129, 28);
            this.toolStripClass.Text = "软件工程2班";
            // 
            // toolStripId
            // 
            this.toolStripId.Name = "toolStripId";
            this.toolStripId.Size = new System.Drawing.Size(132, 28);
            this.toolStripId.Text = "1925122002";
            // 
            // toolStripPhoneNum
            // 
            this.toolStripPhoneNum.Name = "toolStripPhoneNum";
            this.toolStripPhoneNum.Size = new System.Drawing.Size(144, 28);
            this.toolStripPhoneNum.Text = "18030201617";
            // 
            // toolStripTime
            // 
            this.toolStripTime.Name = "toolStripTime";
            this.toolStripTime.Size = new System.Drawing.Size(18, 28);
            this.toolStripTime.Text = " ";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::booksys.Properties.Resources.f072e181b7ec6e267799c2c79e4b4f5a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStripDetail);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.register);
            this.Controls.Add(this.checkBookBtn);
            this.Controls.Add(this.loginBtn);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HQU图书管理系统";
            this.statusStripDetail.ResumeLayout(false);
            this.statusStripDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button checkBookBtn;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.StatusStrip statusStripDetail;
        private System.Windows.Forms.ToolStripStatusLabel toolStripName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripClass;
        private System.Windows.Forms.ToolStripStatusLabel toolStripId;
        private System.Windows.Forms.ToolStripStatusLabel toolStripPhoneNum;
        private System.Windows.Forms.ToolStripStatusLabel toolStripTime;
        private System.Windows.Forms.Timer timer;
    }
}

