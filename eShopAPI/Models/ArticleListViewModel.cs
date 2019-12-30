using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eShopAPI.Models
{
    /// <summary>
    /// 列表ViewModel数据类
    /// </summary>
    public class ArticleListViewModel
    {
        /// <summary>
        /// 文章ID
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 文章标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 阅读量
        /// </summary>
        public int ReadNums { get; set; }
    }
}