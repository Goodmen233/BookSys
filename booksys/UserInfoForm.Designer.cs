namespace booksys
{
    partial class UserInfoForm
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
            this.userView = new System.Windows.Forms.ListView();
            this.uid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.major = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isAdmin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isBlack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.queryTxt = new System.Windows.Forms.TextBox();
            this.queryBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.refreshBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userView
            // 
            this.userView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.userView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.uid,
            this.username,
            this.phone,
            this.sex,
            this.email,
            this.major,
            this.password,
            this.isAdmin,
            this.isBlack});
            this.userView.FullRowSelect = true;
            this.userView.GridLines = true;
            this.userView.HideSelection = false;
            this.userView.Location = new System.Drawing.Point(10, 272);
            this.userView.Margin = new System.Windows.Forms.Padding(4);
            this.userView.Name = "userView";
            this.userView.Size = new System.Drawing.Size(1076, 323);
            this.userView.TabIndex = 18;
            this.userView.UseCompatibleStateImageBehavior = false;
            this.userView.View = System.Windows.Forms.View.Details;
            // 
            // uid
            // 
            this.uid.Text = "用户Id";
            // 
            // username
            // 
            this.username.Text = "用户名";
            // 
            // phone
            // 
            this.phone.Text = "手机";
            // 
            // sex
            // 
            this.sex.Text = "性别";
            // 
            // email
            // 
            this.email.Text = "邮箱";
            // 
            // major
            // 
            this.major.Text = "专业";
            // 
            // password
            // 
            this.password.Text = "密码";
            // 
            // isAdmin
            // 
            this.isAdmin.Text = "管理员";
            // 
            // isBlack
            // 
            this.isBlack.Text = "黑名单";
            // 
            // editBtn
            // 
            this.editBtn.Enabled = false;
            this.editBtn.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.editBtn.Location = new System.Drawing.Point(864, 81);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(221, 69);
            this.editBtn.TabIndex = 19;
            this.editBtn.Text = "修改";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Enabled = false;
            this.delBtn.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delBtn.Location = new System.Drawing.Point(864, 185);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(221, 69);
            this.delBtn.TabIndex = 20;
            this.delBtn.Text = "删除";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.Location = new System.Drawing.Point(33, 51);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(166, 37);
            this.label.TabIndex = 24;
            this.label.Text = "用户Id：";
            // 
            // queryTxt
            // 
            this.queryTxt.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.queryTxt.Location = new System.Drawing.Point(222, 48);
            this.queryTxt.Name = "queryTxt";
            this.queryTxt.Size = new System.Drawing.Size(353, 50);
            this.queryTxt.TabIndex = 25;
            // 
            // queryBtn
            // 
            this.queryBtn.Enabled = false;
            this.queryBtn.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.queryBtn.Location = new System.Drawing.Point(611, 48);
            this.queryBtn.Name = "queryBtn";
            this.queryBtn.Size = new System.Drawing.Size(206, 50);
            this.queryBtn.TabIndex = 26;
            this.queryBtn.Text = "查询";
            this.queryBtn.UseVisualStyleBackColor = true;
            this.queryBtn.Click += new System.EventHandler(this.queryBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resetBtn.Location = new System.Drawing.Point(611, 118);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(206, 50);
            this.resetBtn.TabIndex = 27;
            this.resetBtn.Text = "重置";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(40, 185);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(178, 69);
            this.refreshBtn.TabIndex = 28;
            this.refreshBtn.Text = "刷新";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 630);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.queryBtn);
            this.Controls.Add(this.queryTxt);
            this.Controls.Add(this.label);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.userView);
            this.Name = "UserInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView userView;
        private System.Windows.Forms.ColumnHeader uid;
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.ColumnHeader sex;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader major;
        private System.Windows.Forms.ColumnHeader password;
        private System.Windows.Forms.ColumnHeader isAdmin;
        private System.Windows.Forms.ColumnHeader isBlack;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox queryTxt;
        private System.Windows.Forms.Button queryBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button refreshBtn;
    }
}