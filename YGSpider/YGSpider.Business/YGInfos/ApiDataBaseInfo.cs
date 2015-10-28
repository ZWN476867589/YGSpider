using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace YGSpider.Business.YGInfos
{
    public class ApiDataBaseInfo
    {
        public int code { get; set; }
        public int totalCount { get; set; }
        public ArrayList listItems { get; set; }
        public List<ProductPrizeInfo> prizeInfos { get; set; }
    }    
}
