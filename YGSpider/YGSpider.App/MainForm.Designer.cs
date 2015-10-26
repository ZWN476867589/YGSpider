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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.SystemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.功能FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuyHistoryMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemMenu,
            this.功能FToolStripMenuItem,
            this.AboutMenu});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(859, 25);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "menuStrip1";
            // 
            // SystemMenu
            // 
            this.SystemMenu.Checked = true;
            this.SystemMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SystemMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit});
            this.SystemMenu.Name = "SystemMenu";
            this.SystemMenu.Size = new System.Drawing.Size(59, 21);
            this.SystemMenu.Text = "系统(&S)";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(116, 22);
            this.Exit.Text = "退出(&X)";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // 功能FToolStripMenuItem
            // 
            this.功能FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductMenu,
            this.BuyHistoryMenu});
            this.功能FToolStripMenuItem.Name = "功能FToolStripMenuItem";
            this.功能FToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.功能FToolStripMenuItem.Text = "功能(&F)";
            // 
            // ProductMenu
            // 
            this.ProductMenu.Name = "ProductMenu";
            this.ProductMenu.Size = new System.Drawing.Size(152, 22);
            this.ProductMenu.Text = "商品(&P)";
            this.ProductMenu.Click += new System.EventHandler(this.ProductMenu_Click);
            // 
            // BuyHistoryMenu
            // 
            this.BuyHistoryMenu.Name = "BuyHistoryMenu";
            this.BuyHistoryMenu.Size = new System.Drawing.Size(152, 22);
            this.BuyHistoryMenu.Text = "购买历史(&B)";
            this.BuyHistoryMenu.Click += new System.EventHandler(this.BuyHistoryMenu_Click);
            // 
            // AboutMenu
            // 
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(60, 21);
            this.AboutMenu.Text = "关于(&A)";
            this.AboutMenu.Click += new System.EventHandler(this.AboutMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 475);
            this.Controls.Add(this.Menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menu;
            this.Name = "MainForm";
            this.Text = "云购采集器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem SystemMenu;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem 功能FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductMenu;
        private System.Windows.Forms.ToolStripMenuItem BuyHistoryMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutMenu;

    }
}