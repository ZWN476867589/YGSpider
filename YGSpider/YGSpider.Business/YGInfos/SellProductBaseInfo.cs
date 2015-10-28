using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace YGSpider.Business.YGInfos
{
    /// <summary>
    /// 已经售出商品的类
    /// </summary>
    public class SellProductBaseInfo
    {
        public int code { get; set; }
        public int totalCount { get; set; }
        public ArrayList listItems { get; set; }
        public List<ProductPrizeInfo> prizeInfos { get; set; }
    }
}
