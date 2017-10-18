using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BPO.Core;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;

namespace CMS.MVC.Controllers
{
    public class InstallerController : Controller
    {
        private readonly IOptionsSnapshot<AppSettings> _settings;
        public InstallerController(IOptionsSnapshot<AppSettings> settings)
        {
            _settings = settings;
        }
        private string GetSetpTitleString(int step)
        {
            var builder = new StringBuilder();
            for (var i = 1; i <= 5; i++)
            {
                var liClass = string.Empty;
                if (i == step)
                {
                    liClass = @" class=""current""";
                }
                string imageUrl = $"images/step{i}{((i <= step) ? "a" : "b")}.gif";
                var title = string.Empty;
                if (i == 1)
                {
                    title = "许可协议";
                }
                else if (i == 2)
                {
                    title = "环境检测";
                }
                else if (i == 3)
                {
                    title = "数据库设置";
                }
                else if (i == 4)
                {
                    title = "安装产品";
                }
                else if (i == 5)
                {
                    title = "安装完成";
                }
                builder.Append($@"<li{liClass}><img src=""{imageUrl}"" />{title}</li>");
            }
            return builder.ToString();
        }
        public IActionResult Index(int step=1)
        {
            var test=_settings.Value.Test;
             test = _settings.Value.Test;
            switch (step)
            {
                case 2:
                    ViewData["Domain"] =PageUtils.GetHost();
                    ViewData["Version"] = AppManager.GetFullVersion();
                    ViewData["NetVersion"] = $"{Environment.Version.Major}.{Environment.Version.Minor}";
                    ViewData["PhysicalApplicationPath"] = WebConfigUtils.ContentRootPath;
                    var isRootWritable = false;
                    try
                    {
                        var filePath = PathUtils.Combine(WebConfigUtils.ContentRootPath, "robots.txt");
                        FileUtils.WriteText(filePath, ECharset.utf_8, @"User-agent: * Disallow: /SiteServer/ Disallow: /SiteFiles/ Disallow: /home/");
                        isRootWritable = true;
                    }
                    catch
                    {
                        // ignored
                    }
                    var isSiteFilesWritable = false;
                    try
                    {
                        var filePath = PathUtils.Combine(WebConfigUtils.ContentRootPath, DirectoryUtils.SiteFiles.DirectoryName, "index.htm");
                        FileUtils.WriteText(filePath, ECharset.utf_8, StringUtils.Constants.Html5Empty);
                        isSiteFilesWritable = true;
                    }
                    catch
                    {
                        // ignored
                    }

                    ViewData["RootWrite"] = isRootWritable ? "<FONT color=green>[√]</FONT>" : "<FONT color=red>[×]</FONT>";

                    ViewData["SiteFielsWrite"] = isSiteFilesWritable ? "<FONT color=green>[√]</FONT>" : "<FONT color=red>[×]</FONT>";

                    if (!isRootWritable || !isSiteFilesWritable)
                    {
                        ShowErrorMessage("系统检测到文件夹权限不足，您需要赋予可写权限");
                    }
                    break;
                case 4:
                    WebConfigUtils.DatabaseType =Enum.Parse<EDatabaseType>(Request.Form["databaseType"].FirstOrDefault());
                    var host = Request.Form["host"].FirstOrDefault();
                    var uid = Request.Form["uid"].FirstOrDefault();
                    var pwd = Request.Form["pwd"].FirstOrDefault();
                    var databaseName = Request.Form["databaseName"].FirstOrDefault();
                    WebConfigUtils.ConnectionString = $"server={host};uid={uid};pwd={pwd};database={databaseName};";

                    break;
                case 5:
                    var adminName = Request.Form["adminName"].FirstOrDefault();
                    var adminPassword = Request.Form["adminPassword"].FirstOrDefault();
                    WebConfigUtils.IsProtectData = Request.Form["isProtectData"].FirstOrDefault()=="on"?true:false;
                    WebConfigUtils.Update();
                    ViewData["SiteServerUrl"] = PageUtils.GetAdminDirectoryUrl(string.Empty);
                    break;
            }
            ViewData["VersionInfo"] = $"SITESERVER {AppManager.GetFullVersion()}";
            ViewData["Step"] = step;
            ViewData["StepTitle"] = GetSetpTitleString(step);
            return View();
        }

        private void ShowErrorMessage(string errorMessage)
        {
             ViewData["ErrorMessage"] = $@"<img src=""images/check_error.gif"" /> {errorMessage}";
        }
 
    }
}