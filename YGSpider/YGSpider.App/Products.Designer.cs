namespace YGSpider.App
{
    partial class Products
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
            this.cmbProductType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnSpide = new DevComponents.DotNetBar.ButtonX();
            this.rtbResult = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // cmbProductType
            // 
            this.cmbProductType.DisplayMember = "Text";
            this.cmbProductType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.ItemHeight = 15;
            this.cmbProductType.Location = new System.Drawing.Point(93, 11);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(137, 21);
            this.cmbProductType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbProductType.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 11);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "商品类别:";
            // 
            // btnSpide
            // 
            this.btnSpide.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSpide.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSpide.Location = new System.Drawing.Point(269, 11);
            this.btnSpide.Name = "btnSpide";
            this.btnSpide.Size = new System.Drawing.Size(75, 23);
            this.btnSpide.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSpide.TabIndex = 2;
            this.btnSpide.Text = "开始采集";
            this.btnSpide.Click += new System.EventHandler(this.btnSpide_Click);
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
            this.rtbResult.Location = new System.Drawing.Point(12, 65);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(455, 470);
            this.rtbResult.TabIndex = 3;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(11, 40);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(333, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "运行结果:";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(476, 547);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.btnSpide);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cmbProductType);
            this.Name = "Products";
            this.Text = "商品";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Products_FormClosing);
            this.Load += new System.EventHandler(this.Products_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbProductType;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnSpide;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx rtbResult;
        private DevComponents.DotNetBar.LabelX labelX2;

    }
}