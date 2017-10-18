using System;
using System.Collections.Generic;
using System.Text;

namespace BPO.Core
{
    public class CookieUtils
    {
        private CookieUtils()
        {
        }

        public static void SetCookie(string name, string value, DateTime expires)
        {
            var cookieOptions = new Microsoft.AspNetCore.Http.CookieOptions();
            cookieOptions.Expires = expires;
            cookieOptions.HttpOnly = true;
            value = TranslateUtils.Encrypt(value);
            //防止通过js获取到cookie
            if (HttpContext.Current.Request.Scheme.Equals("https"))
            {
                cookieOptions.Secure = true;//通过https传递cookie
            }
            HttpContext.Current.Response.Cookies.Append(name, value, cookieOptions);
        }

        public static void SetCookie(string key,string value)
        {
            value = TranslateUtils.Encrypt(value);
            var cookieOptions= new Microsoft.AspNetCore.Http.CookieOptions();
            cookieOptions.HttpOnly = true;//防止通过js获取到cookie
            if (HttpContext.Current.Request.Scheme.Equals("https"))
            {
                cookieOptions.Secure = true;//通过https传递cookie
            }
            HttpContext.Current.Response.Cookies.Append(key, value, cookieOptions);
        }

        public static string GetCookie(string name)
        {
            if (HttpContext.Current.Request.Cookies[name] == null) return string.Empty;

            var value = HttpContext.Current.Request.Cookies[name];
            return TranslateUtils.Decrypt(value);
        }

        public static bool IsExists(string name)
        {
            return HttpContext.Current.Request.Cookies[name] != null;
        }

        //public static void Erase(string name)
        //{
        //    var cookie = HttpContext.Current.Response.Cookies;
        //    if (cookie != null)
        //    {
        //        cookie.Expires = DateTime.Now.AddDays(-1);
        //        cookie.Values.Clear();
        //    }
        //}
    }
}
