using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace FurSystemTest.Application.Utils
{
    public static class UtilHelper
    {
        /// <summary>
        /// 获取 URL 参数
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static Dictionary<string, string> GetQueryParams(string query)
        {
            var queryParams = new Dictionary<string, string>();
            if (string.IsNullOrEmpty(query)) return queryParams;
            var pairs = query.TrimStart('?').Split('&');
            foreach (var pair in pairs)
            {
                var keyValue = pair.Split('=');
                if (keyValue.Length == 2)
                {
                    queryParams[Uri.UnescapeDataString(keyValue[0])] = Uri.UnescapeDataString(keyValue[1]);
                }
            }
            return queryParams;
        }

        /// <summary>
        /// 获取 Cookie
        /// </summary>
        /// <param name="httpContext"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetCookie(HttpContext httpContext, string name)
        {
            return httpContext.Request.Cookies[name];
        }

        /// <summary>
        /// 设置 Cookie
        /// </summary>
        /// <param name="httpContext"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="seconds"></param>
        /// <param name="path"></param>
        public static void SetCookie(HttpContext httpContext, string name, string value, int seconds, string path = "/")
        {
            var cookieOptions = new CookieOptions
            {
                Expires = DateTimeOffset.UtcNow.AddSeconds(seconds),
                Path = path
            };
            httpContext.Response.Cookies.Append(name, value, cookieOptions);
        }

        /// <summary>
        /// 清除 Cookie
        /// </summary>
        /// <param name="httpContext"></param>
        /// <param name="name"></param>
        /// <param name="path"></param>
        public static void ClearCookie(HttpContext httpContext, string name, string path = "/")
        {
            var cookieOptions = new CookieOptions
            {
                Expires = DateTimeOffset.UtcNow.AddSeconds(-1),
                Path = path
            };
            httpContext.Response.Cookies.Append(name, "", cookieOptions);
        }
    }
}