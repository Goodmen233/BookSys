namespace booksys
{
    partial class AdminForm
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
            this.userManageBtn = new System.Windows.Forms.Button();
            this.bookManageBtn = new System.Windows.Forms.Button();
            this.logManageBtn = new System.Windows.Forms.Button();
            this.lossManageBtn = new System.Windows.Forms.Button();
            this.unDoLbl = new System.Windows.Forms.Label();
            this.unDoLogLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userManageBtn
            // 
            this.userManageBtn.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userManageBtn.Location = new System.Drawing.Point(108, 80);
            this.userManageBtn.Name = "userManageBtn";
            this.userManageBtn.Size = new System.Drawing.Size(247, 125);
            this.userManageBtn.TabIndex = 0;
            this.userManageBtn.Text = "用户管理";
            this.userManageBtn.UseVisualStyleBackColor = true;
            this.userManageBtn.Click += new System.EventHandler(this.userManageBtn_Click);
            // 
            // bookManageBtn
            // 
            this.bookManageBtn.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bookManageBtn.Location = new System.Drawing.Point(533, 80);
            this.bookManageBtn.Name = "bookManageBtn";
            this.bookManageBtn.Size = new System.Drawing.Size(247, 125);
            this.bookManageBtn.TabIndex = 1;
            this.bookManageBtn.Text = "图书管理";
            this.bookManageBtn.UseVisualStyleBackColor = true;
            this.bookManageBtn.Click += new System.EventHandler(this.bookManageBtn_Click);
            // 
            // logManageBtn
            // 
            this.logManageBtn.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logManageBtn.Location = new System.Drawing.Point(108, 304);
            this.logManageBtn.Name = "logManageBtn";
            this.logManageBtn.Size = new System.Drawing.Size(247, 125);
            this.logManageBtn.TabIndex = 2;
            this.logManageBtn.Text = "借阅管理";
            this.logManageBtn.UseVisualStyleBackColor = true;
            this.logManageBtn.Click += new System.EventHandler(this.logManageBtn_Click);
            // 
            // lossManageBtn
            // 
            this.lossManageBtn.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lossManageBtn.Location = new System.Drawing.Point(533, 304);
            this.lossManageBtn.Name = "lossManageBtn";
            this.lossManageBtn.Size = new System.Drawing.Size(247, 125);
            this.lossManageBtn.TabIndex = 3;
            this.lossManageBtn.Text = "挂失管理";
            this.lossManageBtn.UseVisualStyleBackColor = true;
            this.lossManageBtn.Click += new System.EventHandler(this.lossManageBtn_Click);
            // 
            // unDoLbl
            // 
            this.unDoLbl.AutoSize = true;
            this.unDoLbl.BackColor = System.Drawing.Color.Transparent;
            this.unDoLbl.ForeColor = System.Drawing.Color.Red;
            this.unDoLbl.Location = new System.Drawing.Point(767, 290);
            this.unDoLbl.Name = "unDoLbl";
            this.unDoLbl.Size = new System.Drawing.Size(22, 24);
            this.unDoLbl.TabIndex = 5;
            this.unDoLbl.Text = "0";
            // 
            // unDoLogLbl
            // 
            this.unDoLogLbl.AutoSize = true;
            this.unDoLogLbl.BackColor = System.Drawing.Color.Transparent;
            this.unDoLogLbl.ForeColor = System.Drawing.Color.Red;
            this.unDoLogLbl.Location = new System.Drawing.Point(342, 290);
            this.unDoLogLbl.Name = "unDoLogLbl";
            this.unDoLogLbl.Size = new System.Drawing.Size(22, 24);
            this.unDoLogLbl.TabIndex = 6;
            this.unDoLogLbl.Text = "0";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 548);
            this.Controls.Add(this.unDoLogLbl);
            this.Controls.Add(this.unDoLbl);
            this.Controls.Add(this.lossManageBtn);
            this.Controls.Add(this.logManageBtn);
            this.Controls.Add(this.bookManageBtn);
            this.Controls.Add(this.userManageBtn);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Activated += new System.EventHandler(this.AdminForm_Activated);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userManageBtn;
        private System.Windows.Forms.Button bookManageBtn;
        private System.Windows.Forms.Button logManageBtn;
        private System.Windows.Forms.Button lossManageBtn;
        private System.Windows.Forms.Label unDoLbl;
        private System.Windows.Forms.Label unDoLogLbl;
    }
}