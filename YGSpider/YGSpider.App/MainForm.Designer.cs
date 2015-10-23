namespace YGSpider.App
{
    partial class MainForm
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
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tcpBuyHistory = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tcpProducts = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tcpBuyHistory);
            this.tabControl1.Controls.Add(this.tcpProducts);
            this.tabControl1.Location = new System.Drawing.Point(-7, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(872, 478);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem2);
            // 
            // tcpBuyHistory
            // 
            this.tcpBuyHistory.AutoSize = true;
            this.tcpBuyHistory.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.tcpBuyHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcpBuyHistory.Location = new System.Drawing.Point(0, 26);
            this.tcpBuyHistory.Name = "tcpBuyHistory";
            this.tcpBuyHistory.Padding = new System.Windows.Forms.Padding(1);
            this.tcpBuyHistory.Size = new System.Drawing.Size(872, 452);
            this.tcpBuyHistory.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tcpBuyHistory.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tcpBuyHistory.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tcpBuyHistory.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tcpBuyHistory.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tcpBuyHistory.Style.GradientAngle = 90;
            this.tcpBuyHistory.TabIndex = 2;
            this.tcpBuyHistory.TabItem = this.tabItem2;
            // 
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tcpBuyHistory;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "购买记录";
            // 
            // tcpProducts
            // 
            this.tcpProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcpProducts.AutoSize = true;
            this.tcpProducts.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.tcpProducts.Location = new System.Drawing.Point(0, 26);
            this.tcpProducts.Name = "tcpProducts";
            this.tcpProducts.Padding = new System.Windows.Forms.Padding(1);
            this.tcpProducts.Size = new System.Drawing.Size(872, 452);
            this.tcpProducts.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tcpProducts.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tcpProducts.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tcpProducts.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tcpProducts.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tcpProducts.Style.GradientAngle = 90;
            this.tcpProducts.TabIndex = 1;
            this.tcpProducts.TabItem = this.tabItem1;
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tcpProducts;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "商品";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 475);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "云购采集器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tcpProducts;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.TabControlPanel tcpBuyHistory;
        private DevComponents.DotNetBar.TabItem tabItem2;
    }
}