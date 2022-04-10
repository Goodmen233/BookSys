namespace booksys
{
    partial class BookInfoForm
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
            this.bid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.leftnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label = new System.Windows.Forms.Label();
            this.queryTxt = new System.Windows.Forms.TextBox();
            this.queryBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookView
            // 
            this.bookView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bid,
            this.bookname,
            this.author,
            this.leftnum,
            this.price,
            this.bType});
            this.bookView.FullRowSelect = true;
            this.bookView.GridLines = true;
            this.bookView.HideSelection = false;
            this.bookView.Location = new System.Drawing.Point(59, 364);
            this.bookView.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bookView.Name = "bookView";
            this.bookView.Size = new System.Drawing.Size(1255, 421);
            this.bookView.TabIndex = 18;
            this.bookView.UseCompatibleStateImageBehavior = false;
            this.bookView.View = System.Windows.Forms.View.Details;
            // 
            // bid
            // 
            this.bid.Text = "图书Id";
            this.bid.Width = 90;
            // 
            // bookname
            // 
            this.bookname.Text = "书名";
            this.bookname.Width = 90;
            // 
            // author
            // 
            this.author.Text = "作者";
            this.author.Width = 90;
            // 
            // leftnum
            // 
            this.leftnum.Text = "剩余数量";
            this.leftnum.Width = 90;
            // 
            // price
            // 
            this.price.Text = "价格";
            this.price.Width = 90;
            // 
            // bType
            // 
            this.bType.Text = "类型";
            this.bType.Width = 90;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.Location = new System.Drawing.Point(124, 82);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(186, 42);
            this.label.TabIndex = 25;
            this.label.Text = "图书Id：";
            // 
            // queryTxt
            // 
            this.queryTxt.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.queryTxt.Location = new System.Drawing.Point(336, 79);
            this.queryTxt.Name = "queryTxt";
            this.queryTxt.Size = new System.Drawing.Size(411, 55);
            this.queryTxt.TabIndex = 26;
            // 
            // queryBtn
            // 
            this.queryBtn.Enabled = false;
            this.queryBtn.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.queryBtn.Location = new System.Drawing.Point(791, 82);
            this.queryBtn.Name = "queryBtn";
            this.queryBtn.Size = new System.Drawing.Size(240, 56);
            this.queryBtn.TabIndex = 27;
            this.queryBtn.Text = "查询";
            this.queryBtn.UseVisualStyleBackColor = true;
            this.queryBtn.Click += new System.EventHandler(this.queryBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resetBtn.Location = new System.Drawing.Point(791, 180);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(240, 56);
            this.resetBtn.TabIndex = 28;
            this.resetBtn.Text = "重置";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(59, 279);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(208, 78);
            this.refreshBtn.TabIndex = 29;
            this.refreshBtn.Text = "刷新";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Enabled = false;
            this.editBtn.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.editBtn.Location = new System.Drawing.Point(1057, 159);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(258, 78);
            this.editBtn.TabIndex = 30;
            this.editBtn.Text = "修改";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Enabled = false;
            this.delBtn.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delBtn.Location = new System.Drawing.Point(1057, 279);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(258, 78);
            this.delBtn.TabIndex = 31;
            this.delBtn.Text = "删除";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addBtn.Location = new System.Drawing.Point(1057, 46);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(258, 78);
            this.addBtn.TabIndex = 32;
            this.addBtn.Text = "增加";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // BookInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1370, 801);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.queryBtn);
            this.Controls.Add(this.queryTxt);
            this.Controls.Add(this.label);
            this.Controls.Add(this.bookView);
            this.Name = "BookInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书管理";
            this.Load += new System.EventHandler(this.BookInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView bookView;
        private System.Windows.Forms.ColumnHeader bid;
        private System.Windows.Forms.ColumnHeader bookname;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader leftnum;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader bType;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox queryTxt;
        private System.Windows.Forms.Button queryBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button addBtn;
    }
}