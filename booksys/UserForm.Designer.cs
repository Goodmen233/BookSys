namespace booksys
{
    partial class UserForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ViewStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllBookStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowedBookStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.sortBTypeStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.sortPriceStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.sortPriceAscStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.sortPriceDescStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.sortAuthorStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.helpStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.editStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.loginStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.refreshStrip = new System.Windows.Forms.ToolStripButton();
            this.DateLbl = new System.Windows.Forms.ToolStripLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.booknameLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.bTypeLbl = new System.Windows.Forms.Label();
            this.booknameTxt = new System.Windows.Forms.TextBox();
            this.minPriceTxt = new System.Windows.Forms.TextBox();
            this.authorTxt = new System.Windows.Forms.TextBox();
            this.bTypeTxt = new System.Windows.Forms.TextBox();
            this.maxPriceTxt = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.borrowBookBtn = new System.Windows.Forms.Button();
            this.exactQueryBtn = new System.Windows.Forms.Button();
            this.vagueQueryBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.bookView = new System.Windows.Forms.ListView();
            this.bid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.leftnum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewStrip,
            this.helpStrip,
            this.editStrip,
            this.loginStrip,
            this.logoutStrip});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1311, 43);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ViewStrip
            // 
            this.ViewStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllBookStrip,
            this.borrowedBookStrip,
            this.sortBTypeStrip,
            this.sortPriceStrip,
            this.sortAuthorStrip});
            this.ViewStrip.Name = "ViewStrip";
            this.ViewStrip.Size = new System.Drawing.Size(81, 39);
            this.ViewStrip.Text = "查看";
            // 
            // viewAllBookStrip
            // 
            this.viewAllBookStrip.Name = "viewAllBookStrip";
            this.viewAllBookStrip.Size = new System.Drawing.Size(255, 42);
            this.viewAllBookStrip.Text = "所有书籍";
            this.viewAllBookStrip.Click += new System.EventHandler(this.viewAllBookStrip_Click);
            // 
            // borrowedBookStrip
            // 
            this.borrowedBookStrip.Name = "borrowedBookStrip";
            this.borrowedBookStrip.Size = new System.Drawing.Size(255, 42);
            this.borrowedBookStrip.Text = "已借书籍";
            this.borrowedBookStrip.Click += new System.EventHandler(this.borrowedBookStrip_Click);
            // 
            // sortBTypeStrip
            // 
            this.sortBTypeStrip.Name = "sortBTypeStrip";
            this.sortBTypeStrip.Size = new System.Drawing.Size(255, 42);
            this.sortBTypeStrip.Text = "按类型排序";
            this.sortBTypeStrip.Click += new System.EventHandler(this.sortBTypeStrip_Click);
            // 
            // sortPriceStrip
            // 
            this.sortPriceStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortPriceAscStrip,
            this.sortPriceDescStrip});
            this.sortPriceStrip.Name = "sortPriceStrip";
            this.sortPriceStrip.Size = new System.Drawing.Size(255, 42);
            this.sortPriceStrip.Text = "按价格排序";
            // 
            // sortPriceAscStrip
            // 
            this.sortPriceAscStrip.Name = "sortPriceAscStrip";
            this.sortPriceAscStrip.Size = new System.Drawing.Size(174, 42);
            this.sortPriceAscStrip.Text = "升序";
            this.sortPriceAscStrip.Click += new System.EventHandler(this.sortPriceAscStrip_Click);
            // 
            // sortPriceDescStrip
            // 
            this.sortPriceDescStrip.Name = "sortPriceDescStrip";
            this.sortPriceDescStrip.Size = new System.Drawing.Size(174, 42);
            this.sortPriceDescStrip.Text = "降序";
            this.sortPriceDescStrip.Click += new System.EventHandler(this.sortPriceDescStrip_Click);
            // 
            // sortAuthorStrip
            // 
            this.sortAuthorStrip.Name = "sortAuthorStrip";
            this.sortAuthorStrip.Size = new System.Drawing.Size(255, 42);
            this.sortAuthorStrip.Text = "按作者排序";
            this.sortAuthorStrip.Click += new System.EventHandler(this.sortAuthorStrip_Click);
            // 
            // helpStrip
            // 
            this.helpStrip.Name = "helpStrip";
            this.helpStrip.Size = new System.Drawing.Size(81, 39);
            this.helpStrip.Text = "帮助";
            this.helpStrip.Click += new System.EventHandler(this.helpStrip_Click);
            // 
            // editStrip
            // 
            this.editStrip.Name = "editStrip";
            this.editStrip.Size = new System.Drawing.Size(135, 39);
            this.editStrip.Text = "修改信息";
            this.editStrip.Click += new System.EventHandler(this.editStrip_Click);
            // 
            // loginStrip
            // 
            this.loginStrip.Name = "loginStrip";
            this.loginStrip.Size = new System.Drawing.Size(81, 39);
            this.loginStrip.Text = "登录";
            this.loginStrip.Click += new System.EventHandler(this.loginStrip_Click);
            // 
            // logoutStrip
            // 
            this.logoutStrip.Name = "logoutStrip";
            this.logoutStrip.Size = new System.Drawing.Size(81, 39);
            this.logoutStrip.Text = "注销";
            this.logoutStrip.Click += new System.EventHandler(this.logoutStrip_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshStrip,
            this.DateLbl});
            this.toolStrip.Location = new System.Drawing.Point(0, 43);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip.Size = new System.Drawing.Size(1311, 35);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // refreshStrip
            // 
            this.refreshStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshStrip.Image = global::booksys.Properties.Resources.刷新;
            this.refreshStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshStrip.Name = "refreshStrip";
            this.refreshStrip.Size = new System.Drawing.Size(32, 32);
            this.refreshStrip.Text = "刷新";
            this.refreshStrip.Click += new System.EventHandler(this.refreshStrip_Click);
            // 
            // DateLbl
            // 
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(0, 32);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // booknameLbl
            // 
            this.booknameLbl.AutoSize = true;
            this.booknameLbl.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.booknameLbl.Location = new System.Drawing.Point(77, 148);
            this.booknameLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.booknameLbl.Name = "booknameLbl";
            this.booknameLbl.Size = new System.Drawing.Size(127, 43);
            this.booknameLbl.TabIndex = 2;
            this.booknameLbl.Text = "书名:";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.priceLbl.Location = new System.Drawing.Point(77, 288);
            this.priceLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(127, 43);
            this.priceLbl.TabIndex = 3;
            this.priceLbl.Text = "价格:";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.authorLbl.Location = new System.Drawing.Point(569, 148);
            this.authorLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(127, 43);
            this.authorLbl.TabIndex = 4;
            this.authorLbl.Text = "作者:";
            // 
            // bTypeLbl
            // 
            this.bTypeLbl.AutoSize = true;
            this.bTypeLbl.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bTypeLbl.Location = new System.Drawing.Point(569, 288);
            this.bTypeLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.bTypeLbl.Name = "bTypeLbl";
            this.bTypeLbl.Size = new System.Drawing.Size(127, 43);
            this.bTypeLbl.TabIndex = 5;
            this.bTypeLbl.Text = "类型:";
            // 
            // booknameTxt
            // 
            this.booknameTxt.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.booknameTxt.Location = new System.Drawing.Point(212, 144);
            this.booknameTxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.booknameTxt.Name = "booknameTxt";
            this.booknameTxt.Size = new System.Drawing.Size(324, 56);
            this.booknameTxt.TabIndex = 6;
            // 
            // minPriceTxt
            // 
            this.minPriceTxt.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.minPriceTxt.Location = new System.Drawing.Point(212, 284);
            this.minPriceTxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.minPriceTxt.Name = "minPriceTxt";
            this.minPriceTxt.Size = new System.Drawing.Size(104, 56);
            this.minPriceTxt.TabIndex = 7;
            // 
            // authorTxt
            // 
            this.authorTxt.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.authorTxt.Location = new System.Drawing.Point(705, 144);
            this.authorTxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.Size = new System.Drawing.Size(324, 56);
            this.authorTxt.TabIndex = 8;
            // 
            // bTypeTxt
            // 
            this.bTypeTxt.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bTypeTxt.Location = new System.Drawing.Point(705, 281);
            this.bTypeTxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bTypeTxt.Name = "bTypeTxt";
            this.bTypeTxt.Size = new System.Drawing.Size(324, 56);
            this.bTypeTxt.TabIndex = 9;
            // 
            // maxPriceTxt
            // 
            this.maxPriceTxt.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maxPriceTxt.Location = new System.Drawing.Point(434, 284);
            this.maxPriceTxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.maxPriceTxt.Name = "maxPriceTxt";
            this.maxPriceTxt.Size = new System.Drawing.Size(104, 56);
            this.maxPriceTxt.TabIndex = 10;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.Location = new System.Drawing.Point(359, 288);
            this.label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(41, 43);
            this.label.TabIndex = 11;
            this.label.Text = "-";
            // 
            // borrowBookBtn
            // 
            this.borrowBookBtn.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.borrowBookBtn.Location = new System.Drawing.Point(322, 418);
            this.borrowBookBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.borrowBookBtn.Name = "borrowBookBtn";
            this.borrowBookBtn.Size = new System.Drawing.Size(163, 61);
            this.borrowBookBtn.TabIndex = 12;
            this.borrowBookBtn.Text = "借书";
            this.borrowBookBtn.UseVisualStyleBackColor = true;
            this.borrowBookBtn.Click += new System.EventHandler(this.borrowBookBtn_Click);
            // 
            // exactQueryBtn
            // 
            this.exactQueryBtn.Enabled = false;
            this.exactQueryBtn.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exactQueryBtn.Location = new System.Drawing.Point(551, 418);
            this.exactQueryBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.exactQueryBtn.Name = "exactQueryBtn";
            this.exactQueryBtn.Size = new System.Drawing.Size(222, 61);
            this.exactQueryBtn.TabIndex = 14;
            this.exactQueryBtn.Text = "精确查询";
            this.exactQueryBtn.UseVisualStyleBackColor = true;
            this.exactQueryBtn.Click += new System.EventHandler(this.exactQueryBtn_Click);
            // 
            // vagueQueryBtn
            // 
            this.vagueQueryBtn.Enabled = false;
            this.vagueQueryBtn.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vagueQueryBtn.Location = new System.Drawing.Point(807, 418);
            this.vagueQueryBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.vagueQueryBtn.Name = "vagueQueryBtn";
            this.vagueQueryBtn.Size = new System.Drawing.Size(222, 61);
            this.vagueQueryBtn.TabIndex = 15;
            this.vagueQueryBtn.Text = "模糊查询";
            this.vagueQueryBtn.UseVisualStyleBackColor = true;
            this.vagueQueryBtn.Click += new System.EventHandler(this.vagueQueryBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resetBtn.Location = new System.Drawing.Point(1062, 418);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(163, 61);
            this.resetBtn.TabIndex = 16;
            this.resetBtn.Text = "重置";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
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
            this.bookView.Location = new System.Drawing.Point(26, 488);
            this.bookView.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bookView.Name = "bookView";
            this.bookView.Size = new System.Drawing.Size(1255, 630);
            this.bookView.TabIndex = 17;
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
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1311, 1148);
            this.Controls.Add(this.bookView);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.vagueQueryBtn);
            this.Controls.Add(this.exactQueryBtn);
            this.Controls.Add(this.borrowBookBtn);
            this.Controls.Add(this.label);
            this.Controls.Add(this.maxPriceTxt);
            this.Controls.Add(this.bTypeTxt);
            this.Controls.Add(this.authorTxt);
            this.Controls.Add(this.minPriceTxt);
            this.Controls.Add(this.booknameTxt);
            this.Controls.Add(this.bTypeLbl);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.booknameLbl);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ViewStrip;
        private System.Windows.Forms.ToolStripMenuItem borrowedBookStrip;
        private System.Windows.Forms.ToolStripMenuItem sortBTypeStrip;
        private System.Windows.Forms.ToolStripMenuItem sortPriceStrip;
        private System.Windows.Forms.ToolStripMenuItem sortPriceAscStrip;
        private System.Windows.Forms.ToolStripMenuItem sortPriceDescStrip;
        private System.Windows.Forms.ToolStripMenuItem sortAuthorStrip;
        private System.Windows.Forms.ToolStripMenuItem helpStrip;
        private System.Windows.Forms.ToolStripMenuItem editStrip;
        private System.Windows.Forms.ToolStripMenuItem logoutStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton refreshStrip;
        private System.Windows.Forms.ToolStripLabel DateLbl;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label booknameLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.Label bTypeLbl;
        private System.Windows.Forms.TextBox booknameTxt;
        private System.Windows.Forms.TextBox minPriceTxt;
        private System.Windows.Forms.TextBox authorTxt;
        private System.Windows.Forms.TextBox bTypeTxt;
        private System.Windows.Forms.TextBox maxPriceTxt;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button borrowBookBtn;
        private System.Windows.Forms.Button exactQueryBtn;
        private System.Windows.Forms.Button vagueQueryBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.ListView bookView;
        private System.Windows.Forms.ColumnHeader bid;
        private System.Windows.Forms.ColumnHeader bookname;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader leftnum;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader bType;
        private System.Windows.Forms.ToolStripMenuItem loginStrip;
        private System.Windows.Forms.ToolStripMenuItem viewAllBookStrip;
    }
}