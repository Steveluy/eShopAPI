using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using eShopAPI.App_Start;
using eShopWeb.BLL;
using eShopWeb.DAL;
using eShopWeb.IBLL;
using eShopWeb.IDAL;
using eShopWeb.Models;
using static eShopAPI.App_Start.BaseCodeConfig;

namespace eShopAPI.Controllers
{
    [RoutePrefix("DeliveryAddress")]
    public class DeliveryAddressController : ApiController
    {
        [HttpPost]
        [Route("AddDeliveryAddress")]
        public BaseUpdateResponse Add(DeliveryAddress model)
        {
            //TODO 调用业务层获取数据库数据
            //此处直接手动写一些数据返回了
            IDeliveryAddressManager deliveryAddress = new DeliveryAddressManager();
            deliveryAddress.AddDeliveryAddress(model);
            BaseUpdateResponse response = new BaseUpdateResponse()
            {
                Code = 0,
                Count = 1,
                Message = "添加成功"
            };
            return response;
        }

        [HttpGet]
        [Route("GetDeliveryAddress")]
        public BaseRequestResponse<List<DeliveryAddress>> Get(Guid userGuid)
        {
            //TODO 调用业务层获取数据库数据
            //此处直接手动写一些数据返回了
            IDeliveryAddressService deliveryAddressService = new DeliveryAddressService();
            List<DeliveryAddress> list = deliveryAddressService.GetAllAsync().Where(m=>m.UserGuid==userGuid).ToList();
            BaseRequestResponse<List<DeliveryAddress>> response
                = new BaseRequestResponse<List<DeliveryAddress>>
                {
                    Code = ResultCode.NormalCode,
                    Result = list,
                    Message = "获取成功"
                };
            return response;
        }

        [HttpGet]
        [Route("DelDeliveryAddress")]
        public BaseUpdateResponse Del(Guid id)
        {
            //TODO 调用业务层获取数据库数据
            //此处直接手动写一些数据返回了
            IDeliveryAddressService deliveryAddressService = new DeliveryAddressService();
            deliveryAddressService.RemoveAsync(id);
            BaseUpdateResponse response = new BaseUpdateResponse()
            {
                Code = 0,
                Count = 1,
                Message = "删除成功"
            };
            return response;
        }
    }
}
