using eShopAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static eShopAPI.App_Start.BaseCodeConfig;

namespace eShopAPI.Controllers
{
    [RoutePrefix("Article")]
    public class ListController : ApiController
    {
        /// <summary>
        /// 获取文章列表
        /// </summary>
        /// <returns></returns>
        [Route("GetArticleList")]
        public BaseRequestResponse<List<ArticleListViewModel>> Get()
        {
            //TODO 调用业务层获取数据库数据
            //此处直接手动写一些数据返回了
            List<ArticleListViewModel> list = new List<ArticleListViewModel> {
            new ArticleListViewModel {
                Id=1,
                Title="文章标题111111111111",
                ReadNums=2979
            },
            new ArticleListViewModel {
                Id=2,
                Title="文章标题2222222222222",
                ReadNums=8888
            },
            new ArticleListViewModel {
                Id=3,
                Title="文章标题33333333333333",
                ReadNums=1791
            }
        };
            BaseRequestResponse<List<ArticleListViewModel>> response
              = new BaseRequestResponse<List<ArticleListViewModel>>
              {
                  Code = ResultCode.NormalCode,
                  Result = list,
                  Message = "获取成功"
              };
            return response;
        }
    }
}
