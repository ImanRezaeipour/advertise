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

namespace Advertise.Web.Views.Category
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
    
    #line 2 "..\..\Views\Category\_Item.cshtml"
    using Advertise.Core.Extensions;
    
    #line default
    #line hidden
    using Advertise.Core.Languages;
    
    #line 3 "..\..\Views\Category\_Item.cshtml"
    using Advertise.Service.Managers.File;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Category\_Item.cshtml"
    using Advertise.Service.Services.Permissions;
    
    #line default
    #line hidden
    using Advertise.Web;
    using Advertise.Web.Framework.ViewEngines.Razor;
    using Advertise.Web.Views.Shared.SiteLayout;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Category/_Item.cshtml")]
    public partial class _Item : Advertise.Web.Framework.ViewEngines.Razor.WebViewPage<Advertise.Core.Models.Category.CategoryViewModel>
    {
        public _Item()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"landing-items nov-item-height-032\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"product-item column landing-column\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"nov-item-header\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"action-section\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"Alias\"");

WriteLiteral(" name=\"Alias\"");

WriteAttribute("value", Tuple.Create(" value=\"", 474), Tuple.Create("\"", 494)
            
            #line 10 "..\..\Views\Category\_Item.cshtml"
, Tuple.Create(Tuple.Create("", 482), Tuple.Create<System.Object, System.Int32>(Model.Alias
            
            #line default
            #line hidden
, 482), false)
);

WriteLiteral(" />\r\n");

            
            #line 11 "..\..\Views\Category\_Item.cshtml"
                
            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\Category\_Item.cshtml"
                 if (User.IsInRole(PermissionConst.CanCategoryEdit) || User.IsInRole(PermissionConst.CanCategoryDeleteAjax))
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

            
            #line 16 "..\..\Views\Category\_Item.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Category\_Item.cshtml"
                             if (User.IsInRole(PermissionConst.CanCategoryEdit))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li>\r\n                                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1001), Tuple.Create("\"", 1051)
            
            #line 19 "..\..\Views\Category\_Item.cshtml"
, Tuple.Create(Tuple.Create("", 1008), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Category.Edit(Model.Alias))
            
            #line default
            #line hidden
, 1008), false)
);

WriteLiteral(">\r\n                                        <span>");

            
            #line 20 "..\..\Views\Category\_Item.cshtml"
                                         Write(Admin.Edit);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                        <i");

WriteLiteral(" class=\"fa fa-pencil fa-flip-horizontal\"");

WriteLiteral("></i>\r\n                                    </a>\r\n                                " +
"</li>\r\n");

            
            #line 24 "..\..\Views\Category\_Item.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                            ");

            
            #line 25 "..\..\Views\Category\_Item.cshtml"
                             if (User.IsInRole(PermissionConst.CanCategoryDeleteAjax))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li>\r\n                                    <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-on-click=\"removeConfirm\"");

WriteLiteral(" data-param=\"");

            
            #line 28 "..\..\Views\Category\_Item.cshtml"
                                                                                                      Write(Url.Action(MVC.Category.DeleteAjax(Model.Alias)));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                                        <span>");

            
            #line 29 "..\..\Views\Category\_Item.cshtml"
                                         Write(Admin.Delete);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                        <i");

WriteLiteral(" class=\"fa fa-trash\"");

WriteLiteral("></i>\r\n                                    </a>\r\n                                " +
"</li>\r\n");

            
            #line 33 "..\..\Views\Category\_Item.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </ul>\r\n                    </div>\r\n");

            
            #line 36 "..\..\Views\Category\_Item.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n            <div");

WriteLiteral(" class=\"share-section\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"sharing-item-li\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-share-alt-square\"");

WriteLiteral("></i>\r\n                    <ul");

WriteLiteral(" class=\"item-share-list\"");

WriteLiteral(">\r\n                        <li>\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2244), Tuple.Create("\"", 2438)
            
            #line 43 "..\..\Views\Category\_Item.cshtml"
, Tuple.Create(Tuple.Create("", 2251), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Category.Detail(Model.Alias,Model.MetaTitle.Replace(" ","-"))).PlusWord("&text=").PlusWord(Model.Title).BeforeWord("https://telegram.me/share/url?url=https://novinak.com")
            
            #line default
            #line hidden
, 2251), false)
);

WriteLiteral(">\r\n                                <span>");

            
            #line 44 "..\..\Views\Category\_Item.cshtml"
                                 Write(Admin.Telegram);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                <i");

WriteLiteral(" class=\"sharings fa fa-telegram\"");

WriteLiteral("></i>\r\n                            </a>\r\n                        </li>\r\n         " +
"               <li>\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2702), Tuple.Create("\"", 2855)
            
            #line 49 "..\..\Views\Category\_Item.cshtml"
, Tuple.Create(Tuple.Create("", 2709), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Category.Detail(Model.Alias,Model.MetaTitle.Replace(" ","-"))).BeforeWord("https://plus.google.com/share?url=https://novinak.com")
            
            #line default
            #line hidden
, 2709), false)
);

WriteLiteral(">\r\n                                <span>");

            
            #line 50 "..\..\Views\Category\_Item.cshtml"
                                 Write(Admin.GPlus);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                <i");

WriteLiteral(" class=\"sharings fa fa-google-plus\"");

WriteLiteral("></i>\r\n                            </a>\r\n                        </li>\r\n         " +
"               <li>\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3119), Tuple.Create("\"", 3283)
            
            #line 55 "..\..\Views\Category\_Item.cshtml"
, Tuple.Create(Tuple.Create("", 3126), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Category.Detail(Model.Alias,Model.MetaTitle.Replace(" ","-"))).BeforeWord("https://www.facebook.com/sharer/sharer.php?u=https://novinak.com")
            
            #line default
            #line hidden
, 3126), false)
);

WriteLiteral(">\r\n                                <span>");

            
            #line 56 "..\..\Views\Category\_Item.cshtml"
                                 Write(Admin.Facebook2);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                <i");

WriteLiteral(" class=\"sharings fa fa-facebook\"");

WriteLiteral("></i>\r\n                            </a>\r\n                        </li>\r\n         " +
"               <li>\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3548), Tuple.Create("\"", 3699)
            
            #line 61 "..\..\Views\Category\_Item.cshtml"
, Tuple.Create(Tuple.Create("", 3555), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Category.Detail(Model.Alias,Model.MetaTitle.Replace(" ","-"))).BeforeWord("https://twitter.com/home?status=https://novinak.com")
            
            #line default
            #line hidden
, 3555), false)
);

WriteLiteral(">\r\n                                <span>");

            
            #line 62 "..\..\Views\Category\_Item.cshtml"
                                 Write(Admin.Twitter2);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                <i");

WriteLiteral(" class=\"sharings fa fa-twitter\"");

WriteLiteral("></i>\r\n                            </a>\r\n                        </li>\r\n         " +
"           </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n  " +
"      <div");

WriteLiteral(" class=\"nov-item-body\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"image-section\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"product-preview-actions\"");

WriteLiteral(">\r\n                    <figure");

WriteLiteral(" class=\"product-preview-image\"");

WriteLiteral(">\r\n                        <a ");

            
            #line 74 "..\..\Views\Category\_Item.cshtml"
                            if (Model.ImageFileName != null) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" href=\"");

            
            #line 74 "..\..\Views\Category\_Item.cshtml"
                                                                       Write(Url.Action(MVC.Category.Detail(Model.Alias, Model.MetaTitle.Replace(" ","-"))));

            
            #line default
            #line hidden
WriteLiteral("\" ");

WriteLiteral("  ");

            
            #line 74 "..\..\Views\Category\_Item.cshtml"
                                                                                                                                                                      }
            
            #line default
            #line hidden
WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"item-preview-image\"");

WriteLiteral(">\r\n                                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 4450), Tuple.Create("\"", 4600)
, Tuple.Create(Tuple.Create("", 4456), Tuple.Create<System.Object, System.Int32>(new System.Web.WebPages.HelperResult(__razor_attribute_value_writer => {

            
            #line 76 "..\..\Views\Category\_Item.cshtml"
                                           if (Model.ImageFileName != null) {
            
            #line default
            #line hidden
            
            #line 76 "..\..\Views\Category\_Item.cshtml"
                                            WriteTo(__razor_attribute_value_writer, FileConst.ImagesWebPath.PlusWord(Model.ImageFileName));

            
            #line default
            #line hidden
            
            #line 76 "..\..\Views\Category\_Item.cshtml"
                                                                                                                                                } else {
            
            #line default
            #line hidden
            
            #line 76 "..\..\Views\Category\_Item.cshtml"
                                                                                                                       WriteTo(__razor_attribute_value_writer, FileConst.NoPreview);

            
            #line default
            #line hidden
            
            #line 76 "..\..\Views\Category\_Item.cshtml"
                                                                                                                                                                                         }
            
            #line default
            #line hidden
}), 4456), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 4601), Tuple.Create("\"", 4661)
            
            #line 76 "..\..\Views\Category\_Item.cshtml"
                                                                                                                 , Tuple.Create(Tuple.Create("", 4607), Tuple.Create<System.Object, System.Int32>(Model.Title.PlusWord(" ").PlusWord(Model.Description)
            
            #line default
            #line hidden
, 4607), false)
);

WriteLiteral(">\r\n                            </div>\r\n                        </a>\r\n            " +
"        </figure>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"caption-section\"");

WriteLiteral(">\r\n                <a");

WriteLiteral(" class=\"novinak-title-link\"");

WriteAttribute("href", Tuple.Create(" href=\"", 4894), Tuple.Create("\"", 4976)
            
            #line 83 "..\..\Views\Category\_Item.cshtml"
, Tuple.Create(Tuple.Create("", 4901), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Category.Detail(Model.Alias, Model.MetaTitle.CastToSlug()))
            
            #line default
            #line hidden
, 4901), false)
);

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"novinak-title text-header\"");

WriteLiteral(">");

            
            #line 84 "..\..\Views\Category\_Item.cshtml"
                                                    Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                </a>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"info-section\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"top-part\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(">\r\n                        <p>\r\n                            <span>");

            
            #line 91 "..\..\Views\Category\_Item.cshtml"
                             Write(Admin.Priority.PlusWord(": "));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                            <span>");

            
            #line 92 "..\..\Views\Category\_Item.cshtml"
                             Write(Model.Order);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        </p>\r\n                    </a>\r\n                " +
"</div>\r\n                <div");

WriteLiteral(" class=\"middle-part\"");

WriteLiteral(">\r\n                    <p>\r\n                        <span>");

            
            #line 98 "..\..\Views\Category\_Item.cshtml"
                         Write(Model.CompanyCount.ToString().PlusWord("   "));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        <span>");

            
            #line 99 "..\..\Views\Category\_Item.cshtml"
                         Write(Admin.Businesses2);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        <i");

WriteLiteral(" class=\"fa fa-briefcase\"");

WriteLiteral("></i>\r\n                    </p>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"bottom-part\"");

WriteLiteral(">\r\n                    <p>\r\n                        <span>");

            
            #line 105 "..\..\Views\Category\_Item.cshtml"
                         Write(Model.ProductCount.ToString().PlusWord("   "));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        <span>");

            
            #line 106 "..\..\Views\Category\_Item.cshtml"
                         Write(Admin.ProductsOrServices);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        <i");

WriteLiteral(" class=\"fa fa-cubes\"");

WriteLiteral("></i>\r\n                    </p>\r\n                </div>\r\n            </div>\r\n    " +
"    </div>\r\n        <div");

WriteLiteral(" class=\"nov-item-footer\"");

WriteLiteral(">\r\n            <hr");

WriteLiteral(" class=\"line-separator item-footer\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"overview-section\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"image-part\"");

WriteLiteral(">\r\n                    <figure");

WriteLiteral(" class=\"user-avatar small\"");

WriteLiteral(">\r\n                        <a ");

            
            #line 117 "..\..\Views\Category\_Item.cshtml"
                            if (Model.ParentImageFileName != null) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" href=\"");

            
            #line 117 "..\..\Views\Category\_Item.cshtml"
                                                                             Write(Url.Action(MVC.Category.Detail(Model.ParentAlias)));

            
            #line default
            #line hidden
WriteLiteral("\" ");

WriteLiteral("  ");

            
            #line 117 "..\..\Views\Category\_Item.cshtml"
                                                                                                                                                }
            
            #line default
            #line hidden
WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"novinak-image\"");

WriteLiteral(">\r\n                                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 6613), Tuple.Create("\"", 6775)
, Tuple.Create(Tuple.Create("", 6619), Tuple.Create<System.Object, System.Int32>(new System.Web.WebPages.HelperResult(__razor_attribute_value_writer => {

            
            #line 119 "..\..\Views\Category\_Item.cshtml"
                                           if (Model.ParentImageFileName != null) {
            
            #line default
            #line hidden
            
            #line 119 "..\..\Views\Category\_Item.cshtml"
                                                  WriteTo(__razor_attribute_value_writer, FileConst.ImagesWebPath.PlusWord(Model.ParentImageFileName));

            
            #line default
            #line hidden
            
            #line 119 "..\..\Views\Category\_Item.cshtml"
                                                                                                                                                            } else {
            
            #line default
            #line hidden
            
            #line 119 "..\..\Views\Category\_Item.cshtml"
                                                                                                                                   WriteTo(__razor_attribute_value_writer, FileConst.NoPreview);

            
            #line default
            #line hidden
            
            #line 119 "..\..\Views\Category\_Item.cshtml"
                                                                                                                                                                                                     }
            
            #line default
            #line hidden
}), 6619), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 6776), Tuple.Create("\"", 6800)
            
            #line 119 "..\..\Views\Category\_Item.cshtml"
                                                                                                                             , Tuple.Create(Tuple.Create("", 6782), Tuple.Create<System.Object, System.Int32>(Model.ParentTitle
            
            #line default
            #line hidden
, 6782), false)
);

WriteLiteral(">\r\n                            </div>\r\n                        </a>\r\n            " +
"        </figure>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"caption-part\"");

WriteLiteral(">\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 6991), Tuple.Create("\"", 7049)
            
            #line 125 "..\..\Views\Category\_Item.cshtml"
, Tuple.Create(Tuple.Create("", 6998), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Category.Detail(Model.ParentAlias))
            
            #line default
            #line hidden
, 6998), false)
);

WriteLiteral(" class=\"tooltipster\"");

WriteAttribute("title", Tuple.Create(" title=\"", 7070), Tuple.Create("\"", 7096)
            
            #line 125 "..\..\Views\Category\_Item.cshtml"
                             , Tuple.Create(Tuple.Create("", 7078), Tuple.Create<System.Object, System.Int32>(Model.ParentTitle
            
            #line default
            #line hidden
, 7078), false)
);

WriteLiteral(">\r\n                        <p");

WriteLiteral(" class=\"text-header tiny\"");

WriteLiteral(">");

            
            #line 126 "..\..\Views\Category\_Item.cshtml"
                                               Write(Model.ParentTitle);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                    </a>\r\n                </div>\r\n            </div>\r\n     " +
"       <div");

WriteLiteral(" class=\"toggle-section follow-section\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"follow-button-wrapper\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" id=\"categoryId\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 7412), Tuple.Create("\"", 7429)
            
            #line 132 "..\..\Views\Category\_Item.cshtml"
, Tuple.Create(Tuple.Create("", 7420), Tuple.Create<System.Object, System.Int32>(Model.Id
            
            #line default
            #line hidden
, 7420), false)
);

WriteLiteral(" />\r\n                    <a ");

            
            #line 133 "..\..\Views\Category\_Item.cshtml"
                        if (User.Identity.IsAuthenticated != true) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" href=\"");

            
            #line 133 "..\..\Views\Category\_Item.cshtml"
                                                                             Write(Url.Action(MVC.Account.EmailRegister()));

            
            #line default
            #line hidden
WriteLiteral("\" ");

WriteLiteral("  ");

            
            #line 133 "..\..\Views\Category\_Item.cshtml"
                                                                                                                                     } else {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral(" href=\"javascript:void(0)\" data-on-click=\"ajaxToggleFollowCategory\" data-follow=\"" +
"");

            
            #line 133 "..\..\Views\Category\_Item.cshtml"
                                                                                                                                                                                                                                Write(Admin.Follow);

            
            #line default
            #line hidden
WriteLiteral("\" data-unfollow=\"");

            
            #line 133 "..\..\Views\Category\_Item.cshtml"
                                                                                                                                                                                                                                                              Write(Admin.Unfollow);

            
            #line default
            #line hidden
WriteLiteral("\" ");

WriteLiteral(" ");

            
            #line 133 "..\..\Views\Category\_Item.cshtml"
                                                                                                                                                                                                                                                                                            }
            
            #line default
            #line hidden
WriteLiteral(" class=\"follow-button ");

            
            #line 133 "..\..\Views\Category\_Item.cshtml"
                                                                                                                                                                                                                                                                                                                    if (Model.InitFollow) {
            
            #line default
            #line hidden
WriteLiteral("followed-btn");

            
            #line 133 "..\..\Views\Category\_Item.cshtml"
                                                                                                                                                                                                                                                                                                                                                                    } else {
            
            #line default
            #line hidden
WriteLiteral("unfollowed-btn");

            
            #line 133 "..\..\Views\Category\_Item.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                       }
            
            #line default
            #line hidden
WriteLiteral("\">\r\n                        <span>");

            
            #line 134 "..\..\Views\Category\_Item.cshtml"
                               if (Model.InitFollow){
            
            #line default
            #line hidden
            
            #line 134 "..\..\Views\Category\_Item.cshtml"
                                                      Write(Admin.Unfollow);

            
            #line default
            #line hidden
            
            #line 134 "..\..\Views\Category\_Item.cshtml"
                                                                                 }else{
            
            #line default
            #line hidden
            
            #line 134 "..\..\Views\Category\_Item.cshtml"
                                                                                        Write(Admin.Follow);

            
            #line default
            #line hidden
            
            #line 134 "..\..\Views\Category\_Item.cshtml"
                                                                                                                 }
            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    </a>\r\n                </div>\r\n            </div>\r\n  " +
"      </div>\r\n        <div");

WriteLiteral(" class=\"clearboth\"");

WriteLiteral("></div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591