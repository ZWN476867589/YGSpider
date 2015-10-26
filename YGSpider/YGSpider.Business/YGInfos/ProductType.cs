using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YGSpider.Business.YGInfos
{
    public class ProductType
    {
        public int RowID { get; set; }
        public int ProductTypeID { get; set; }
        public string ProductTypeName { get; set; }
        public string BaseUrl { get; set; }
        public int PageCount { get; set; }
    }
}
