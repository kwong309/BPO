using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using CMS.MVC.Services;
using BPO.Core;
using CMS.MVC.ViewModel;
using CMS.MVC.Data;
using System.Collections.Concurrent;

namespace CMS.MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly CMSDB _DBContext;
        public readonly static List<int> HashCodeList=new List<int>();
        public static readonly ConcurrentDictionary<int, CMSDB> CMSDBs = new ConcurrentDictionary<int, CMSDB>();

        public AccountController(CMSDB dbContext)
        {
            _DBContext = dbContext;
            int code= _DBContext.GetHashCode();
            HashCodeList.Add(code);
            CMSDBs.TryAdd(code, dbContext);
        }
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetAuthCode([FromServices]VierificationCodeService _vierificationCodeServices)
        {
            string code = "";
            System.IO.MemoryStream ms = _vierificationCodeServices.Create(out code);
            HttpContext.Session.SetString("LoginValidateCode", code);
            Response.Body.Dispose();
            return File(ms.ToArray(), @"image/png");
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<AjaxResult> Login(LoginViewModel model,[FromServices]CMSDB dbContext)
        {
            var result = new AjaxResult();
            try
            {
                result.state = ResultType.error;
                if (string.IsNullOrEmpty(model.UserName))
                {
                    result.message = "账号不能为空";
                    return result;
                }
                if (string.IsNullOrEmpty(model.Password))
                {
                    result.message = "密码不能为空";
                    return result;
                }
                string code = HttpContext.Session.GetString("LoginValidateCode");
                if (!model.Code.Equals(code, StringComparison.OrdinalIgnoreCase))
                {
                    result.message =  "验证码不正确，请重新输入！" ;
                    return result;
                }
                if (StringUtils.IsMobile(model.UserName))
                {

                }
                return result;
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                if (ex.InnerException != null)
                {
                    message += ex.InnerException.Message;
                }
                result = new AjaxResult { state =  ResultType.error, message = ex.Message };
            }
            return result;
        }
    }
}