namespace booksys
{
    partial class ReturnBookForm
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
            this.bookView = new System.Windows.Forms.ListView();
            this.bookname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.borrowTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.returnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isReturn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.returnBookBtn = new System.Windows.Forms.Button();
            this.booknameLbl = new System.Windows.Forms.Label();
            this.booknameTxt = new System.Windows.Forms.TextBox();
            this.queryBtn = new System.Windows.Forms.Button();
            this.exchangeSortBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.lossBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label = new System.Windows.Forms.Label();
            this.viewReturnBtn = new System.Windows.Forms.CheckBox();
            this.bid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // bookView
            // 
            this.bookView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bookname,
            this.borrowTime,
            this.returnTime,
            this.isReturn,
            this.bid});
            this.bookView.FullRowSelect = true;
            this.bookView.GridLines = true;
            this.bookView.HideSelection = false;
            this.bookView.Location = new System.Drawing.Point(86, 314);
            this.bookView.Margin = new System.Windows.Forms.Padding(4);
            this.bookView.Name = "bookView";
            this.bookView.Size = new System.Drawing.Size(1076, 560);
            this.bookView.TabIndex = 18;
            this.bookView.UseCompatibleStateImageBehavior = false;
            this.bookView.View = System.Windows.Forms.View.Details;
            // 
            // bookname
            // 
            this.bookname.Text = "书名";
            this.bookname.Width = 135;
            // 
            // borrowTime
            // 
            this.borrowTime.Text = "借书时间";
            this.borrowTime.Width = 135;
            // 
            // returnTime
            // 
            this.returnTime.Text = "还书时间";
            this.returnTime.Width = 135;
            // 
            // isReturn
            // 
            this.isReturn.Text = "是否成功归还";
            this.isReturn.Width = 135;
            // 
            // returnBookBtn
            // 
            this.returnBookBtn.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.returnBookBtn.Location = new System.Drawing.Point(1016, 242);
            this.returnBookBtn.Margin = new System.Windows.Forms.Padding(6);
            this.returnBookBtn.Name = "returnBookBtn";
            this.returnBookBtn.Size = new System.Drawing.Size(150, 62);
            this.returnBookBtn.TabIndex = 19;
            this.returnBookBtn.Text = "还书";
            this.returnBookBtn.UseVisualStyleBackColor = true;
            this.returnBookBtn.Click += new System.EventHandler(this.returnBookBtn_Click);
            // 
            // booknameLbl
            // 
            this.booknameLbl.AutoSize = true;
            this.booknameLbl.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.booknameLbl.Location = new System.Drawing.Point(96, 62);
            this.booknameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.booknameLbl.Name = "booknameLbl";
            this.booknameLbl.Size = new System.Drawing.Size(112, 38);
            this.booknameLbl.TabIndex = 20;
            this.booknameLbl.Text = "书名:";
            // 
            // booknameTxt
            // 
            this.booknameTxt.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.booknameTxt.Location = new System.Drawing.Point(218, 56);
            this.booknameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.booknameTxt.Name = "booknameTxt";
            this.booknameTxt.Size = new System.Drawing.Size(278, 51);
            this.booknameTxt.TabIndex = 21;
            // 
            // queryBtn
            // 
            this.queryBtn.Enabled = false;
            this.queryBtn.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.queryBtn.Location = new System.Drawing.Point(528, 56);
            this.queryBtn.Margin = new System.Windows.Forms.Padding(6);
            this.queryBtn.Name = "queryBtn";
            this.queryBtn.Size = new System.Drawing.Size(150, 62);
            this.queryBtn.TabIndex = 22;
            this.queryBtn.Text = "查询";
            this.queryBtn.UseVisualStyleBackColor = true;
            this.queryBtn.Click += new System.EventHandler(this.queryBtn_Click);
            // 
            // exchangeSortBtn
            // 
            this.exchangeSortBtn.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exchangeSortBtn.Location = new System.Drawing.Point(104, 124);
            this.exchangeSortBtn.Margin = new System.Windows.Forms.Padding(6);
            this.exchangeSortBtn.Name = "exchangeSortBtn";
            this.exchangeSortBtn.Size = new System.Drawing.Size(396, 80);
            this.exchangeSortBtn.TabIndex = 23;
            this.exchangeSortBtn.Text = "交换时间排序顺序";
            this.exchangeSortBtn.UseVisualStyleBackColor = true;
            this.exchangeSortBtn.Click += new System.EventHandler(this.exchangeSortBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resetBtn.Location = new System.Drawing.Point(528, 134);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(6);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(150, 62);
            this.resetBtn.TabIndex = 24;
            this.resetBtn.Text = "重置";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // lossBtn
            // 
            this.lossBtn.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lossBtn.Location = new System.Drawing.Point(828, 242);
            this.lossBtn.Margin = new System.Windows.Forms.Padding(6);
            this.lossBtn.Name = "lossBtn";
            this.lossBtn.Size = new System.Drawing.Size(150, 62);
            this.lossBtn.TabIndex = 25;
            this.lossBtn.Text = "挂失";
            this.lossBtn.UseVisualStyleBackColor = true;
            this.lossBtn.Click += new System.EventHandler(this.lossBtn_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.Location = new System.Drawing.Point(690, 68);
            this.label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(207, 38);
            this.label.TabIndex = 26;
            this.label.Text = "(模糊查询)";
            // 
            // viewReturnBtn
            // 
            this.viewReturnBtn.AutoSize = true;
            this.viewReturnBtn.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.viewReturnBtn.Location = new System.Drawing.Point(103, 242);
            this.viewReturnBtn.Name = "viewReturnBtn";
            this.viewReturnBtn.Size = new System.Drawing.Size(308, 41);
            this.viewReturnBtn.TabIndex = 27;
            this.viewReturnBtn.Text = "只看未还书成功";
            this.viewReturnBtn.UseVisualStyleBackColor = true;
            this.viewReturnBtn.CheckedChanged += new System.EventHandler(this.viewReturnBtn_CheckedChanged);
            // 
            // bid
            // 
            this.bid.Text = "图书Id";
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 900);
            this.Controls.Add(this.viewReturnBtn);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lossBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.exchangeSortBtn);
            this.Controls.Add(this.queryBtn);
            this.Controls.Add(this.booknameTxt);
            this.Controls.Add(this.booknameLbl);
            this.Controls.Add(this.returnBookBtn);
            this.Controls.Add(this.bookView);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ReturnBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "还书界面";
            this.Load += new System.EventHandler(this.ReturnBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView bookView;
        private System.Windows.Forms.ColumnHeader bookname;
        private System.Windows.Forms.ColumnHeader borrowTime;
        private System.Windows.Forms.ColumnHeader returnTime;
        private System.Windows.Forms.ColumnHeader isReturn;
        private System.Windows.Forms.Button returnBookBtn;
        private System.Windows.Forms.Label booknameLbl;
        private System.Windows.Forms.TextBox booknameTxt;
        private System.Windows.Forms.Button queryBtn;
        private System.Windows.Forms.Button exchangeSortBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button lossBtn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.CheckBox viewReturnBtn;
        private System.Windows.Forms.ColumnHeader bid;
    }
}