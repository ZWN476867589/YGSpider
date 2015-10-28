using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YGSpider.Business.YGInfos
{
    public class ProductTypeInfo
    {
        public int RowID { get; set; }
        public int ProductTypeID { get; set; }
        public string ProductTypeName { get; set; }
        public string BaseUrl { get; set; }
        public string BaseApiUrl { get; set; }
        public int RecordCount { get; set; }
        public int PageSize { get; set; }
        public string StartSellTime { get; set; }
        public string ModefiedTime { get; set; }
        public int IsDownloadAll { get; set; }
    }
}
