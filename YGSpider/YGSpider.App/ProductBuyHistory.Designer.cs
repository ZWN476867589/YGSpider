namespace YGSpider.App
{
    partial class ProductBuyHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductBuyHistory));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cmbProductType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmbProductList = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.rtbResult = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.btnSpideBuyHistory = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 13);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "商品类别:";
            // 
            // cmbProductType
            // 
            this.cmbProductType.DisplayMember = "Text";
            this.cmbProductType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.ItemHeight = 15;
            this.cmbProductType.Location = new System.Drawing.Point(93, 13);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(137, 21);
            this.cmbProductType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbProductType.TabIndex = 2;
            this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 55);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "商品列表:";
            // 
            // cmbProductList
            // 
            this.cmbProductList.DisplayMember = "Text";
            this.cmbProductList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProductList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductList.FormattingEnabled = true;
            this.cmbProductList.ItemHeight = 15;
            this.cmbProductList.Location = new System.Drawing.Point(93, 55);
            this.cmbProductList.Name = "cmbProductList";
            this.cmbProductList.Size = new System.Drawing.Size(137, 21);
            this.cmbProductList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbProductList.TabIndex = 4;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 102);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(333, 23);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "运行结果:";
            // 
            // rtbResult
            // 
            this.rtbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.rtbResult.BackgroundStyle.Class = "RichTextBoxBorder";
            this.rtbResult.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rtbResult.Location = new System.Drawing.Point(12, 131);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(521, 488);
            this.rtbResult.TabIndex = 6;
            // 
            // btnSpideBuyHistory
            // 
            this.btnSpideBuyHistory.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSpideBuyHistory.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSpideBuyHistory.Location = new System.Drawing.Point(285, 55);
            this.btnSpideBuyHistory.Name = "btnSpideBuyHistory";
            this.btnSpideBuyHistory.Size = new System.Drawing.Size(124, 23);
            this.btnSpideBuyHistory.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSpideBuyHistory.TabIndex = 8;
            this.btnSpideBuyHistory.Text = "开始采集购买记录";
            this.btnSpideBuyHistory.Click += new System.EventHandler(this.btnSpideBuyHistory_Click);
            // 
            // ProductBuyHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 616);
            this.Controls.Add(this.btnSpideBuyHistory);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.cmbProductList);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cmbProductType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductBuyHistory";
            this.Text = "商品购买记录";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductBuyHistory_FormClosing);
            this.Load += new System.EventHandler(this.ProductBuyHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbProductType;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbProductList;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx rtbResult;
        private DevComponents.DotNetBar.ButtonX btnSpideBuyHistory;

    }
}