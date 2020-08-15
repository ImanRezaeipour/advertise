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

namespace Advertise.Web.Views.ProductLike
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ProductLike/LikerListMe.cshtml")]
    public partial class LikerListMe : Advertise.Web.Framework.ViewEngines.Razor.WebViewPage<Advertise.Core.Models.ProductLike.ProductLikeListViewModel>
    {
        public LikerListMe()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 3 "..\..\Views\ProductLike\LikerListMe.cshtml"
  
    Layout = MVC.Shared.Views.SiteLayout.Profile._ProfileLayout;
    ViewBag.Title = Admin.Likers;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"profile-content\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"headline buttons primary\"");

WriteLiteral(">\r\n        <h4>");

            
            #line 9 "..\..\Views\ProductLike\LikerListMe.cshtml"
       Write(Admin.ListMyProductsLikers);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n        <div");

WriteLiteral(" id=\"search\"");

WriteLiteral(" class=\"lists-header searchbar-header-container\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 11 "..\..\Views\ProductLike\LikerListMe.cshtml"
       Write(SearchItem.Term(Model.SearchRequest.Term));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 12 "..\..\Views\ProductLike\LikerListMe.cshtml"
       Write(SearchItem.SortDirection(Model.SortDirectionList, Model.SearchRequest.SortDirection));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 13 "..\..\Views\ProductLike\LikerListMe.cshtml"
       Write(SearchItem.PageSize(Model.PageSizeList, Model.SearchRequest.PageSize));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 14 "..\..\Views\ProductLike\LikerListMe.cshtml"
       Write(SearchItem.GridView());

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"landing-items-wrapper\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"product-list grid\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"landing-column-wrapper\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 21 "..\..\Views\ProductLike\LikerListMe.cshtml"
           Write(Html.Partial(MVC.ProductLike.Views._ListMore, Model.ProductLikes));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"pager\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 27 "..\..\Views\ProductLike\LikerListMe.cshtml"
   Write(Html.Partial(MVC.Shared.Views.SiteLayout._Paging, Model.SearchRequest));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
