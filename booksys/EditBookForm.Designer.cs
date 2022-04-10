namespace booksys
{
    partial class EditBookForm
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
            this.bookIdLbl = new System.Windows.Forms.Label();
            this.booknameLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.leftnumLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.bTypeLbl = new System.Windows.Forms.Label();
            this.bidTxt = new System.Windows.Forms.TextBox();
            this.booknameTxt = new System.Windows.Forms.TextBox();
            this.authorTxt = new System.Windows.Forms.TextBox();
            this.leftnumTxt = new System.Windows.Forms.TextBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.bTypeTxt = new System.Windows.Forms.TextBox();
            this.wrongIdLbl = new System.Windows.Forms.Label();
            this.wrongAuthorLbl = new System.Windows.Forms.Label();
            this.wrongLeftnumLbl = new System.Windows.Forms.Label();
            this.wrongPriceLbl = new System.Windows.Forms.Label();
            this.sureBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bookIdLbl
            // 
            this.bookIdLbl.AutoSize = true;
            this.bookIdLbl.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bookIdLbl.Location = new System.Drawing.Point(59, 51);
            this.bookIdLbl.Name = "bookIdLbl";
            this.bookIdLbl.Size = new System.Drawing.Size(166, 37);
            this.bookIdLbl.TabIndex = 0;
            this.bookIdLbl.Text = "图书Id：";
            // 
            // booknameLbl
            // 
            this.booknameLbl.AutoSize = true;
            this.booknameLbl.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.booknameLbl.Location = new System.Drawing.Point(60, 160);
            this.booknameLbl.Name = "booknameLbl";
            this.booknameLbl.Size = new System.Drawing.Size(165, 37);
            this.booknameLbl.TabIndex = 1;
            this.booknameLbl.Text = "图书名：";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.authorLbl.Location = new System.Drawing.Point(96, 265);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(128, 37);
            this.authorLbl.TabIndex = 2;
            this.authorLbl.Text = "作者：";
            // 
            // leftnumLbl
            // 
            this.leftnumLbl.AutoSize = true;
            this.leftnumLbl.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.leftnumLbl.Location = new System.Drawing.Point(22, 392);
            this.leftnumLbl.Name = "leftnumLbl";
            this.leftnumLbl.Size = new System.Drawing.Size(202, 37);
            this.leftnumLbl.TabIndex = 3;
            this.leftnumLbl.Text = "剩余数量：";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.priceLbl.Location = new System.Drawing.Point(96, 494);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(128, 37);
            this.priceLbl.TabIndex = 4;
            this.priceLbl.Text = "价格：";
            // 
            // bTypeLbl
            // 
            this.bTypeLbl.AutoSize = true;
            this.bTypeLbl.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bTypeLbl.Location = new System.Drawing.Point(96, 602);
            this.bTypeLbl.Name = "bTypeLbl";
            this.bTypeLbl.Size = new System.Drawing.Size(128, 37);
            this.bTypeLbl.TabIndex = 5;
            this.bTypeLbl.Text = "类型：";
            // 
            // bidTxt
            // 
            this.bidTxt.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bidTxt.Location = new System.Drawing.Point(230, 48);
            this.bidTxt.Name = "bidTxt";
            this.bidTxt.Size = new System.Drawing.Size(340, 50);
            this.bidTxt.TabIndex = 6;
            this.bidTxt.Leave += new System.EventHandler(this.bidTxt_Leave);
            // 
            // booknameTxt
            // 
            this.booknameTxt.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.booknameTxt.Location = new System.Drawing.Point(230, 157);
            this.booknameTxt.Name = "booknameTxt";
            this.booknameTxt.Size = new System.Drawing.Size(340, 50);
            this.booknameTxt.TabIndex = 7;
            this.booknameTxt.Leave += new System.EventHandler(this.booknameTxt_Leave);
            // 
            // authorTxt
            // 
            this.authorTxt.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.authorTxt.Location = new System.Drawing.Point(230, 262);
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.Size = new System.Drawing.Size(340, 50);
            this.authorTxt.TabIndex = 8;
            this.authorTxt.Leave += new System.EventHandler(this.authorTxt_Leave);
            // 
            // leftnumTxt
            // 
            this.leftnumTxt.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.leftnumTxt.Location = new System.Drawing.Point(230, 389);
            this.leftnumTxt.Name = "leftnumTxt";
            this.leftnumTxt.Size = new System.Drawing.Size(340, 50);
            this.leftnumTxt.TabIndex = 9;
            this.leftnumTxt.Leave += new System.EventHandler(this.leftnumTxt_Leave);
            // 
            // priceTxt
            // 
            this.priceTxt.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.priceTxt.Location = new System.Drawing.Point(230, 491);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(340, 50);
            this.priceTxt.TabIndex = 10;
            this.priceTxt.Leave += new System.EventHandler(this.priceTxt_Leave);
            // 
            // bTypeTxt
            // 
            this.bTypeTxt.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bTypeTxt.Location = new System.Drawing.Point(230, 599);
            this.bTypeTxt.Name = "bTypeTxt";
            this.bTypeTxt.Size = new System.Drawing.Size(340, 50);
            this.bTypeTxt.TabIndex = 11;
            this.bTypeTxt.Leave += new System.EventHandler(this.bTypeTxt_Leave);
            // 
            // wrongIdLbl
            // 
            this.wrongIdLbl.AutoSize = true;
            this.wrongIdLbl.BackColor = System.Drawing.Color.Transparent;
            this.wrongIdLbl.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wrongIdLbl.ForeColor = System.Drawing.Color.Red;
            this.wrongIdLbl.Location = new System.Drawing.Point(223, 117);
            this.wrongIdLbl.Name = "wrongIdLbl";
            this.wrongIdLbl.Size = new System.Drawing.Size(240, 37);
            this.wrongIdLbl.TabIndex = 12;
            this.wrongIdLbl.Text = "图书Id已存在";
            this.wrongIdLbl.Visible = false;
            // 
            // wrongAuthorLbl
            // 
            this.wrongAuthorLbl.AutoSize = true;
            this.wrongAuthorLbl.BackColor = System.Drawing.Color.Transparent;
            this.wrongAuthorLbl.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wrongAuthorLbl.ForeColor = System.Drawing.Color.Red;
            this.wrongAuthorLbl.Location = new System.Drawing.Point(223, 337);
            this.wrongAuthorLbl.Name = "wrongAuthorLbl";
            this.wrongAuthorLbl.Size = new System.Drawing.Size(276, 37);
            this.wrongAuthorLbl.TabIndex = 13;
            this.wrongAuthorLbl.Text = "作者姓名不合法";
            this.wrongAuthorLbl.Visible = false;
            // 
            // wrongLeftnumLbl
            // 
            this.wrongLeftnumLbl.AutoSize = true;
            this.wrongLeftnumLbl.BackColor = System.Drawing.Color.Transparent;
            this.wrongLeftnumLbl.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wrongLeftnumLbl.ForeColor = System.Drawing.Color.Red;
            this.wrongLeftnumLbl.Location = new System.Drawing.Point(223, 451);
            this.wrongLeftnumLbl.Name = "wrongLeftnumLbl";
            this.wrongLeftnumLbl.Size = new System.Drawing.Size(276, 37);
            this.wrongLeftnumLbl.TabIndex = 14;
            this.wrongLeftnumLbl.Text = "数量设置不合法";
            this.wrongLeftnumLbl.Visible = false;
            // 
            // wrongPriceLbl
            // 
            this.wrongPriceLbl.AutoSize = true;
            this.wrongPriceLbl.BackColor = System.Drawing.Color.Transparent;
            this.wrongPriceLbl.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wrongPriceLbl.ForeColor = System.Drawing.Color.Red;
            this.wrongPriceLbl.Location = new System.Drawing.Point(223, 559);
            this.wrongPriceLbl.Name = "wrongPriceLbl";
            this.wrongPriceLbl.Size = new System.Drawing.Size(276, 37);
            this.wrongPriceLbl.TabIndex = 15;
            this.wrongPriceLbl.Text = "价格设置不合法";
            this.wrongPriceLbl.Visible = false;
            // 
            // sureBtn
            // 
            this.sureBtn.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sureBtn.Location = new System.Drawing.Point(401, 712);
            this.sureBtn.Name = "sureBtn";
            this.sureBtn.Size = new System.Drawing.Size(169, 77);
            this.sureBtn.TabIndex = 16;
            this.sureBtn.Text = "确定";
            this.sureBtn.UseVisualStyleBackColor = true;
            this.sureBtn.Click += new System.EventHandler(this.sureBtn_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 893);
            this.Controls.Add(this.sureBtn);
            this.Controls.Add(this.wrongPriceLbl);
            this.Controls.Add(this.wrongLeftnumLbl);
            this.Controls.Add(this.wrongAuthorLbl);
            this.Controls.Add(this.wrongIdLbl);
            this.Controls.Add(this.bTypeTxt);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.leftnumTxt);
            this.Controls.Add(this.authorTxt);
            this.Controls.Add(this.booknameTxt);
            this.Controls.Add(this.bidTxt);
            this.Controls.Add(this.bTypeLbl);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.leftnumLbl);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.booknameLbl);
            this.Controls.Add(this.bookIdLbl);
            this.Name = "EditBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EditBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookIdLbl;
        private System.Windows.Forms.Label booknameLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.Label leftnumLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label bTypeLbl;
        private System.Windows.Forms.TextBox bidTxt;
        private System.Windows.Forms.TextBox booknameTxt;
        private System.Windows.Forms.TextBox authorTxt;
        private System.Windows.Forms.TextBox leftnumTxt;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.TextBox bTypeTxt;
        private System.Windows.Forms.Label wrongIdLbl;
        private System.Windows.Forms.Label wrongAuthorLbl;
        private System.Windows.Forms.Label wrongLeftnumLbl;
        private System.Windows.Forms.Label wrongPriceLbl;
        private System.Windows.Forms.Button sureBtn;
        private System.Windows.Forms.Timer timer;
    }
}