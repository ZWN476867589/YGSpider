using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace YGSpider.App
{
    public partial class MainForm : Office2007Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Products product = new Products();
            product.TopLevel = false;
            product.Parent = tcpProducts;
            product.ControlBox = false;
            product.Dock = DockStyle.Fill;
            product.Height = tcpProducts.Height;
            product.Text = "";
            product.Show();

            BuyHistory buyHistory = new BuyHistory();
            buyHistory.TopLevel = false;
            buyHistory.Parent = tcpBuyHistory;
            buyHistory.ControlBox = false;
            buyHistory.Dock = DockStyle.Fill;
            buyHistory.Height = tcpProducts.Height;
            buyHistory.Text = "";
            buyHistory.Show();

            this.tabControl1.SelectedTabIndex = 0;
        }
    }
}
