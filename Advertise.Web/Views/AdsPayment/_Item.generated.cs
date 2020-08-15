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

namespace Advertise.Web.Views.AdsPayment
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
    
    #line 2 "..\..\Views\AdsPayment\_Item.cshtml"
    using Advertise.Core.Extensions;
    
    #line default
    #line hidden
    using Advertise.Core.Languages;
    
    #line 3 "..\..\Views\AdsPayment\_Item.cshtml"
    using Advertise.Core.Types;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\AdsPayment\_Item.cshtml"
    using Advertise.Service.Managers.File;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\AdsPayment\_Item.cshtml"
    using Advertise.Service.Services.Permissions;
    
    #line default
    #line hidden
    using Advertise.Web;
    using Advertise.Web.Framework.ViewEngines.Razor;
    using Advertise.Web.Views.Shared.SiteLayout;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/AdsPayment/_Item.cshtml")]
    public partial class _Item : Advertise.Web.Framework.ViewEngines.Razor.WebViewPage<Advertise.Core.Models.AdsPayment.AdsPaymentViewModel>
    {
        public _Item()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("<div");

WriteLiteral(" class=\"adspayment-item-wrapper round-corners-five\"");

WriteLiteral(">\r\n");

            
            #line 8 "..\..\Views\AdsPayment\_Item.cshtml"
    
            
            #line default
            #line hidden
            
            #line 8 "..\..\Views\AdsPayment\_Item.cshtml"
     if (User.IsInRole(PermissionConst.CanAdsEdit) || User.IsInRole(PermissionConst.CanAdsEditApprove))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"item-action\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"item-edit-wrapper\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"fa fa-pencil-square\"");

WriteLiteral("></i>\r\n                <ul");

WriteLiteral(" class=\"item-edit-list\"");

WriteLiteral(">\r\n");

            
            #line 14 "..\..\Views\AdsPayment\_Item.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\AdsPayment\_Item.cshtml"
                     if (User.IsInRole(PermissionConst.CanAdsEdit))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <li>\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 763), Tuple.Create("\"", 808)
            
            #line 17 "..\..\Views\AdsPayment\_Item.cshtml"
, Tuple.Create(Tuple.Create("", 770), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Ads.Edit(Model.AdsId))
            
            #line default
            #line hidden
, 770), false)
);

WriteLiteral(">\r\n                                <span>");

            
            #line 18 "..\..\Views\AdsPayment\_Item.cshtml"
                                 Write(Admin.Edit);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                <i");

WriteLiteral(" class=\"fa fa-pencil fa-flip-horizontal\"");

WriteLiteral("></i>\r\n                            </a>\r\n                        </li>\r\n");

            
            #line 22 "..\..\Views\AdsPayment\_Item.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 23 "..\..\Views\AdsPayment\_Item.cshtml"
                     if (User.IsInRole(PermissionConst.CanAdsEditApprove))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <li>\r\n                            <a");

WriteLiteral(" data-on-click=\"ajaxSimple\"");

WriteLiteral(" data-param=\"");

            
            #line 26 "..\..\Views\AdsPayment\_Item.cshtml"
                                                                 Write(Url.Action(MVC.Ads.ApproveAjax(Model.AdsId)));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                                <span>");

            
            #line 27 "..\..\Views\AdsPayment\_Item.cshtml"
                                 Write(Admin.Approve);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                <i");

WriteLiteral(" class=\"fa fa-check-circle\"");

WriteLiteral("></i>\r\n                            </a>\r\n                        </li>\r\n");

            
            #line 31 "..\..\Views\AdsPayment\_Item.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n");

            
            #line 35 "..\..\Views\AdsPayment\_Item.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"adspayment-image\"");

WriteLiteral(">\r\n        <figure>\r\n            <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1640), Tuple.Create("\"", 1744)
            
            #line 38 "..\..\Views\AdsPayment\_Item.cshtml"
, Tuple.Create(Tuple.Create("", 1646), Tuple.Create<System.Object, System.Int32>(Model.AdsImage != null ? FileConst.ImagesWebPath.PlusWord(Model.AdsImage) : FileConst.NoPreview
            
            #line default
            #line hidden
, 1646), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 1745), Tuple.Create("\"", 1791)
            
            #line 38 "..\..\Views\AdsPayment\_Item.cshtml"
                                                , Tuple.Create(Tuple.Create("", 1751), Tuple.Create<System.Object, System.Int32>($"{Admin.Advertise} {Model.AdsTitle}"
            
            #line default
            #line hidden
, 1751), false)
);

WriteLiteral(" />\r\n        </figure>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"adspayment-info\"");

WriteLiteral(">\r\n        <p");

WriteLiteral(" class=\"adspayment-title\"");

WriteLiteral(">");

            
            #line 42 "..\..\Views\AdsPayment\_Item.cshtml"
                               Write(Model.AdsTitle);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        <p>\r\n            <span>");

            
            #line 44 "..\..\Views\AdsPayment\_Item.cshtml"
             Write(Admin.TypeAd);

            
            #line default
            #line hidden
WriteLiteral(":</span>\r\n            <span>");

            
            #line 45 "..\..\Views\AdsPayment\_Item.cshtml"
              Write(Model.AdsType == AdsType.Banner ? Admin.Banner : Admin.Slide);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </p>\r\n        <p>\r\n            <span>");

            
            #line 48 "..\..\Views\AdsPayment\_Item.cshtml"
             Write(Admin.Position2);

            
            #line default
            #line hidden
WriteLiteral(":</span>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2149), Tuple.Create("\"", 2343)
            
            #line 49 "..\..\Views\AdsPayment\_Item.cshtml"
, Tuple.Create(Tuple.Create("", 2156), Tuple.Create<System.Object, System.Int32>(Model.AdsPositionType == AdsPositionType.AdsLandingPage ? Url.Action(MVC.Home.LandingPage()) : Url.Action(MVC.Category.Detail(Model.CategoryAlias,Model.CategoryMetaTitle.CastToSlug()))
            
            #line default
            #line hidden
, 2156), false)
);

WriteLiteral(">\r\n                <span>");

            
            #line 50 "..\..\Views\AdsPayment\_Item.cshtml"
                  Write(Model.AdsPositionType == AdsPositionType.AdsLandingPage ? Admin.MainPage : Model.CategoryTitle);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            </a>\r\n        </p>\r\n        <p>\r\n            <span>");

            
            #line 54 "..\..\Views\AdsPayment\_Item.cshtml"
             Write(Admin.Client2);

            
            #line default
            #line hidden
WriteLiteral(":</span>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2576), Tuple.Create("\"", 2666)
            
            #line 55 "..\..\Views\AdsPayment\_Item.cshtml"
, Tuple.Create(Tuple.Create("", 2583), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Company.Detail(Model.CompanyAlias,Model.CompanyTitle.CastToSlug()))
            
            #line default
            #line hidden
, 2583), false)
);

WriteLiteral(">\r\n                <span>");

            
            #line 56 "..\..\Views\AdsPayment\_Item.cshtml"
                 Write(Model.CompanyTitle);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            </a>\r\n        </p>\r\n        <p>\r\n            <span>");

            
            #line 60 "..\..\Views\AdsPayment\_Item.cshtml"
             Write(Admin.AdvertiseFor);

            
            #line default
            #line hidden
WriteLiteral(":</span>\r\n            <a>\r\n                <span>این آگهی برای کجا استفاده میشود " +
"؟!</span>\r\n            </a>\r\n        </p>\r\n        <p>\r\n            <span>");

            
            #line 66 "..\..\Views\AdsPayment\_Item.cshtml"
             Write(Admin.Priority);

            
            #line default
            #line hidden
WriteLiteral(":</span>\r\n            <span>");

            
            #line 67 "..\..\Views\AdsPayment\_Item.cshtml"
             Write(Model.AdsOrder);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </p>\r\n        <p>\r\n            <span>");

            
            #line 70 "..\..\Views\AdsPayment\_Item.cshtml"
             Write(Admin.ValidityDuration);

            
            #line default
            #line hidden
WriteLiteral(":</span>\r\n            <span>");

            
            #line 71 "..\..\Views\AdsPayment\_Item.cshtml"
             Write(Model.AdsDuration);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </p>\r\n        <p>\r\n            <span>");

            
            #line 74 "..\..\Views\AdsPayment\_Item.cshtml"
             Write(Admin.StartDay);

            
            #line default
            #line hidden
WriteLiteral(":</span>\r\n            <span>");

            
            #line 75 "..\..\Views\AdsPayment\_Item.cshtml"
             Write(Model.StartDay);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </p>\r\n        <p>\r\n            <span>");

            
            #line 78 "..\..\Views\AdsPayment\_Item.cshtml"
             Write(Admin.PurchaseDate);

            
            #line default
            #line hidden
WriteLiteral(":</span>\r\n            <span>");

            
            #line 79 "..\..\Views\AdsPayment\_Item.cshtml"
             Write(Model.CreatedOn.CastToRegularDate());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </p>\r\n        <p>\r\n            <span>");

            
            #line 82 "..\..\Views\AdsPayment\_Item.cshtml"
             Write(Admin.PaymentPrice);

            
            #line default
            #line hidden
WriteLiteral(":</span>\r\n            <span>");

            
            #line 83 "..\..\Views\AdsPayment\_Item.cshtml"
             Write(Model.Amount.CastToRegularCurrency());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </p>\r\n        <p>\r\n            <span>");

            
            #line 86 "..\..\Views\AdsPayment\_Item.cshtml"
             Write(Admin.TrackingCode);

            
            #line default
            #line hidden
WriteLiteral(":</span>\r\n            <span>");

            
            #line 87 "..\..\Views\AdsPayment\_Item.cshtml"
             Write(Model.ReferenceCode);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </p>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"clearboth\"");

WriteLiteral("></div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
