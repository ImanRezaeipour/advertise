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

namespace Advertise.Web.Views.Manufacturer
{
    using System;
    using System.Collections.Generic;
    
    #line 2 "..\..\Views\Manufacturer\_Item.cshtml"
    using System.Diagnostics;
    
    #line default
    #line hidden
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
    
    #line 3 "..\..\Views\Manufacturer\_Item.cshtml"
    using Advertise.Service.Services.Permissions;
    
    #line default
    #line hidden
    using Advertise.Web;
    using Advertise.Web.Framework.ViewEngines.Razor;
    using Advertise.Web.Views.Shared.SiteLayout;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Manufacturer/_Item.cshtml")]
    public partial class _Item : Advertise.Web.Framework.ViewEngines.Razor.WebViewPage<Advertise.Core.Models.Manufacturer.ManufacturerViewModel>
    {
        public _Item()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"landing-items nov-item-height-031\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"product-item column landing-column\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"nov-item-header\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"action-section\"");

WriteLiteral(">\r\n");

            
            #line 9 "..\..\Views\Manufacturer\_Item.cshtml"
                
            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Manufacturer\_Item.cshtml"
                 if (User.IsInRole(PermissionConst.CanManufacturerDeleteAjax) || User.IsInRole(PermissionConst.CanManufacturerEdit))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"item-edit-wrapper\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"fa fa-pencil-square\"");

WriteLiteral("></i>\r\n                        <ul");

WriteLiteral(" class=\"item-edit-list\"");

WriteLiteral(">\r\n                            <li>\r\n                                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 763), Tuple.Create("\"", 814)
            
            #line 15 "..\..\Views\Manufacturer\_Item.cshtml"
, Tuple.Create(Tuple.Create("", 770), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Manufacturer.Edit(Model.Id))
            
            #line default
            #line hidden
, 770), false)
);

WriteLiteral(">\r\n                                    <span>");

            
            #line 16 "..\..\Views\Manufacturer\_Item.cshtml"
                                     Write(Admin.Edit);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                    <i");

WriteLiteral(" class=\"fa fa-pencil fa-flip-horizontal\"");

WriteLiteral("></i>\r\n                                </a>\r\n                            </li>\r\n");

            
            #line 20 "..\..\Views\Manufacturer\_Item.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Manufacturer\_Item.cshtml"
                             if (User.IsInRole(PermissionConst.CanManufacturerDeleteAjax))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li>\r\n                                    <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-on-click=\"removeConfirm\"");

WriteLiteral(" data-param=\"");

            
            #line 23 "..\..\Views\Manufacturer\_Item.cshtml"
                                                                                                      Write(Url.Action(MVC.Manufacturer.DeleteAjax(Model.Id)));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                                        <span>");

            
            #line 24 "..\..\Views\Manufacturer\_Item.cshtml"
                                         Write(Admin.Delete);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                        <i");

WriteLiteral(" class=\"fa fa-trash\"");

WriteLiteral("></i>\r\n                                    </a>\r\n                                " +
"</li>\r\n");

            
            #line 28 "..\..\Views\Manufacturer\_Item.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </ul>\r\n                    </div>\r\n");

            
            #line 31 "..\..\Views\Manufacturer\_Item.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"nov-item-body\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"image-section\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"product-preview-actions\"");

WriteLiteral("></div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"caption-section\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" class=\"novinak-title-link\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"novinak-title text-header\"");

WriteLiteral(">");

            
            #line 40 "..\..\Views\Manufacturer\_Item.cshtml"
                                                    Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                </a>\r\n                <a");

WriteLiteral(" class=\"novinak-title-link\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"novinak-title text-header\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 44 "..\..\Views\Manufacturer\_Item.cshtml"
                   Write(Model.Country.Value);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </p>\r\n                </a>\r\n            </div>\r\n        </d" +
"iv>\r\n        <div");

WriteLiteral(" class=\"clearboth\"");

WriteLiteral("></div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
