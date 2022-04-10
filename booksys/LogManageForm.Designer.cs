namespace booksys
{
    partial class LogManageForm
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
            this.viewReturnBox = new System.Windows.Forms.CheckBox();
            this.logSheetView = new System.Windows.Forms.ListView();
            this.uid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.borrowTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.returnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isReturn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label = new System.Windows.Forms.Label();
            this.queryTxt = new System.Windows.Forms.TextBox();
            this.queryBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.bid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // viewReturnBox
            // 
            this.viewReturnBox.AutoSize = true;
            this.viewReturnBox.Location = new System.Drawing.Point(59, 213);
            this.viewReturnBox.Name = "viewReturnBox";
            this.viewReturnBox.Size = new System.Drawing.Size(282, 28);
            this.viewReturnBox.TabIndex = 21;
            this.viewReturnBox.Text = "只看提交申请但未归还";
            this.viewReturnBox.UseVisualStyleBackColor = true;
            this.viewReturnBox.CheckedChanged += new System.EventHandler(this.viewReturnBox_CheckedChanged);
            // 
            // logSheetView
            // 
            this.logSheetView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.uid,
            this.username,
            this.bookname,
            this.borrowTime,
            this.returnTime,
            this.isReturn,
            this.bid});
            this.logSheetView.FullRowSelect = true;
            this.logSheetView.GridLines = true;
            this.logSheetView.HideSelection = false;
            this.logSheetView.Location = new System.Drawing.Point(59, 314);
            this.logSheetView.Margin = new System.Windows.Forms.Padding(4);
            this.logSheetView.Name = "logSheetView";
            this.logSheetView.Size = new System.Drawing.Size(1166, 360);
            this.logSheetView.TabIndex = 22;
            this.logSheetView.UseCompatibleStateImageBehavior = false;
            this.logSheetView.View = System.Windows.Forms.View.Details;
            // 
            // uid
            // 
            this.uid.Text = "用户Id";
            this.uid.Width = 90;
            // 
            // username
            // 
            this.username.DisplayIndex = 2;
            this.username.Text = "用户名";
            this.username.Width = 80;
            // 
            // bookname
            // 
            this.bookname.DisplayIndex = 1;
            this.bookname.Text = "书名";
            this.bookname.Width = 90;
            // 
            // borrowTime
            // 
            this.borrowTime.Text = "借阅时间";
            this.borrowTime.Width = 130;
            // 
            // returnTime
            // 
            this.returnTime.Text = "还书时间";
            this.returnTime.Width = 130;
            // 
            // isReturn
            // 
            this.isReturn.Text = "是否还书";
            this.isReturn.Width = 97;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.Location = new System.Drawing.Point(359, 44);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(166, 37);
            this.label.TabIndex = 23;
            this.label.Text = "用户Id：";
            // 
            // queryTxt
            // 
            this.queryTxt.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.queryTxt.Location = new System.Drawing.Point(619, 37);
            this.queryTxt.Name = "queryTxt";
            this.queryTxt.Size = new System.Drawing.Size(353, 50);
            this.queryTxt.TabIndex = 24;
            // 
            // queryBtn
            // 
            this.queryBtn.Enabled = false;
            this.queryBtn.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.queryBtn.Location = new System.Drawing.Point(1019, 37);
            this.queryBtn.Name = "queryBtn";
            this.queryBtn.Size = new System.Drawing.Size(206, 50);
            this.queryBtn.TabIndex = 25;
            this.queryBtn.Text = "查询";
            this.queryBtn.UseVisualStyleBackColor = true;
            this.queryBtn.Click += new System.EventHandler(this.queryBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resetBtn.Location = new System.Drawing.Point(1019, 119);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(206, 50);
            this.resetBtn.TabIndex = 26;
            this.resetBtn.Text = "重置";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.Enabled = false;
            this.returnBtn.Location = new System.Drawing.Point(1003, 223);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(222, 72);
            this.returnBtn.TabIndex = 27;
            this.returnBtn.Text = "已归还";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // bid
            // 
            this.bid.Text = "图书Id";
            // 
            // LogManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 700);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.queryBtn);
            this.Controls.Add(this.queryTxt);
            this.Controls.Add(this.label);
            this.Controls.Add(this.logSheetView);
            this.Controls.Add(this.viewReturnBox);
            this.Name = "LogManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "借阅管理";
            this.Load += new System.EventHandler(this.LogManageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox viewReturnBox;
        private System.Windows.Forms.ListView logSheetView;
        private System.Windows.Forms.ColumnHeader uid;
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.ColumnHeader bookname;
        private System.Windows.Forms.ColumnHeader borrowTime;
        private System.Windows.Forms.ColumnHeader returnTime;
        private System.Windows.Forms.ColumnHeader isReturn;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox queryTxt;
        private System.Windows.Forms.Button queryBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ColumnHeader bid;
    }
}