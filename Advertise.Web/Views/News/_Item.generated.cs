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

namespace Advertise.Web.Views.News
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
    
    #line 2 "..\..\Views\News\_Item.cshtml"
    using Advertise.Core.Extensions;
    
    #line default
    #line hidden
    using Advertise.Core.Languages;
    
    #line 3 "..\..\Views\News\_Item.cshtml"
    using Advertise.Service.Managers.File;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\News\_Item.cshtml"
    using Advertise.Service.Services.Permissions;
    
    #line default
    #line hidden
    using Advertise.Web;
    using Advertise.Web.Framework.ViewEngines.Razor;
    using Advertise.Web.Views.Shared.SiteLayout;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/News/_Item.cshtml")]
    public partial class _Item : Advertise.Web.Framework.ViewEngines.Razor.WebViewPage<Advertise.Core.Models.News.NewsViewModel>
    {
        public _Item()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"landing-items nov-item-height-020\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"product-item column landing-column\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"nov-item-header\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"action-section without-share\"");

WriteLiteral(">\r\n");

            
            #line 10 "..\..\Views\News\_Item.cshtml"
                
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\News\_Item.cshtml"
                 if (User.IsInRole(PermissionConst.CanNewsEdit) || User.IsInRole(PermissionConst.CanNewsDeleteAjax))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"item-edit-wrapper\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"fa fa-pencil-square\"");

WriteLiteral("></i>\r\n                        <ul");

WriteLiteral(" class=\"item-edit-list\"");

WriteLiteral(">\r\n");

            
            #line 15 "..\..\Views\News\_Item.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\News\_Item.cshtml"
                             if (User.IsInRole(PermissionConst.CanUserViolationEdit))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li>\r\n                                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 918), Tuple.Create("\"", 961)
            
            #line 18 "..\..\Views\News\_Item.cshtml"
, Tuple.Create(Tuple.Create("", 925), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.News.Edit(Model.Id))
            
            #line default
            #line hidden
, 925), false)
);

WriteLiteral(">\r\n                                        <span>");

            
            #line 19 "..\..\Views\News\_Item.cshtml"
                                         Write(Admin.Edit);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                        <i");

WriteLiteral(" class=\"fa fa-pencil fa-flip-horizontal\"");

WriteLiteral("></i>\r\n                                    </a>\r\n                                " +
"</li>\r\n");

            
            #line 23 "..\..\Views\News\_Item.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                            ");

            
            #line 24 "..\..\Views\News\_Item.cshtml"
                             if (User.IsInRole(PermissionConst.CanUserViolationDeleteAjax))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li>\r\n                                    <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-on-click=\"removeConfirm\"");

WriteLiteral(" data-param=\"");

            
            #line 27 "..\..\Views\News\_Item.cshtml"
                                                                                                      Write(Url.Action(MVC.News.DeleteAjax(Model.Id)));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                                        <span>");

            
            #line 28 "..\..\Views\News\_Item.cshtml"
                                         Write(Admin.Delete);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                        <i");

WriteLiteral(" class=\"fa fa-trash\"");

WriteLiteral("></i>\r\n                                    </a>\r\n                                " +
"</li>\r\n");

            
            #line 32 "..\..\Views\News\_Item.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </ul>\r\n                    </div>\r\n");

            
            #line 35 "..\..\Views\News\_Item.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"nov-item-body\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"image-section\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"product-preview-actions\"");

WriteLiteral(">\r\n                    <figure");

WriteLiteral(" class=\"product-preview-image\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-on-click=\"openShadow\"");

WriteLiteral(" data-type=\"modal\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"item-preview-image\"");

WriteLiteral(">\r\n                                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 2301), Tuple.Create("\"", 2322)
            
            #line 44 "..\..\Views\News\_Item.cshtml"
, Tuple.Create(Tuple.Create("", 2307), Tuple.Create<System.Object, System.Int32>(FileConst.News
            
            #line default
            #line hidden
, 2307), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 2323), Tuple.Create("\"", 2340)
            
            #line 44 "..\..\Views\News\_Item.cshtml"
, Tuple.Create(Tuple.Create("", 2329), Tuple.Create<System.Object, System.Int32>(Admin.News
            
            #line default
            #line hidden
, 2329), false)
);

WriteLiteral(">\r\n                            </div>\r\n                        </a>\r\n            " +
"        </figure>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"caption-section\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" class=\"novinak-title-link\"");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-on-click=\"openShadow\"");

WriteLiteral(" data-type=\"modal\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"novinak-title text-header\"");

WriteLiteral(">");

            
            #line 52 "..\..\Views\News\_Item.cshtml"
                                                    Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                </a>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"info-section\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"middle-part\"");

WriteLiteral(">\r\n                    <p>\r\n                        <i");

WriteLiteral(" class=\"fa fa-calendar-check-o\"");

WriteLiteral("></i> \r\n                        <span>");

            
            #line 59 "..\..\Views\News\_Item.cshtml"
                         Write(Admin.InsertDate.PlusWord(":"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    </p>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"bottom-part\"");

WriteLiteral(">\r\n                    <p>");

            
            #line 63 "..\..\Views\News\_Item.cshtml"
                  Write(Model.CreatedOn.CastToRegularDate());

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n   " +
" <div");

WriteLiteral(" class=\"bg-shadow\"");

WriteLiteral("></div>\r\n    <div");

WriteLiteral(" class=\"slider-shadow\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"slide-file-preview\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"inner-preview\"");

WriteLiteral(">\r\n                <h3");

WriteLiteral(" class=\"modal-item-title\"");

WriteLiteral(">");

            
            #line 72 "..\..\Views\News\_Item.cshtml"
                                        Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n                <h5");

WriteLiteral(" class=\"modal-item-content\"");

WriteLiteral(">");

            
            #line 73 "..\..\Views\News\_Item.cshtml"
                                          Write(Model.Body);

            
            #line default
            #line hidden
WriteLiteral("</h5>\r\n                <div");

WriteLiteral(" class=\"slide-files-actions\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"slide-action-wrapper slide-file-close\"");

WriteLiteral(" data-on-click=\"closeShadow\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"fa fa-times\"");

WriteLiteral("></i>\r\n                        <i");

WriteLiteral(" class=\"fa fa-times\"");

WriteLiteral("></i>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n  " +
"      </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"clearboth\"");

WriteLiteral("></div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591