using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YGSpider.Business.YGInfos
{
    public class ProductPrizeInfo
    {
        public Int64 RowID { get; set; }
        public Int64 ProductTypeID { get; set; }
        public Int64 codeID { get; set; }
        public string goodsPic { get; set; }
        public string goodsName { get; set; }
        public Int64 codePeriod { get; set; }
        public string codePrice { get; set; }
        public string raffTime { get; set; }
        public string userWeb { get; set; }
        public string userName { get; set; }
        public string userPhoto { get; set; }
        public string userAddr { get; set; }
        public string userRNO { get; set; }
        public string userBuyNum { get; set; }
        public string postID { get; set; }
        public Int64 codeType { get; set; }
        public string ModefiedTime { get; set; }
        public Int64 IsDownloadAllBuyRecord { get; set; }
    }
}
