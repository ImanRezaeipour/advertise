﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Advertise.Web.Views.UserSetting
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Advertise;
    using Advertise.Core.Languages;
    using Advertise.Web;
    using Advertise.Web.Framework.ViewEngines.Razor;
    using Advertise.Web.Views.Shared.SiteLayout;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/UserSetting/_Item.cshtml")]
    public partial class _Item : Advertise.Web.Framework.ViewEngines.Razor.WebViewPage<Advertise.Core.Models.UserSetting.UserSettingViewModel>
    {
        public _Item()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"comment-wrap-each\"");

WriteLiteral(">\r\n    <p>");

            
            #line 4 "..\..\Views\UserSetting\_Item.cshtml"
  Write(Model.Language);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n    <p>");

            
            #line 5 "..\..\Views\UserSetting\_Item.cshtml"
  Write(Model.Theme);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n    <p>");

            
            #line 6 "..\..\Views\UserSetting\_Item.cshtml"
  Write(Model.UserLastName);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n</div>\r\n<hr");

WriteLiteral(" class=\"line-separator\"");

WriteLiteral(">");

        }
    }
}
#pragma warning restore 1591