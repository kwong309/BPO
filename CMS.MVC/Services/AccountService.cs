using BPO.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.MVC.Services
{
    public class AccountService
    {
        public async Task<AjaxResult> Validate(string userName, string password)
        {
            AjaxResult ajaxResult = new AjaxResult();
 
            if (string.IsNullOrEmpty(userName))
            {
                ajaxResult.state = ResultType.error;
                ajaxResult.message = "账号不能为空";
                return ajaxResult;
            }
            if (string.IsNullOrEmpty(password))
            {
                ajaxResult.state = ResultType.error;
                ajaxResult.message = "密码不能为空";
                return ajaxResult;
            }
            throw new Exception();
        }
    }
}
