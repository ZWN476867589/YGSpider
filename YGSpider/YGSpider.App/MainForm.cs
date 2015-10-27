using System;
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
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void ProductMenu_Click(object sender, EventArgs e)
        {
            CloseForms();
            Products product = new Products();
            product.MdiParent = this;
            product.Show();
        }     

        private void AboutMenu_Click(object sender, EventArgs e)
        {
            CloseForms();
            About about = new About();
            about.MdiParent = this;
            about.WindowState = FormWindowState.Maximized;
            about.Show();
        }

        private void BuyHistoryMenu_Click(object sender, EventArgs e)
        {
            CloseForms();
            BuyHistory history = new BuyHistory();
            history.MdiParent = this;
            history.Show();
        }
        public void CloseForms()
        {
            //foreach (Form form in this.MdiChildren)
            //{
            //    form.Close();
            //    form.Dispose();
            //}
        }
    }
}
