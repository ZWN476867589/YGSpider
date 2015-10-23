using System;
using DevComponents.DotNetBar;
using YGSpider.Business;
using YGSpider.Business.UtilTools;
using mshtml;
using System.Windows.Forms;


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
            //string baseUrl = @"http://www.1yyg.com/lottery/i100m1.html";            
            //webBrowser1.Navigate(baseUrl);     
            //string baseApiUrl = @"http://api.1yyg.com/JPData?action=getHistoryBuyRecord&FIdx=1&EIdx=20&BTime={0}&ETime={1}&isCount=1&fun=jsonp{2}&_={3}";
            //string url = string.Format(baseApiUrl, DateTime.Now.AddMinutes(-59).ToString("yyyy-MM-dd HH:mm:ss"), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), SystemHelper.GetTimeStampWithMillisecond(), SystemHelper.GetTimeStampWithMillisecond());
            //string res = NetHelper.GetByUrl(url);
            //rtbResult.Text = res;
            Int64 userID = 1000000001;

        }               
        private void Products_Load(object sender, EventArgs e)
        {
            Init();
        }
        public void Init()
        {
        }

        private void btnCopyData_Click(object sender, EventArgs e)
        {            
        }
    }
}
