using System;
using System.Collections.Generic;
using System.Data.SQLite;
using DevComponents.DotNetBar;
using YGSpider.Business.UtilTools;
using YGSpider.Business.YGInfos;
using YGSpider.DataBase;
using System.Linq;
using System.Xml.Linq;
using System.Threading;

namespace YGSpider.App
{
    public partial class Products : Office2007Form
    {
        public Products()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        Thread th;
        private void btnSpide_Click(object sender, EventArgs e)
        {
            th = new Thread(new ThreadStart(SpideData));
            th.Start();
        }
        public void SpideData()
        {

            //foreach (ProductTypeInfo productType in productList)
            //{
            //    if (productType != null)
            //    {
            //        labelX2.Text = "运行结果:" + "正在获取" + productType.ProductTypeName + "的数据。";
            //        AnalysePrizeInfo(productType, productType.RecordCount, 0, productType.PageSize);
            //        string updateStr = "update ProductType set IsDownloadAll="+1+",ModefiedTime='" + DateTime.Now.ToString() + "' where ProductTypeID=" + productType.ProductTypeID;
            //        DBHelper.Update(updateStr);
            //        labelX2.Text = "运行结果:" + "获取" + productType.ProductTypeName + "的数据完成。";
            //    }
            //}
            ProductTypeInfo productType = productList.FirstOrDefault(p => p.ProductTypeID.ToString() == this.cmbProductType.SelectedValue.ToString());
            if (productType != null)
            {
                labelX2.Text = "运行结果:" + "正在获取" + productType.ProductTypeName + "的数据。";
                AnalysePrizeInfo(productType, productType.RecordCount, 0, productType.PageSize);
                string updateStr = "update ProductType set IsDownloadAll=" + 1 + ",ModefiedTime='" + DateTime.Now.ToString() + "' where ProductTypeID=" + productType.ProductTypeID;
                DBHelper.Update(updateStr);
                labelX2.Text = "运行结果:" + "获取" + productType.ProductTypeName + "的数据完成。";
            }
        }
        public int UpdateProductRecordCount(ProductTypeInfo product)
        {
            int span = 0;
            Int64 timeStamp = SystemHelper.GetTimeStamp();
            Int64 millSeconds = DateTime.Now.Millisecond;
            string url = string.Format(product.BaseApiUrl, 0, product.PageSize, product.ProductTypeID, timeStamp + "" + millSeconds, SystemHelper.GetTimeStampWithMillisecond());
            string res = NetHelper.GetByUrl(url);
            if (!String.IsNullOrEmpty(res))
            {
                res = res.Replace(timeStamp + "" + millSeconds + "(", "");
                res = res.Substring(0, res.Length - 1);
                var data = JsonHelper.JsonToDictionary(res);
                if (data != null)
                {
                    ApiDataBaseInfo baseInfo = new ApiDataBaseInfo();
                    EntityHelper.setPropertiseValue<ApiDataBaseInfo>(data, baseInfo);
                    if (product.RecordCount != baseInfo.totalCount)
                    {
                        string updateStr = "update ProductType set RecordCount = " + baseInfo.totalCount + ", ModefiedTime='" + DateTime.Now.ToString() + "' where ProductTypeID=" + product.ProductTypeID;
                        DBHelper.Update(updateStr);
                        span = baseInfo.totalCount - product.RecordCount;
                    }
                }
            }
            return span;
        }
        public void AnalysePrizeInfo(ProductTypeInfo product, int recordCount, int minIndex, int pageSize)
        {
            DateTime startTime = DateTime.Now;
            Int64 timeStamp = SystemHelper.GetTimeStamp();
            Int64 millSeconds = DateTime.Now.Millisecond;
            string timeStampStr = timeStamp + "" + millSeconds;
            List<ProductPrizeInfo> prizeInfoList = new List<ProductPrizeInfo>();
            for (int i = recordCount; i >= minIndex; i -= pageSize)
            {
                int startIndex = i - pageSize >= 0 ? i - pageSize : 0;
                string url = string.Format(product.BaseApiUrl, startIndex, i, product.ProductTypeID, timeStampStr, SystemHelper.GetTimeStampWithMillisecond());
                string res = NetHelper.GetByUrl(url);
                if (!String.IsNullOrEmpty(res))
                {
                    res = res.Replace(timeStamp + "" + millSeconds + "(", "");
                    res = res.Substring(0, res.Length - 1);
                    var data = JsonHelper.JsonToDictionary(res);
                    if (data != null)
                    {
                        ApiDataBaseInfo baseInfo = new ApiDataBaseInfo();
                        EntityHelper.setPropertiseValue<ApiDataBaseInfo>(data, baseInfo);
                        foreach (Dictionary<string, object> dict in baseInfo.listItems)
                        {
                            ProductPrizeInfo prizeInfo = new ProductPrizeInfo();
                            EntityHelper.setPropertiseValue<ProductPrizeInfo>(dict, prizeInfo);
                            if (prizeInfoList.FirstOrDefault(p => p.codeID == prizeInfo.codeID) == null)
                            {
                                prizeInfoList.Add(prizeInfo);
                            }
                        }
                        TimeSpan ts = DateTime.Now - startTime;
                        prizeInfoList = prizeInfoList.OrderBy(p => p.raffTime).Distinct().ToList();
                        rtbResult.Text = "获取" + product.ProductTypeName + " 的购买记录:从" + startIndex + "开始，到" + i + "结束，共计" + prizeInfoList.Count + "条,耗时" + ts.TotalMilliseconds + "毫秒" + Environment.NewLine + rtbResult.Text;
                        InsertPrizeInfoToDB(product, prizeInfoList);
                        prizeInfoList = new List<ProductPrizeInfo>();
                        rtbResult.Text = product.ProductTypeName + " 的购买记录已经存入数据库" + Environment.NewLine + rtbResult.Text;
                        Thread.Sleep(2500);
                        startTime = DateTime.Now;
                    }
                }
            }
        }
        public void InsertPrizeInfoToDB(ProductTypeInfo product, List<ProductPrizeInfo> prizeInfoList)
        {
            using (SQLiteTransaction tran = DBHelper.SQLConn.BeginTransaction())
            {
                foreach (var prize in prizeInfoList)
                {
                    DateTime time = DateTime.Now;
                    SQLiteCommand cmd = new SQLiteCommand(DBHelper.SQLConn);
                    cmd.Transaction = tran;
                    cmd.CommandText = "insert into ProductPrizeInfo values(@RowID,@ProductTypeID,@codeID,@goodsPic,@goodsName,@codePeriod,@codePrice,@raffTime,@userWeb,@userName,@userPhoto,@userAddr,@userRNO,@userBuyNum,@postID,@codeType,@ModefiedTime)";
                    cmd.Parameters.AddRange(new[]{
                    new SQLiteParameter("@RowID",null),
                    new SQLiteParameter("@ProductTypeID",product.ProductTypeID),
                    new SQLiteParameter("@ModefiedTime",time.ToString()+"."+time.Millisecond),
                    });
                    Dictionary<string, object> dictData = EntityHelper.getEntityPropertiesAndValue<ProductPrizeInfo>(prize);
                    foreach (var keyAndValue in dictData)
                    {
                        if (keyAndValue.Key != "RowID")
                        {
                            cmd.Parameters.AddWithValue(keyAndValue.Key, keyAndValue.Value);
                        }
                    }
                    cmd.ExecuteNonQuery();
                }
                tran.Commit();
            }
        }
        List<ProductTypeInfo> productList = new List<ProductTypeInfo>();
        public void InitProductData()
        {
            DBHelper.LoadDB("YGSpider.db");
            string sqlStr = "select * from ProductType";
            SQLiteDataReader reader = DBHelper.Query(sqlStr);
            productList = new List<ProductTypeInfo>();
            while (reader.Read())
            {
                ProductTypeInfo product = new ProductTypeInfo()
                {
                    RowID = reader.GetInt32(0),
                    ProductTypeID = reader.GetInt32(1),
                    ProductTypeName = reader.GetString(2),
                    BaseUrl = reader.GetString(3),
                    BaseApiUrl = reader.GetString(4),
                    RecordCount = reader.GetInt32(5),
                    PageSize = reader.GetInt32(6),
                    StartSellTime = reader.GetString(7),
                    ModefiedTime = reader.GetString(8),
                    IsDownloadAll = reader.GetInt32(9),
                };
                productList.Add(product);
            }
            this.cmbProductType.DisplayMember = "ProductTypeName";
            this.cmbProductType.ValueMember = "ProductTypeID";
            this.cmbProductType.DataSource = productList.OrderBy(p => p.ProductTypeID).ToList();
        }
        private void Products_Load(object sender, EventArgs e)
        {
            InitProductData();
            foreach (ProductTypeInfo productType in productList)
            {
                int span = UpdateProductRecordCount(productType);
                if (span > 0 && productType.IsDownloadAll != 0)
                {
                    AnalysePrizeInfo(productType, span, 0, productType.PageSize);
                }
            }
            InitProductData();
        }
        private void Products_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (th != null && th.ThreadState == ThreadState.Running)
            {
                th.Abort();
            }
        }
    }
}
