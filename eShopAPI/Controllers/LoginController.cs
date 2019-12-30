using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using eShopAPI.Models;
using eShopAPI.Tools;

namespace eShopAPI.Controllers
{
    [RoutePrefix("login")]
    public class LoginController : ApiController
    {
        [HttpPost]
        [Route("in")]
        public string GetLoin(UserViewModel model)
        {
            if (model.Name.Count() > 2 && model.Password == "123456")
            {
                return JwtTools.Encode(new Dictionary<string, object>()
                {
                    { "Name",model.Name}
                }, JwtTools.JwtKeys);

            }
            throw new Exception("您输入的用户名密码有误");
        }

        [HttpGet]
        [Route("GetInfo")]
        public string GetLoginInfo()
        {
            return JwtTools.IsValieLogin(ControllerContext.Request.Headers);
        }
    }
}
