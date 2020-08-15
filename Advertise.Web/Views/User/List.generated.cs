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

namespace Advertise.Web.Views.User
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
    
    #line 2 "..\..\Views\User\List.cshtml"
    using Advertise.Service.Services.Permissions;
    
    #line default
    #line hidden
    using Advertise.Web;
    using Advertise.Web.Framework.ViewEngines.Razor;
    using Advertise.Web.Views.Shared.SiteLayout;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/User/List.cshtml")]
    public partial class List : Advertise.Web.Framework.ViewEngines.Razor.WebViewPage<Advertise.Core.Models.User.UserListViewModel>
    {
        public List()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 4 "..\..\Views\User\List.cshtml"
  
    Layout = MVC.Shared.Views.SiteLayout.Panel._PanelLayout;
    ViewBag.Title = Admin.ListUsers;
    ViewBag.PageName = "users";
    ViewBag.HasSearchbar = true;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 330), Tuple.Create("\"", 433)
, Tuple.Create(Tuple.Create("", 338), Tuple.Create<System.Object, System.Int32>(new System.Web.WebPages.HelperResult(__razor_attribute_value_writer => {

            
            #line 10 "..\..\Views\User\List.cshtml"
             if (Model.IsMine != true) {
            
            #line default
            #line hidden
WriteLiteralTo(__razor_attribute_value_writer, "dashboard-content");

            
            #line 10 "..\..\Views\User\List.cshtml"
                                                                      } else {
            
            #line default
            #line hidden
WriteLiteralTo(__razor_attribute_value_writer, "profile-content");

            
            #line 10 "..\..\Views\User\List.cshtml"
                                                                                                          }
            
            #line default
            #line hidden
}), 338), false)
);

WriteLiteral(">\r\n    <div");

WriteLiteral(" id=\"search\"");

WriteLiteral(" class=\"list-searchbar\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 12 "..\..\Views\User\List.cshtml"
   Write(SearchItem.Term(Model.SearchRequest.Term));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 13 "..\..\Views\User\List.cshtml"
   Write(SearchItem.SortDirection(Model.SortDirectionList, Model.SearchRequest.SortDirection));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 14 "..\..\Views\User\List.cshtml"
   Write(SearchItem.PageSize(Model.PageSizeList, Model.SearchRequest.PageSize));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 15 "..\..\Views\User\List.cshtml"
   Write(SearchItem.IsActive(Model.IsActiveList, Model.SearchRequest.IsActive));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 16 "..\..\Views\User\List.cshtml"
   Write(SearchItem.IsBan(Model.IsBanList, Model.SearchRequest.IsBan));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 17 "..\..\Views\User\List.cshtml"
   Write(SearchItem.IsVerify(Model.IsVerifyList, Model.SearchRequest.IsVerify));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 18 "..\..\Views\User\List.cshtml"
   Write(SearchItem.GridView());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"headline buttons primary\"");

WriteLiteral(">\r\n        <h1>");

            
            #line 22 "..\..\Views\User\List.cshtml"
             if (Model.IsMine != true){
            
            #line default
            #line hidden
WriteLiteral("لیست کاربران");

            
            #line 22 "..\..\Views\User\List.cshtml"
                                                                }else{
            
            #line default
            #line hidden
WriteLiteral("لیست کاربران");

            
            #line 22 "..\..\Views\User\List.cshtml"
                                                                                               }
            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"landing-grids-wrapper\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"product-list grid\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"landing-column-wrapper\"");

WriteLiteral(">\r\n");

            
            #line 28 "..\..\Views\User\List.cshtml"
                
            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\User\List.cshtml"
                 if (User.IsInRole(PermissionConst.CanUserEasyRegister))
                {
                    
            
            #line default
            #line hidden
            
            #line 30 "..\..\Views\User\List.cshtml"
               Write(Html.Partial(MVC.User.Views._AddItem));

            
            #line default
            #line hidden
            
            #line 30 "..\..\Views\User\List.cshtml"
                                                          
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 32 "..\..\Views\User\List.cshtml"
           Write(Html.Partial(MVC.User.Views._ListMore, Model.Users));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"pager\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 38 "..\..\Views\User\List.cshtml"
   Write(Html.Partial(MVC.Shared.Views.SiteLayout._Paging, Model.SearchRequest));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591