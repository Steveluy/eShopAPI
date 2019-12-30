using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using System.Net.Http.Headers;

namespace eShopAPI.Tools
{
    public class JwtTools
    {
        public static string JwtKeys = "sdfasdfasdfwefvsdf";

        /// <summary>
        /// JWT加密
        /// </summary>
        /// <param name="payload">需要加密的键值对</param>
        /// <param name="key">唯一密匙（不能泄露）</param>
        /// <returns></returns>
        public static string Encode(Dictionary<string, object> payload, string key)
        {
            IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
            IJsonSerializer serializer = new JsonNetSerializer();
            IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
            IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
            return encoder.Encode(payload, key);
        }
        /// <summary>
        /// JWT加密
        /// </summary>
        /// <param name="token">解密获取到的token字符串</param>
        /// <param name="key">唯一密匙（不能泄露）</param>
        /// <returns></returns>
        public static string Decode(string token, string key)
        {
            try
            {
                IJsonSerializer serializer = new JsonNetSerializer();
                IDateTimeProvider provider = new UtcDateTimeProvider();
                IJwtValidator validator = new JwtValidator(serializer, provider);
                IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
                IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder);
                return decoder.Decode(token, key, true);
            }
            catch (TokenExpiredException)
            {
                Console.WriteLine("Token Has expired");
                throw;
            }
            catch (SignatureVerificationException)
            {
                Console.WriteLine("Token has invalid signature");
                throw;
            }
        }

        public static string IsValieLogin(HttpRequestHeaders headers)
        {
            if (headers.GetValues("token") == null || !headers.GetValues("token").Any())
                throw new Exception("请登录");

            return Decode(headers.GetValues("token").First(), JwtKeys);
        }
    }
}