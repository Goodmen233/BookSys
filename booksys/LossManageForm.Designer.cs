namespace booksys
{
    partial class LossManageForm
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
            this.lossSheetView = new System.Windows.Forms.ListView();
            this.uid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lossDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isDeal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dealBtn = new System.Windows.Forms.Button();
            this.viewDealBox = new System.Windows.Forms.CheckBox();
            this.queryTxt = new System.Windows.Forms.TextBox();
            this.queryBtn = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.resetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lossSheetView
            // 
            this.lossSheetView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.uid,
            this.username,
            this.bookname,
            this.lossDate,
            this.isDeal});
            this.lossSheetView.FullRowSelect = true;
            this.lossSheetView.GridLines = true;
            this.lossSheetView.HideSelection = false;
            this.lossSheetView.Location = new System.Drawing.Point(65, 237);
            this.lossSheetView.Margin = new System.Windows.Forms.Padding(4);
            this.lossSheetView.Name = "lossSheetView";
            this.lossSheetView.Size = new System.Drawing.Size(950, 360);
            this.lossSheetView.TabIndex = 18;
            this.lossSheetView.UseCompatibleStateImageBehavior = false;
            this.lossSheetView.View = System.Windows.Forms.View.Details;
            // 
            // uid
            // 
            this.uid.Text = "用户Id";
            this.uid.Width = 190;
            // 
            // username
            // 
            this.username.DisplayIndex = 2;
            this.username.Text = "用户名";
            this.username.Width = 190;
            // 
            // bookname
            // 
            this.bookname.DisplayIndex = 1;
            this.bookname.Text = "书名";
            this.bookname.Width = 190;
            // 
            // lossDate
            // 
            this.lossDate.Text = "挂失时间";
            this.lossDate.Width = 190;
            // 
            // isDeal
            // 
            this.isDeal.Text = "是否处理";
            this.isDeal.Width = 190;
            // 
            // dealBtn
            // 
            this.dealBtn.Enabled = false;
            this.dealBtn.Location = new System.Drawing.Point(793, 158);
            this.dealBtn.Name = "dealBtn";
            this.dealBtn.Size = new System.Drawing.Size(222, 72);
            this.dealBtn.TabIndex = 19;
            this.dealBtn.Text = "已处理";
            this.dealBtn.UseVisualStyleBackColor = true;
            this.dealBtn.Click += new System.EventHandler(this.dealBtn_Click);
            // 
            // viewDealBox
            // 
            this.viewDealBox.AutoSize = true;
            this.viewDealBox.Location = new System.Drawing.Point(65, 158);
            this.viewDealBox.Name = "viewDealBox";
            this.viewDealBox.Size = new System.Drawing.Size(306, 28);
            this.viewDealBox.TabIndex = 20;
            this.viewDealBox.Text = "只看已提交请求但未处理";
            this.viewDealBox.UseVisualStyleBackColor = true;
            this.viewDealBox.CheckedChanged += new System.EventHandler(this.viewDealBox_CheckedChanged);
            // 
            // queryTxt
            // 
            this.queryTxt.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.queryTxt.Location = new System.Drawing.Point(421, 39);
            this.queryTxt.Name = "queryTxt";
            this.queryTxt.Size = new System.Drawing.Size(353, 50);
            this.queryTxt.TabIndex = 21;
            // 
            // queryBtn
            // 
            this.queryBtn.Enabled = false;
            this.queryBtn.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.queryBtn.Location = new System.Drawing.Point(809, 39);
            this.queryBtn.Name = "queryBtn";
            this.queryBtn.Size = new System.Drawing.Size(206, 50);
            this.queryBtn.TabIndex = 22;
            this.queryBtn.Text = "查询";
            this.queryBtn.UseVisualStyleBackColor = true;
            this.queryBtn.Click += new System.EventHandler(this.queryBtn_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.Location = new System.Drawing.Point(255, 46);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(148, 37);
            this.label.TabIndex = 23;
            this.label.Text = "用户Id:";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resetBtn.Location = new System.Drawing.Point(809, 102);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(206, 50);
            this.resetBtn.TabIndex = 24;
            this.resetBtn.Text = "重置";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // LossManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 610);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.label);
            this.Controls.Add(this.queryBtn);
            this.Controls.Add(this.queryTxt);
            this.Controls.Add(this.viewDealBox);
            this.Controls.Add(this.dealBtn);
            this.Controls.Add(this.lossSheetView);
            this.Name = "LossManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "挂失管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lossSheetView;
        private System.Windows.Forms.ColumnHeader uid;
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.ColumnHeader bookname;
        private System.Windows.Forms.ColumnHeader lossDate;
        private System.Windows.Forms.ColumnHeader isDeal;
        private System.Windows.Forms.Button dealBtn;
        private System.Windows.Forms.CheckBox viewDealBox;
        private System.Windows.Forms.TextBox queryTxt;
        private System.Windows.Forms.Button queryBtn;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button resetBtn;
    }
}