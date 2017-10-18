using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace BPO.WebMVC.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            //ViewBag.Title = Configs.GetValue(ConfigKeys.SoftName);
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
 
    }
}