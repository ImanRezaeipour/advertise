using Advertise.Service.Managers.File;

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
    
    #line 2 "..\..\Views\ProductComment\_DetailItem.cshtml"
    using Advertise.Core.Extensions;
    
    #line default
    #line hidden
    using Advertise.Core.Languages;
    
    #line 3 "..\..\Views\ProductComment\_DetailItem.cshtml"
#line default
    #line hidden
    using Advertise.Web;
    using Advertise.Web.Framework.ViewEngines.Razor;
    using Advertise.Web.Views.Shared.SiteLayout;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ProductComment/_DetailItem.cshtml")]
    public partial class _DetailItem : Advertise.Web.Framework.ViewEngines.Razor.WebViewPage<Advertise.Core.Models.ProductComment.ProductCommentViewModel>
    {
        public _DetailItem()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"comment-wrap-each\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(">\r\n        <figure");

WriteLiteral(" class=\"user-avatar medium\"");

WriteLiteral(">\r\n            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 324), Tuple.Create("\"", 470)
, Tuple.Create(Tuple.Create("", 330), Tuple.Create<System.Object, System.Int32>(new System.Web.WebPages.HelperResult(__razor_attribute_value_writer => {

            
            #line 8 "..\..\Views\ProductComment\_DetailItem.cshtml"
                       if (Model.UserAvatar != null) {
            
            #line default
            #line hidden
            
            #line 8 "..\..\Views\ProductComment\_DetailItem.cshtml"
                     WriteTo(__razor_attribute_value_writer, FileConst.ImagesWebPath.PlusWord(Model.UserAvatar));

            
            #line default
            #line hidden
            
            #line 8 "..\..\Views\ProductComment\_DetailItem.cshtml"
                                                                                                                      } else {
            
            #line default
            #line hidden
            
            #line 8 "..\..\Views\ProductComment\_DetailItem.cshtml"
                                                                                             WriteTo(__razor_attribute_value_writer, FileConst.NoAvatarPth);

            
            #line default
            #line hidden
            
            #line 8 "..\..\Views\ProductComment\_DetailItem.cshtml"
                                                                                                                                                                 }
            
            #line default
            #line hidden
}), 330), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 471), Tuple.Create("\"", 499)
            
            #line 8 "..\..\Views\ProductComment\_DetailItem.cshtml"
                                                                                          , Tuple.Create(Tuple.Create("", 477), Tuple.Create<System.Object, System.Int32>(Model.UserDisplayName
            
            #line default
            #line hidden
, 477), false)
);

WriteLiteral(">\r\n        </figure>\r\n    </a>\r\n    <div");

WriteLiteral(" class=\"comment\"");

WriteLiteral(">\r\n        <p");

WriteLiteral(" class=\"text-header\"");

WriteLiteral(">");

            
            #line 12 "..\..\Views\ProductComment\_DetailItem.cshtml"
                          Write(Model.UserFullName);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        <p");

WriteLiteral(" class=\"timestamp\"");

WriteLiteral(">");

            
            #line 13 "..\..\Views\ProductComment\_DetailItem.cshtml"
                        Write(Model.CreatedOn.CastToRegularDate());

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"report\"");

WriteLiteral(">");

            
            #line 14 "..\..\Views\ProductComment\_DetailItem.cshtml"
                              Write(Admin.Report);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        <p>");

            
            #line 15 "..\..\Views\ProductComment\_DetailItem.cshtml"
      Write(Model.Body);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<hr");

WriteLiteral(" class=\"line-separator\"");

WriteLiteral(">");

        }
    }
}
#pragma warning restore 1591
