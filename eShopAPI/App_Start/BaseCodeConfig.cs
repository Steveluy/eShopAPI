using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eShopWeb.DTO;

namespace eShopAPI.App_Start
{
    public class BaseCodeConfig
    {
        /// <summary>
        /// 默认请求返回对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class BaseRequestResponse<T>
        {
            public int Code { get; set; } = ResultCode.NormalCode;
            public string Message { get; set; }
            public T Result { get; set; }

            public static implicit operator BaseRequestResponse<T>(BaseRequestResponse<List<GoodsDTO>> v)
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// 更新、删除、新增反馈状态类
        /// </summary>
        public class BaseUpdateResponse
        {
            /// <summary>
            /// 响应状态
            /// </summary>
            public int Code { get; set; } = ResultCode.NormalCode;
            /// <summary>
            /// 受影响行数
            /// </summary>
            public int Count { get; set; }
            /// <summary>
            /// 返回消息
            /// </summary>
            public string Message { get; set; }
        }

        public class ResultCode
        {
            /// <summary>
            /// 正常code
            /// </summary>
            public const int NormalCode = 0;
            /// <summary>
            /// 未传入片键或片键非法
            /// </summary>
            public const int NeedsKeyParameter = 10001;
            /// <summary>
            /// 相关数据已经存在
            /// </summary>
            public const int IsExistsValue = 10002;
            /// <summary>
            /// 相关数据不存在
            /// </summary>
            public const int NotExistsValue = 10003;
            /// <summary>
            /// 暂不支持此操作
            /// </summary>
            public const int NotSupported = 10004;
        }
    }
}