using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using YGSpider.DataBase;
using System.Data.SQLite;
using YGSpider.Business.YGInfos;
using System.Data.SQLite.Linq;
using YGSpider.Business.UtilTools;
using System.Threading;

namespace YGSpider.App
{
    public partial class ProductBuyHistory : Office2007Form
    {
        public ProductBuyHistory()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void ProductBuyHistory_Load(object sender, EventArgs e)
        {
            InitProductData();
        }
        List<MainContext.ProductType> typeList = new List<MainContext.ProductType>();
        public void InitProductData()
        {
            using (MainContext.MainDataContext conn = new MainContext.MainDataContext())
            {
                typeList = conn.ProductTypes.Select(p => p).ToList();
            }
            this.cmbProductType.DataSource = typeList;
            this.cmbProductType.DisplayMember = "ProductTypeName";
            this.cmbProductType.ValueMember = "ProductTypeID";
        }
        List<ProductTypeInfo> productList = new List<ProductTypeInfo>();
        //public void InitProductData()
        //{
        //    DBHelper.LoadDB("YGSpider.db");
        //    string sqlStr = "select * from ProductType";
        //    SQLiteDataReader reader = DBHelper.Query(sqlStr);
        //    productList = new List<ProductTypeInfo>();
        //    while (reader.Read())
        //    {
        //        ProductTypeInfo product = new ProductTypeInfo()
        //        {
        //            RowID = reader.GetInt32(0),
        //            ProductTypeID = reader.GetInt32(1),
        //            ProductTypeName = reader.GetString(2),
        //            BaseUrl = reader.GetString(3),
        //            BaseApiUrl = reader.GetString(4),
        //            RecordCount = reader.GetInt32(5),
        //            PageSize = reader.GetInt32(6),
        //            StartSellTime = reader.GetString(7),
        //            ModefiedTime = reader.GetString(8),
        //            IsDownloadAll = reader.GetInt32(9),
        //        };
        //        productList.Add(product);
        //    }
        //    productList.Insert(0, new ProductTypeInfo());
        //    this.cmbProductType.DisplayMember = "ProductTypeName";
        //    this.cmbProductType.ValueMember = "ProductTypeID";
        //    this.cmbProductType.DataSource = productList.OrderBy(p => p.ProductTypeID).ToList();
        //}
        List<ProductPrizeInfo> prizeInfoList = new List<ProductPrizeInfo>();
        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductTypeInfo productType = productList.FirstOrDefault(p => p.ProductTypeID.ToString() == this.cmbProductType.SelectedValue.ToString());
            if (productType != null)
            {
                prizeInfoList = new List<ProductPrizeInfo>();
                List<string> propertiseName = EntityHelper.getPropertiesNames<ProductPrizeInfo>(new ProductPrizeInfo());
                string sqlStr = "select * from productprizeinfo where producttypeid = " + productType.ProductTypeID;
                DataTable dt = DBHelper.QueryToDataTable(sqlStr);
                foreach (DataRow row in dt.Rows)
                {
                    Dictionary<string, object> valueDict = new Dictionary<string, object>();
                    foreach (string properties in propertiseName)
                    {
                        if (valueDict.Keys.Contains(properties))
                        {
                            valueDict[properties] = row[properties];
                        }
                        else
                        {
                            valueDict.Add(properties, row[properties]);
                        }
                    }
                    ProductPrizeInfo prizeInfo = new ProductPrizeInfo();
                    EntityHelper.setPropertiseValue<ProductPrizeInfo>(valueDict, prizeInfo);
                    prizeInfoList.Add(prizeInfo);
                }
                Dictionary<string, int> dataDict = new Dictionary<string, int>();
                dataDict.Add("", 0);
                foreach (var prizeinfo in prizeInfoList)
                {
                    if (dataDict.Keys.Contains(prizeinfo.goodsName))
                    {
                        dataDict[prizeinfo.goodsName] += 1;
                    }
                    else
                    {
                        dataDict.Add(prizeinfo.goodsName, 1);
                    }
                }
                this.cmbProductList.DataSource = dataDict.ToList();
                this.cmbProductList.DisplayMember = "key";
                this.cmbProductList.ValueMember = "value";
            }
        }
        Thread th;
        private void btnSpideBuyHistory_Click(object sender, EventArgs e)
        {
            th = new Thread(new ThreadStart(SpideBuyHistory));
            th.Start();
        }
        public void SpideBuyHistory()
        {
            string goodsName = this.cmbProductList.Text;
            if (!string.IsNullOrWhiteSpace(goodsName))
            {
                List<ProductPrizeInfo> prizeInfos = prizeInfoList.Where(p => p.goodsName == goodsName).ToList();
                if (prizeInfos != null)
                {
                    foreach (var prizeInfo in prizeInfos)
                    {
                        GetBuyHistory(prizeInfo);
                    }
                    MessageBox.Show(goodsName+"的购买记录采集完成.");
                }
            }
            else
            {
                MessageBox.Show("请选择产品。");
            }
        }
        public void GetBuyHistory(ProductPrizeInfo prizeInfo)
        {
            Int64 timeStamp = SystemHelper.GetTimeStamp();
            Int64 millSeconds = DateTime.Now.Millisecond;
            string baseUrl = @"http://api.1yyg.com/JPData?action=getLotteryRecords&codeId={0}&fun={1}&_={2}";
            string timeStampStr = timeStamp + "" + millSeconds;
            string url = string.Format(baseUrl, prizeInfo.codeID, timeStampStr, SystemHelper.GetTimeStampWithMillisecond());
            string res = NetHelper.GetByUrl(url);
            if (!String.IsNullOrWhiteSpace(res))
            {
                res = res.Replace(timeStamp + "" + millSeconds + "(", "");
                res = res.Substring(0, res.Length - 1);
                var data = JsonHelper.JsonToDictionary(res);
                if (data != null)
                {                    
                }
            }
        }
        private void ProductBuyHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (th != null && th.ThreadState == ThreadState.Running)
            {
                th.Abort();
            }
        }
    }
}
