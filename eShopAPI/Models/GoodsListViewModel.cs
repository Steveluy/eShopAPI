using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eShopAPI.Models
{
    public class GoodsListViewModel
    {
        /// <summary>
        /// 商品的ID
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 商品的名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 商品的缩略图url
        /// </summary>
        public string ImgsUrl { get; set; }

        /// <summary>
        /// 商品的当前售价
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// 商品的原价
        /// </summary>
        public double Price_old { get; set; }
    }
}