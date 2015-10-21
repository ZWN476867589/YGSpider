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
    public partial class Products : Office2007Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void btnSpide_Click(object sender, EventArgs e)
        {
            string baseUrl = @"http://www.1yyg.com/lottery/i100.html";
        }

        private void Products_Load(object sender, EventArgs e)
        {
            Init();
        }
        public void Init()
        {
        }
    }
}
