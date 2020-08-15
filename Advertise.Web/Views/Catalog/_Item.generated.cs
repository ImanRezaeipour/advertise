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

namespace Advertise.Web.Views.Catalog
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
    
    #line 2 "..\..\Views\Catalog\_Item.cshtml"
    using Advertise.Core.Extensions;
    
    #line default
    #line hidden
    using Advertise.Core.Languages;
    
    #line 3 "..\..\Views\Catalog\_Item.cshtml"
    using Advertise.Service.Managers.File;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Catalog\_Item.cshtml"
    using Advertise.Service.Services.Permissions;
    
    #line default
    #line hidden
    using Advertise.Web;
    using Advertise.Web.Framework.ViewEngines.Razor;
    using Advertise.Web.Views.Shared.SiteLayout;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Catalog/_Item.cshtml")]
    public partial class _Item : Advertise.Web.Framework.ViewEngines.Razor.WebViewPage<Advertise.Core.Models.Catalog.CatalogViewModel>
    {
        public _Item()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"landing-items nov-item-height-010\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"product-item column landing-column\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"nov-item-header\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"action-section without-share\"");

WriteLiteral(">\r\n");

            
            #line 10 "..\..\Views\Catalog\_Item.cshtml"
                
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Catalog\_Item.cshtml"
                 if (User.IsInRole(PermissionConst.CanProductDeleteAjax) || User.IsInRole(PermissionConst.CanProductEdit))
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

            
            #line 15 "..\..\Views\Catalog\_Item.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Catalog\_Item.cshtml"
                             if (User.IsInRole(PermissionConst.CanProductEdit))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li>\r\n                                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 924), Tuple.Create("\"", 970)
            
            #line 18 "..\..\Views\Catalog\_Item.cshtml"
, Tuple.Create(Tuple.Create("", 931), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Catalog.Edit(Model.Id))
            
            #line default
            #line hidden
, 931), false)
);

WriteLiteral(">\r\n                                        <span>");

            
            #line 19 "..\..\Views\Catalog\_Item.cshtml"
                                         Write(Admin.Edit);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                        <i");

WriteLiteral(" class=\"fa fa-pencil fa-flip-horizontal\"");

WriteLiteral("></i>\r\n                                    </a>\r\n                                " +
"</li>\r\n");

            
            #line 23 "..\..\Views\Catalog\_Item.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                            ");

            
            #line 24 "..\..\Views\Catalog\_Item.cshtml"
                             if (User.IsInRole(PermissionConst.CanProductDeleteAjax))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li>\r\n                                    <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-on-click=\"ajaxSimple\"");

WriteLiteral(" data-param=\"");

            
            #line 27 "..\..\Views\Catalog\_Item.cshtml"
                                                                                                   Write(Url.Action(MVC.Catalog.DeleteAjax(Model.Id)));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                                        <span>");

            
            #line 28 "..\..\Views\Catalog\_Item.cshtml"
                                         Write(Admin.Delete);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                        <i");

WriteLiteral(" class=\"fa fa-trash\"");

WriteLiteral("></i>\r\n                                    </a>\r\n                                " +
"</li>\r\n");

            
            #line 32 "..\..\Views\Catalog\_Item.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </ul>\r\n                    </div>\r\n");

            
            #line 35 "..\..\Views\Catalog\_Item.cshtml"
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

WriteLiteral(" href=\"#\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"item-preview-image\"");

WriteLiteral(">\r\n                                <noscript>\r\n                                  " +
"  <img");

WriteAttribute("src", Tuple.Create(" src=\"", 2290), Tuple.Create("\"", 2447)
, Tuple.Create(Tuple.Create("", 2296), Tuple.Create<System.Object, System.Int32>(new System.Web.WebPages.HelperResult(__razor_attribute_value_writer => {

            
            #line 45 "..\..\Views\Catalog\_Item.cshtml"
                                               if (Model.ImageFileName != null) {
            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\Catalog\_Item.cshtml"
                                                WriteTo(__razor_attribute_value_writer, FileConst.ImagesCatalogWebPath.PlusWord(Model.ImageFileName));

            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\Catalog\_Item.cshtml"
                                                                                                                                                           } else {
            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\Catalog\_Item.cshtml"
                                                                                                                                  WriteTo(__razor_attribute_value_writer, FileConst.NoPreview);

            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\Catalog\_Item.cshtml"
                                                                                                                                                                                                    }
            
            #line default
            #line hidden
}), 2296), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 2448), Tuple.Create("\"", 2508)
            
            #line 45 "..\..\Views\Catalog\_Item.cshtml"
                                                                                                                            , Tuple.Create(Tuple.Create("", 2454), Tuple.Create<System.Object, System.Int32>(Model.Title.PlusWord(" ").PlusWord(Model.Description)
            
            #line default
            #line hidden
, 2454), false)
);

WriteLiteral(">\r\n                                </noscript>\r\n                                <" +
"img");

WriteLiteral(" class=\"lazyload\"");

WriteLiteral(" data-src=\"");

            
            #line 47 "..\..\Views\Catalog\_Item.cshtml"
                                                                 if (Model.ImageFileName != null) {
            
            #line default
            #line hidden
            
            #line 47 "..\..\Views\Catalog\_Item.cshtml"
                                                                                                    Write(FileConst.ImagesCatalogWebPath.PlusWord(Model.ImageFileName));

            
            #line default
            #line hidden
            
            #line 47 "..\..\Views\Catalog\_Item.cshtml"
                                                                                                                                                                             } else {
            
            #line default
            #line hidden
            
            #line 47 "..\..\Views\Catalog\_Item.cshtml"
                                                                                                                                                                                      Write(FileConst.NoPreview);

            
            #line default
            #line hidden
            
            #line 47 "..\..\Views\Catalog\_Item.cshtml"
                                                                                                                                                                                                                      }
            
            #line default
            #line hidden
WriteLiteral("\"");

WriteAttribute("alt", Tuple.Create(" alt=\"", 2773), Tuple.Create("\"", 2833)
            
            #line 47 "..\..\Views\Catalog\_Item.cshtml"
                                                                                                                                              , Tuple.Create(Tuple.Create("", 2779), Tuple.Create<System.Object, System.Int32>(Model.Title.PlusWord(" ").PlusWord(Model.Description)
            
            #line default
            #line hidden
, 2779), false)
);

WriteLiteral(">\r\n                            </div>\r\n                        </a>\r\n            " +
"        </figure>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"caption-section\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" class=\"novinak-title-link\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"novinak-title text-header\"");

WriteLiteral(">");

            
            #line 55 "..\..\Views\Catalog\_Item.cshtml"
                                                    Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                </a>\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"clearboth\"");

WriteLiteral("></div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591