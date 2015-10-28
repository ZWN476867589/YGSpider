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

namespace YGSpider.App
{
    public partial class ProductBuyHistory : Office2007Form
    {
        public ProductBuyHistory()
        {
            InitializeComponent();
        }
        private void ProductBuyHistory_Load(object sender, EventArgs e)
        {
            InitProductData();
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
            productList.Insert(0, new ProductTypeInfo());
            this.cmbProductType.DisplayMember = "ProductTypeName";
            this.cmbProductType.ValueMember = "ProductTypeID";
            this.cmbProductType.DataSource = productList.OrderBy(p => p.ProductTypeID).ToList();
        }
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
                var m = prizeInfoList.GroupBy(p=>p.goodsName);
                foreach (var i in m)
                {

                }
            }
        }
    }
}
