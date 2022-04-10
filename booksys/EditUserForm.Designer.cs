namespace booksys
{
    partial class EditUserForm
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
            this.majorTxt = new System.Windows.Forms.ComboBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.majorLbl = new System.Windows.Forms.Label();
            this.sexLbl = new System.Windows.Forms.Label();
            this.boyRBtn = new System.Windows.Forms.RadioButton();
            this.girlRBTn = new System.Windows.Forms.RadioButton();
            this.nameLbl = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.passLbl = new System.Windows.Forms.Label();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.confirmPassLbl = new System.Windows.Forms.Label();
            this.originPassLbl = new System.Windows.Forms.Label();
            this.originPassTxt = new System.Windows.Forms.TextBox();
            this.confirmPassTxt = new System.Windows.Forms.TextBox();
            this.isAdminBox = new System.Windows.Forms.CheckBox();
            this.isBlackBox = new System.Windows.Forms.CheckBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.nameIllegalTIpsLbl = new System.Windows.Forms.Label();
            this.phoneIllegalTipsLbl = new System.Windows.Forms.Label();
            this.emailIllegalTIpsLbl = new System.Windows.Forms.Label();
            this.wrongPassTipsLbl = new System.Windows.Forms.Label();
            this.wrongOriginPassTips = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // majorTxt
            // 
            this.majorTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.majorTxt.Enabled = false;
            this.majorTxt.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.majorTxt.FormattingEnabled = true;
            this.majorTxt.Items.AddRange(new object[] {
            "无",
            "2019级软件工程1班",
            "2019级软件工程2班",
            "2018级软件工程2班",
            "2018级软件工程1班",
            "2019级信息安全2班",
            "2019级信息安全1班",
            "2019级计算机科学与技术1班"});
            this.majorTxt.Location = new System.Drawing.Point(218, 84);
            this.majorTxt.Margin = new System.Windows.Forms.Padding(4);
            this.majorTxt.Name = "majorTxt";
            this.majorTxt.Size = new System.Drawing.Size(456, 46);
            this.majorTxt.TabIndex = 12;
            this.majorTxt.Leave += new System.EventHandler(this.majorTxt_Leave);
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameTxt.Location = new System.Drawing.Point(222, 278);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(454, 51);
            this.nameTxt.TabIndex = 17;
            this.nameTxt.Leave += new System.EventHandler(this.nameTxt_Leave);
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.BackColor = System.Drawing.Color.Transparent;
            this.phoneLbl.Font = new System.Drawing.Font("微软雅黑", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phoneLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phoneLbl.Location = new System.Drawing.Point(72, 384);
            this.phoneLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(136, 50);
            this.phoneLbl.TabIndex = 18;
            this.phoneLbl.Text = "手机：";
            this.phoneLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // majorLbl
            // 
            this.majorLbl.AutoSize = true;
            this.majorLbl.BackColor = System.Drawing.Color.Transparent;
            this.majorLbl.Font = new System.Drawing.Font("微软雅黑", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.majorLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.majorLbl.Location = new System.Drawing.Point(72, 82);
            this.majorLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.majorLbl.Name = "majorLbl";
            this.majorLbl.Size = new System.Drawing.Size(136, 50);
            this.majorLbl.TabIndex = 19;
            this.majorLbl.Text = "专业：";
            this.majorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sexLbl
            // 
            this.sexLbl.AutoSize = true;
            this.sexLbl.BackColor = System.Drawing.Color.Transparent;
            this.sexLbl.Font = new System.Drawing.Font("微软雅黑", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sexLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sexLbl.Location = new System.Drawing.Point(74, 188);
            this.sexLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sexLbl.Name = "sexLbl";
            this.sexLbl.Size = new System.Drawing.Size(136, 50);
            this.sexLbl.TabIndex = 20;
            this.sexLbl.Text = "性别：";
            this.sexLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // boyRBtn
            // 
            this.boyRBtn.AutoSize = true;
            this.boyRBtn.BackColor = System.Drawing.Color.Transparent;
            this.boyRBtn.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.boyRBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boyRBtn.Location = new System.Drawing.Point(220, 192);
            this.boyRBtn.Margin = new System.Windows.Forms.Padding(4);
            this.boyRBtn.Name = "boyRBtn";
            this.boyRBtn.Size = new System.Drawing.Size(86, 42);
            this.boyRBtn.TabIndex = 21;
            this.boyRBtn.TabStop = true;
            this.boyRBtn.Text = "男";
            this.boyRBtn.UseVisualStyleBackColor = false;
            this.boyRBtn.Click += new System.EventHandler(this.boyRBtn_Click);
            // 
            // girlRBTn
            // 
            this.girlRBTn.AutoSize = true;
            this.girlRBTn.BackColor = System.Drawing.Color.Transparent;
            this.girlRBTn.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.girlRBTn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.girlRBTn.Location = new System.Drawing.Point(344, 192);
            this.girlRBTn.Margin = new System.Windows.Forms.Padding(4);
            this.girlRBTn.Name = "girlRBTn";
            this.girlRBTn.Size = new System.Drawing.Size(86, 42);
            this.girlRBTn.TabIndex = 22;
            this.girlRBTn.TabStop = true;
            this.girlRBTn.Text = "女";
            this.girlRBTn.UseVisualStyleBackColor = false;
            this.girlRBTn.Click += new System.EventHandler(this.girlRBTn_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Font = new System.Drawing.Font("微软雅黑", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nameLbl.Location = new System.Drawing.Point(76, 276);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(136, 50);
            this.nameLbl.TabIndex = 23;
            this.nameLbl.Text = "姓名：";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phoneTxt.Location = new System.Drawing.Point(222, 386);
            this.phoneTxt.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(456, 51);
            this.phoneTxt.TabIndex = 24;
            this.phoneTxt.Leave += new System.EventHandler(this.phoneTxt_Leave);
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.BackColor = System.Drawing.Color.Transparent;
            this.emailLbl.Font = new System.Drawing.Font("微软雅黑", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.emailLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.emailLbl.Location = new System.Drawing.Point(72, 494);
            this.emailLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(136, 50);
            this.emailLbl.TabIndex = 25;
            this.emailLbl.Text = "邮箱：";
            this.emailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.emailTxt.Location = new System.Drawing.Point(218, 496);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(4);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(456, 51);
            this.emailTxt.TabIndex = 26;
            this.emailTxt.Leave += new System.EventHandler(this.emailTxt_Leave);
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.BackColor = System.Drawing.Color.Transparent;
            this.passLbl.Font = new System.Drawing.Font("微软雅黑", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passLbl.Location = new System.Drawing.Point(38, 702);
            this.passLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(174, 50);
            this.passLbl.TabIndex = 27;
            this.passLbl.Text = "新密码：";
            this.passLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passTxt
            // 
            this.passTxt.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passTxt.Location = new System.Drawing.Point(220, 704);
            this.passTxt.Margin = new System.Windows.Forms.Padding(4);
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '*';
            this.passTxt.Size = new System.Drawing.Size(456, 51);
            this.passTxt.TabIndex = 28;
            this.passTxt.Leave += new System.EventHandler(this.passTxt_Leave);
            // 
            // confirmPassLbl
            // 
            this.confirmPassLbl.AutoSize = true;
            this.confirmPassLbl.BackColor = System.Drawing.Color.Transparent;
            this.confirmPassLbl.Font = new System.Drawing.Font("微软雅黑", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmPassLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.confirmPassLbl.Location = new System.Drawing.Point(0, 790);
            this.confirmPassLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmPassLbl.Name = "confirmPassLbl";
            this.confirmPassLbl.Size = new System.Drawing.Size(212, 50);
            this.confirmPassLbl.TabIndex = 29;
            this.confirmPassLbl.Text = "确认密码：";
            this.confirmPassLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // originPassLbl
            // 
            this.originPassLbl.AutoSize = true;
            this.originPassLbl.BackColor = System.Drawing.Color.Transparent;
            this.originPassLbl.Font = new System.Drawing.Font("微软雅黑", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.originPassLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.originPassLbl.Location = new System.Drawing.Point(38, 600);
            this.originPassLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.originPassLbl.Name = "originPassLbl";
            this.originPassLbl.Size = new System.Drawing.Size(174, 50);
            this.originPassLbl.TabIndex = 30;
            this.originPassLbl.Text = "原密码：";
            this.originPassLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // originPassTxt
            // 
            this.originPassTxt.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.originPassTxt.Location = new System.Drawing.Point(218, 600);
            this.originPassTxt.Margin = new System.Windows.Forms.Padding(4);
            this.originPassTxt.Name = "originPassTxt";
            this.originPassTxt.PasswordChar = '*';
            this.originPassTxt.Size = new System.Drawing.Size(456, 51);
            this.originPassTxt.TabIndex = 31;
            this.originPassTxt.Leave += new System.EventHandler(this.originPassTxt_Leave);
            // 
            // confirmPassTxt
            // 
            this.confirmPassTxt.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmPassTxt.Location = new System.Drawing.Point(222, 792);
            this.confirmPassTxt.Margin = new System.Windows.Forms.Padding(4);
            this.confirmPassTxt.Name = "confirmPassTxt";
            this.confirmPassTxt.PasswordChar = '*';
            this.confirmPassTxt.Size = new System.Drawing.Size(456, 51);
            this.confirmPassTxt.TabIndex = 32;
            this.confirmPassTxt.Leave += new System.EventHandler(this.confirmPassTxt_Leave);
            this.confirmPassTxt.MouseLeave += new System.EventHandler(this.confirmPassTxt_MouseLeave);
            // 
            // isAdminBox
            // 
            this.isAdminBox.AutoSize = true;
            this.isAdminBox.BackColor = System.Drawing.Color.Transparent;
            this.isAdminBox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.isAdminBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.isAdminBox.Location = new System.Drawing.Point(218, 926);
            this.isAdminBox.Margin = new System.Windows.Forms.Padding(6);
            this.isAdminBox.Name = "isAdminBox";
            this.isAdminBox.Size = new System.Drawing.Size(163, 42);
            this.isAdminBox.TabIndex = 33;
            this.isAdminBox.Text = "管理员";
            this.isAdminBox.UseVisualStyleBackColor = false;
            this.isAdminBox.Visible = false;
            this.isAdminBox.Click += new System.EventHandler(this.isAdminBox_Click);
            // 
            // isBlackBox
            // 
            this.isBlackBox.AutoSize = true;
            this.isBlackBox.BackColor = System.Drawing.Color.Transparent;
            this.isBlackBox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.isBlackBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.isBlackBox.Location = new System.Drawing.Point(218, 996);
            this.isBlackBox.Margin = new System.Windows.Forms.Padding(6);
            this.isBlackBox.Name = "isBlackBox";
            this.isBlackBox.Size = new System.Drawing.Size(163, 42);
            this.isBlackBox.TabIndex = 34;
            this.isBlackBox.Text = "黑名单";
            this.isBlackBox.UseVisualStyleBackColor = false;
            this.isBlackBox.Visible = false;
            this.isBlackBox.Click += new System.EventHandler(this.isBlackBox_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Enabled = false;
            this.confirmBtn.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmBtn.Location = new System.Drawing.Point(488, 940);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(4);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(192, 102);
            this.confirmBtn.TabIndex = 35;
            this.confirmBtn.Text = "确定";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // nameIllegalTIpsLbl
            // 
            this.nameIllegalTIpsLbl.AutoSize = true;
            this.nameIllegalTIpsLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameIllegalTIpsLbl.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameIllegalTIpsLbl.ForeColor = System.Drawing.Color.Red;
            this.nameIllegalTIpsLbl.Location = new System.Drawing.Point(220, 340);
            this.nameIllegalTIpsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameIllegalTIpsLbl.Name = "nameIllegalTIpsLbl";
            this.nameIllegalTIpsLbl.Size = new System.Drawing.Size(435, 38);
            this.nameIllegalTIpsLbl.TabIndex = 21;
            this.nameIllegalTIpsLbl.Text = "姓名不合法，请重新输入";
            this.nameIllegalTIpsLbl.Visible = false;
            // 
            // phoneIllegalTipsLbl
            // 
            this.phoneIllegalTipsLbl.AutoSize = true;
            this.phoneIllegalTipsLbl.BackColor = System.Drawing.Color.Transparent;
            this.phoneIllegalTipsLbl.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phoneIllegalTipsLbl.ForeColor = System.Drawing.Color.Red;
            this.phoneIllegalTipsLbl.Location = new System.Drawing.Point(220, 448);
            this.phoneIllegalTipsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneIllegalTipsLbl.Name = "phoneIllegalTipsLbl";
            this.phoneIllegalTipsLbl.Size = new System.Drawing.Size(473, 38);
            this.phoneIllegalTipsLbl.TabIndex = 36;
            this.phoneIllegalTipsLbl.Text = "手机号为11位，请重新输入";
            this.phoneIllegalTipsLbl.Visible = false;
            // 
            // emailIllegalTIpsLbl
            // 
            this.emailIllegalTIpsLbl.AutoSize = true;
            this.emailIllegalTIpsLbl.BackColor = System.Drawing.Color.Transparent;
            this.emailIllegalTIpsLbl.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.emailIllegalTIpsLbl.ForeColor = System.Drawing.Color.Red;
            this.emailIllegalTIpsLbl.Location = new System.Drawing.Point(220, 558);
            this.emailIllegalTIpsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailIllegalTIpsLbl.Name = "emailIllegalTIpsLbl";
            this.emailIllegalTIpsLbl.Size = new System.Drawing.Size(435, 38);
            this.emailIllegalTIpsLbl.TabIndex = 37;
            this.emailIllegalTIpsLbl.Text = "邮箱不合法，请重新输入";
            this.emailIllegalTIpsLbl.Visible = false;
            // 
            // wrongPassTipsLbl
            // 
            this.wrongPassTipsLbl.AutoSize = true;
            this.wrongPassTipsLbl.BackColor = System.Drawing.Color.Transparent;
            this.wrongPassTipsLbl.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wrongPassTipsLbl.ForeColor = System.Drawing.Color.Red;
            this.wrongPassTipsLbl.Location = new System.Drawing.Point(222, 854);
            this.wrongPassTipsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wrongPassTipsLbl.Name = "wrongPassTipsLbl";
            this.wrongPassTipsLbl.Size = new System.Drawing.Size(511, 38);
            this.wrongPassTipsLbl.TabIndex = 38;
            this.wrongPassTipsLbl.Text = "两次密码不一致，请重新输入";
            this.wrongPassTipsLbl.Visible = false;
            // 
            // wrongOriginPassTips
            // 
            this.wrongOriginPassTips.AutoSize = true;
            this.wrongOriginPassTips.BackColor = System.Drawing.Color.Transparent;
            this.wrongOriginPassTips.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wrongOriginPassTips.ForeColor = System.Drawing.Color.Red;
            this.wrongOriginPassTips.Location = new System.Drawing.Point(222, 662);
            this.wrongOriginPassTips.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wrongOriginPassTips.Name = "wrongOriginPassTips";
            this.wrongOriginPassTips.Size = new System.Drawing.Size(435, 38);
            this.wrongOriginPassTips.TabIndex = 39;
            this.wrongOriginPassTips.Text = "原密码错误，请重新输入";
            this.wrongOriginPassTips.Visible = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 1263);
            this.Controls.Add(this.wrongOriginPassTips);
            this.Controls.Add(this.wrongPassTipsLbl);
            this.Controls.Add(this.emailIllegalTIpsLbl);
            this.Controls.Add(this.phoneIllegalTipsLbl);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.isBlackBox);
            this.Controls.Add(this.isAdminBox);
            this.Controls.Add(this.nameIllegalTIpsLbl);
            this.Controls.Add(this.confirmPassTxt);
            this.Controls.Add(this.originPassTxt);
            this.Controls.Add(this.originPassLbl);
            this.Controls.Add(this.confirmPassLbl);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.girlRBTn);
            this.Controls.Add(this.boyRBtn);
            this.Controls.Add(this.sexLbl);
            this.Controls.Add(this.majorLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.majorTxt);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EditUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑用户信息";
            this.Load += new System.EventHandler(this.EditUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox majorTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label majorLbl;
        private System.Windows.Forms.Label sexLbl;
        private System.Windows.Forms.RadioButton boyRBtn;
        private System.Windows.Forms.RadioButton girlRBTn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Label confirmPassLbl;
        private System.Windows.Forms.Label originPassLbl;
        private System.Windows.Forms.TextBox originPassTxt;
        private System.Windows.Forms.TextBox confirmPassTxt;
        private System.Windows.Forms.CheckBox isAdminBox;
        private System.Windows.Forms.CheckBox isBlackBox;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label nameIllegalTIpsLbl;
        private System.Windows.Forms.Label phoneIllegalTipsLbl;
        private System.Windows.Forms.Label emailIllegalTIpsLbl;
        private System.Windows.Forms.Label wrongPassTipsLbl;
        private System.Windows.Forms.Label wrongOriginPassTips;
        private System.Windows.Forms.Timer timer;
    }
}