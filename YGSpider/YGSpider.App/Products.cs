using System;
using System.Collections.Generic;
using System.Data.SQLite;
using DevComponents.DotNetBar;
using YGSpider.Business.UtilTools;
using YGSpider.Business.YGInfos;
using YGSpider.DataBase;

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
            //string baseApiUrl = @"http://api.1yyg.com/JPData?action=getHistoryBuyRecord&FIdx=1&EIdx=37163&BTime={0}&ETime={1}&isCount=1&fun={2}&_={3}";
            string baseApiUrl = @"http://api.1yyg.com/JPData?action=getLotteryList&FIdx=1&EIdx=73&SortID=100&IsCount=1&fun={0}&_={1}";
            Int64 timeStamp = SystemHelper.GetTimeStamp();
            Int64 millSeconds = DateTime.Now.Millisecond;
            //string url = string.Format(baseApiUrl, DateTime.Now.AddMinutes(-59).ToString("yyyy-MM-dd HH:mm:ss"), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), timeStamp + "" + millSeconds, SystemHelper.GetTimeStampWithMillisecond());
            string url = string.Format(baseApiUrl, timeStamp + "" + millSeconds, SystemHelper.GetTimeStampWithMillisecond());
            string res = NetHelper.GetByUrl(url);
            rtbResult.Text = res;
            if (!String.IsNullOrEmpty(res))
            {
                res = res.Replace(timeStamp + "" + millSeconds + "(", "");
                res = res.Substring(0, res.Length - 1);
                var data = JsonHelper.JsonToDictionary(res);
                if (data != null)
                {

                }
            }
        }
        public void InitProductData()
        {
            DBHelper.LoadDB("YGSpider.db");
            string sqlStr = "select * from ProductType";
            SQLiteDataReader reader = DBHelper.Query(sqlStr);
            List<ProductType> productList = new List<ProductType>();
            while (reader.Read())
            {
                ProductType product = new ProductType()
                {
                    RowID = reader.GetInt32(0),
                    ProductTypeID = reader.GetInt32(1),
                    ProductTypeName = reader.GetString(2),
                    BaseUrl = reader.GetString(3),
                };
                productList.Add(product);
            }
            this.cmbProductType.DisplayMember = "ProductTypeName";
            this.cmbProductType.ValueMember = "ProductTypeID";
            this.cmbProductType.DataSource = productList;
        }
        private void Products_Load(object sender, EventArgs e)
        {
            InitProductData();
        }
    }
}
