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

namespace Advertise.Web.Views.ProductComment
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ProductComment/_Create.cshtml")]
    public partial class _Create : Advertise.Web.Framework.ViewEngines.Razor.WebViewPage<dynamic>
    {
        public _Create()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 2 "..\..\Views\ProductComment\_Create.cshtml"
  
    Layout = null;

            
            #line default
            #line hidden
WriteLiteral("\r\n<h3>");

            
            #line 5 "..\..\Views\ProductComment\_Create.cshtml"
Write(Admin.AddComment);

            
            #line default
            #line hidden
WriteLiteral("...</h3>\r\n<div");

WriteLiteral(" class=\"comment-wrap comment-reply\"");

WriteLiteral(">\r\n    <textarea");

WriteLiteral(" id=\"commentBody\"");

WriteLiteral(" name=\"commentBody\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 201), Tuple.Create("\"", 233)
            
            #line 7 "..\..\Views\ProductComment\_Create.cshtml"
, Tuple.Create(Tuple.Create("", 215), Tuple.Create<System.Object, System.Int32>(Admin.CommentText
            
            #line default
            #line hidden
, 215), false)
);

WriteLiteral(" class=\"tooltipster\"");

WriteAttribute("title", Tuple.Create(" title=\"", 254), Tuple.Create("\"", 287)
            
            #line 7 "..\..\Views\ProductComment\_Create.cshtml"
                               , Tuple.Create(Tuple.Create("", 262), Tuple.Create<System.Object, System.Int32>(Admin.ItShowsCommentText
            
            #line default
            #line hidden
, 262), false)
);

WriteLiteral(" data-val=\"true\"");

WriteLiteral(" data-val-required=\"");

            
            #line 7 "..\..\Views\ProductComment\_Create.cshtml"
                                                                                                                                                                       Write(Admin.RequiredExplain);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("></textarea>\r\n    <span");

WriteLiteral(" class=\"field-validation-error\"");

WriteLiteral(" data-valmsg-for=\"commentBody\"");

WriteLiteral(" data-valmsg-replace=\"true\"");

WriteLiteral("></span>\r\n    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" id=\"btnSendComment\"");

WriteLiteral(" class=\"button primary\"");

WriteLiteral(" data-on-click=\"ajaxSendProductComment\"");

WriteLiteral(">");

            
            #line 9 "..\..\Views\ProductComment\_Create.cshtml"
                                                                                                       Write(Admin.RegisterComment);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
