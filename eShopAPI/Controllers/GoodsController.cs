using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using eShopWeb.BLL;
using eShopWeb.DTO;
using eShopWeb.IBLL;
using eShopWeb.Models;
using static eShopAPI.App_Start.BaseCodeConfig;

namespace eShopAPI.Controllers
{
    [RoutePrefix("Goods")]
    public class GoodsController : ApiController
    {
        [Route("GetGoodsList")]
        public async Task<BaseRequestResponse<List<GoodsDTO>>> GetAsync()
        {
            //TODO 调用业务层获取数据库数据
            //此处直接手动写一些数据返回了
            IGoodsManager goodsManager = new GoodsManager();
            List<GoodsDTO> list =await goodsManager.GetAllGoods();
            BaseRequestResponse<List<GoodsDTO>> response
                = new BaseRequestResponse<List<GoodsDTO>>
                {
                    Code = ResultCode.NormalCode,
                    Result = list,
                    Message = "获取成功"
                };
            return response;
        }

    }
}
