﻿// ------------------------------------------------------------------------------
// Copyright  吴来伟个人 版权所有。 
// 项目名：WorkData.Web
// 文件名：HomeController.cs
// 创建标识：吴来伟 2018-05-28 16:49
// 创建描述：
//  
// 修改标识：吴来伟2018-06-26 16:12
// 修改描述：
//  ------------------------------------------------------------------------------

#region

using Microsoft.AspNetCore.Mvc;
using WorkData.Code.JwtSecurityTokens;
using WorkData.Dependency;

#endregion

namespace WorkData.Web
{
    public class HomeController : Controller
    {
        public WorkDataBaseJwt WorkDataBaseJwt { get; set; } =
            IocManager.Instance.ResolveServiceValue<WorkDataBaseJwt>();


        public IActionResult Index()
        {
            return View();
        }
    }
}