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

namespace Advertise.Web.Views.Shared.SiteMapTemplates
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
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/SiteMapTemplates/SiteMapTitleHelperModel.cshtml")]
    public partial class SiteMapTitleHelperModel : Advertise.Web.Framework.ViewEngines.Razor.WebViewPage<SiteMapTitleHelperModel>
    {
        public SiteMapTitleHelperModel()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 3 "..\..\Views\Shared\SiteMapTemplates\SiteMapTitleHelperModel.cshtml"
 if (Model.CurrentNode != null)
{
    
            
            #line default
            #line hidden
            
            #line 5 "..\..\Views\Shared\SiteMapTemplates\SiteMapTitleHelperModel.cshtml"
Write(Model.CurrentNode.Title);

            
            #line default
            #line hidden
            
            #line 5 "..\..\Views\Shared\SiteMapTemplates\SiteMapTitleHelperModel.cshtml"
                            ;
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
