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

namespace Advertise.Web.Views.Shared.SiteLayout
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
    
    #line 2 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
    using Advertise.Core.Extensions;
    
    #line default
    #line hidden
    using Advertise.Core.Languages;
    
    #line 3 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
    using Advertise.Service.Services.Categories;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
#line default
    #line hidden
    using Advertise.Web;
    using Advertise.Web.Framework.ViewEngines.Razor;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/SiteLayout/_SideMenuLeft.cshtml")]
    public partial class _SideMenuLeft : Advertise.Web.Framework.ViewEngines.Razor.WebViewPage<Advertise.Core.Models.Home.MainMenuViewModel>
    {
        public _SideMenuLeft()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" id=\"mobile-menu\"");

WriteLiteral(" class=\"side-menu left closed\"");

WriteLiteral(">\r\n    <svg");

WriteLiteral(" class=\"svg-plus\"");

WriteLiteral(">\r\n        <use");

WriteLiteral(" xlink:href=\"#svg-plus\"");

WriteLiteral("></use>\r\n    </svg>\r\n    <div");

WriteLiteral(" class=\"side-menu-header\"");

WriteLiteral(">\r\n        <figure");

WriteLiteral(" class=\"logo small smaller\"");

WriteLiteral(">\r\n            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 460), Tuple.Create("\"", 489)
            
            #line 12 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
, Tuple.Create(Tuple.Create("", 466), Tuple.Create<System.Object, System.Int32>(FileConst.LogoSmallPth
            
            #line default
            #line hidden
, 466), false)
);

WriteLiteral(" alt=\"logo\"");

WriteLiteral(">\r\n        </figure>\r\n    </div>\r\n    <p");

WriteLiteral(" class=\"side-menu-title\"");

WriteLiteral(">");

            
            #line 15 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
                          Write(Admin.MainLinks);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n<ul");

WriteLiteral(" class=\"dropdown dark hover-effect interactive\"");

WriteLiteral(">\r\n    <li");

WriteLiteral(" class=\"dropdown-item\"");

WriteLiteral(">\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 683), Tuple.Create("\"", 719)
            
            #line 18 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
, Tuple.Create(Tuple.Create("", 690), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Page.About())
            
            #line default
            #line hidden
, 690), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-info-circle\"");

WriteLiteral("></i> ");

            
            #line 18 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
                                                                             Write(Admin.AboutUs);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    </li>\r\n    <li");

WriteLiteral(" class=\"dropdown-item\"");

WriteLiteral(">\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 828), Tuple.Create("\"", 864)
            
            #line 21 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
, Tuple.Create(Tuple.Create("", 835), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Page.Costs())
            
            #line default
            #line hidden
, 835), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-user-circle-o\"");

WriteLiteral("></i> ");

            
            #line 21 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
                                                                               Write(Admin.GetAdminPanel);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    </li>\r\n    <li");

WriteLiteral(" class=\"dropdown-item\"");

WriteLiteral(">\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 981), Tuple.Create("\"", 1018)
            
            #line 24 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
, Tuple.Create(Tuple.Create("", 988), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Page.Policy())
            
            #line default
            #line hidden
, 988), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-legal fa-flip-horizontal\"");

WriteLiteral("></i> ");

            
            #line 24 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
                                                                                           Write(Admin.RulesAndRegulations);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    </li>\r\n    <li");

WriteLiteral(" class=\"dropdown-item\"");

WriteLiteral(">\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1152), Tuple.Create("\"", 1192)
            
            #line 27 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
, Tuple.Create(Tuple.Create("", 1159), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Page.ContactUs())
            
            #line default
            #line hidden
, 1159), false)
);

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-phone fa-flip-horizontal\"");

WriteLiteral("></i> ");

            
            #line 27 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
                                                                                              Write(Admin.ContactUs);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    </li>\r\n    <li");

WriteLiteral(" class=\"mobile-menus-deactive\"");

WriteLiteral(">\r\n        <i");

WriteLiteral(" class=\"fa fa-circle\"");

WriteLiteral("></i>\r\n        <span>");

            
            #line 31 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
         Write(Admin.Categories);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n    </li>\r\n");

            
            #line 33 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
    
            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
     foreach (var categoryL1 in Model.Categories.GetSubLevelOneByAlias("Category-All"))
    {

            
            #line default
            #line hidden
WriteLiteral("    <li");

WriteAttribute("class", Tuple.Create(" class=\"", 1506), Tuple.Create("\"", 1587)
, Tuple.Create(Tuple.Create("", 1514), Tuple.Create("dropdown-item", 1514), true)
, Tuple.Create(Tuple.Create(" ", 1527), Tuple.Create<System.Object, System.Int32>(new System.Web.WebPages.HelperResult(__razor_attribute_value_writer => {

            
            #line 35 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
                              if (categoryL1.HasChild == true){
            
            #line default
            #line hidden
WriteLiteralTo(__razor_attribute_value_writer, "interactive");

            
            #line 35 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
                                                                                       }
            
            #line default
            #line hidden
}), 1528), false)
);

WriteLiteral(">\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1601), Tuple.Create("\"", 1759)
, Tuple.Create(Tuple.Create("", 1608), Tuple.Create<System.Object, System.Int32>(new System.Web.WebPages.HelperResult(__razor_attribute_value_writer => {

            
            #line 36 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
                  if (categoryL1.HasChild == true) {
            
            #line default
            #line hidden
WriteLiteralTo(__razor_attribute_value_writer, "#");

            
            #line 36 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
                                                                  } else {
            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
                                         WriteTo(__razor_attribute_value_writer, Url.Action(MVC.Category.Detail(categoryL1.Alias)).AddSlug(categoryL1.MetaTitle));

            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
                                                                                                                                                                       }
            
            #line default
            #line hidden
}), 1608), false)
);

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 37 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
       Write(categoryL1.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 38 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
            
            
            #line default
            #line hidden
            
            #line 38 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
             if (categoryL1.HasChild == true)
            {

            
            #line default
            #line hidden
WriteLiteral("                <svg");

WriteLiteral(" class=\"svg-arrow\"");

WriteLiteral(">\r\n                    <use");

WriteLiteral(" xlink:href=\"#svg-arrow\"");

WriteLiteral("></use>\r\n                </svg>\r\n");

            
            #line 43 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </a>\r\n");

            
            #line 45 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
        
            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
         if (categoryL1.HasChild == true)
        {

            
            #line default
            #line hidden
WriteLiteral("            <ul");

WriteLiteral(" class=\"inner-dropdown\"");

WriteLiteral(">\r\n");

            
            #line 48 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
                
            
            #line default
            #line hidden
            
            #line 48 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
                 foreach (var categoryL2 in Model.Categories.GetSubLevelOneByAlias(categoryL1.Alias))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <li");

WriteLiteral(" class=\"inner-dropdown-item dropdown-title\"");

WriteLiteral(">\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2319), Tuple.Create("\"", 2406)
            
            #line 51 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
, Tuple.Create(Tuple.Create("", 2326), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Category.Detail(categoryL2.Alias)).AddSlug(categoryL2.MetaTitle)
            
            #line default
            #line hidden
, 2326), false)
);

WriteLiteral(">");

            
            #line 51 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
                                                                                                              Write(categoryL2.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                    </li>\r\n");

            
            #line 53 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
                    if (categoryL2.HasChild == true)
                    {
                        foreach (var categoryL3 in Model.Categories.GetSubLevelOneByAlias(categoryL2.Alias))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li");

WriteLiteral(" class=\"inner-dropdown-item\"");

WriteLiteral(">\r\n                                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2768), Tuple.Create("\"", 2855)
            
            #line 58 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
, Tuple.Create(Tuple.Create("", 2775), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Category.Detail(categoryL3.Alias)).AddSlug(categoryL3.MetaTitle)
            
            #line default
            #line hidden
, 2775), false)
);

WriteLiteral(">");

            
            #line 58 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
                                                                                                                      Write(categoryL3.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                            </li>\r\n");

            
            #line 60 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
                        }
                    }
                }

            
            #line default
            #line hidden
WriteLiteral("            </ul>\r\n");

            
            #line 64 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </li>\r\n");

            
            #line 66 "..\..\Views\Shared\SiteLayout\_SideMenuLeft.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</ul>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
