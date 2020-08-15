﻿using Advertise.Service.Managers.File;

#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Advertise.Web.Views.Shared.SiteLayout.Profile
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
    
    #line 3 "..\..\Views\Shared\SiteLayout\Profile\_ProfileHeader.cshtml"
    using Advertise.Core.Extensions;
    
    #line default
    #line hidden
    using Advertise.Core.Languages;
    
    #line 4 "..\..\Views\Shared\SiteLayout\Profile\_ProfileHeader.cshtml"
#line default
    #line hidden
    using Advertise.Web;
    using Advertise.Web.Framework.ViewEngines.Razor;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/SiteLayout/Profile/_ProfileHeader.cshtml")]
    public partial class _ProfileHeader : Advertise.Web.Framework.ViewEngines.Razor.WebViewPage<Advertise.Core.Models.User.UserHeaderViewModel>
    {
        public _ProfileHeader()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"sidebar-item author-bio\"");

WriteLiteral(">\r\n");

            
            #line 6 "..\..\Views\Shared\SiteLayout\Profile\_ProfileHeader.cshtml"
    
            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\Shared\SiteLayout\Profile\_ProfileHeader.cshtml"
     if (Model.AvatarFileName != null)
    {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"product-detail company-logo\"");

WriteLiteral(">\r\n                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 381), Tuple.Create("\"", 442)
            
            #line 10 "..\..\Views\Shared\SiteLayout\Profile\_ProfileHeader.cshtml"
, Tuple.Create(Tuple.Create("", 387), Tuple.Create<System.Object, System.Int32>(FileConst.ImagesWebPath.PlusWord(Model.AvatarFileName)
            
            #line default
            #line hidden
, 387), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 443), Tuple.Create("\"", 488)
, Tuple.Create(Tuple.Create("", 449), Tuple.Create("User", 449), true)
, Tuple.Create(Tuple.Create(" ", 453), Tuple.Create("Avatar", 454), true)
, Tuple.Create(Tuple.Create(" ", 460), Tuple.Create("Image", 461), true)
            
            #line 10 "..\..\Views\Shared\SiteLayout\Profile\_ProfileHeader.cshtml"
                          , Tuple.Create(Tuple.Create(" ", 466), Tuple.Create<System.Object, System.Int32>(Model.AvatarFileName
            
            #line default
            #line hidden
, 467), false)
);

WriteLiteral(">\r\n            </div>\r\n        </a>\r\n");

            
            #line 13 "..\..\Views\Shared\SiteLayout\Profile\_ProfileHeader.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"product-detail company-logo\"");

WriteLiteral(">\r\n            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 617), Tuple.Create("\"", 645)
            
            #line 17 "..\..\Views\Shared\SiteLayout\Profile\_ProfileHeader.cshtml"
, Tuple.Create(Tuple.Create("", 623), Tuple.Create<System.Object, System.Int32>(FileConst.NoAvatarPth
            
            #line default
            #line hidden
, 623), false)
);

WriteLiteral(" alt=\"user without avatar image\"");

WriteLiteral(">\r\n        </div>\r\n");

            
            #line 19 "..\..\Views\Shared\SiteLayout\Profile\_ProfileHeader.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(">\r\n        <p");

WriteLiteral(" class=\"text-header\"");

WriteLiteral(">");

            
            #line 21 "..\..\Views\Shared\SiteLayout\Profile\_ProfileHeader.cshtml"
                          Write(Model.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n    </a>\r\n    <p");

WriteLiteral(" class=\"text-oneline\"");

WriteLiteral(">");

            
            #line 23 "..\..\Views\Shared\SiteLayout\Profile\_ProfileHeader.cshtml"
                       Write(Model.Email);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n    <h6><br></h6>\r\n");

            
            #line 25 "..\..\Views\Shared\SiteLayout\Profile\_ProfileHeader.cshtml"
    
            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\Shared\SiteLayout\Profile\_ProfileHeader.cshtml"
     if (Model.CompanyTitle != null)
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteLiteral(" class=\"text-oneline\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 28 "..\..\Views\Shared\SiteLayout\Profile\_ProfileHeader.cshtml"
       Write(Admin.Company.PlusWord(": "));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1005), Tuple.Create("\"", 1063)
            
            #line 29 "..\..\Views\Shared\SiteLayout\Profile\_ProfileHeader.cshtml"
, Tuple.Create(Tuple.Create("", 1012), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Company.Detail(Model.CompanyAlias))
            
            #line default
            #line hidden
, 1012), false)
);

WriteLiteral(" class=\"user-meta-company-title\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"primary\"");

WriteLiteral(">");

            
            #line 30 "..\..\Views\Shared\SiteLayout\Profile\_ProfileHeader.cshtml"
                                          Write(Model.CompanyTitle);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            </a>\r\n        </p>\r\n");

            
            #line 33 "..\..\Views\Shared\SiteLayout\Profile\_ProfileHeader.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591
