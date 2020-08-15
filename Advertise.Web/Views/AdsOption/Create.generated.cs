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

namespace Advertise.Web.Views.AdsOption
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
    
    #line 2 "..\..\Views\AdsOption\Create.cshtml"
    using Advertise.Core.Types;
    
    #line default
    #line hidden
    using Advertise.Web;
    using Advertise.Web.Framework.ViewEngines.Razor;
    using Advertise.Web.Views.Shared.SiteLayout;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/AdsOption/Create.cshtml")]
    public partial class Create : Advertise.Web.Framework.ViewEngines.Razor.WebViewPage<Advertise.Core.Models.AdsOption.AdsOptionCreateViewModel>
    {
        public Create()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 4 "..\..\Views\AdsOption\Create.cshtml"
  
    Layout = MVC.Shared.Views.SiteLayout.Panel._PanelLayout;
    ViewBag.Title = Admin.AdOptionCreate;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"dashboard-content\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"headline buttons primary\"");

WriteLiteral(">\r\n        <h4>");

            
            #line 10 "..\..\Views\AdsOption\Create.cshtml"
       Write(Admin.AdOptionCreate);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"form-box-item profile-form\"");

WriteLiteral(">\r\n        <form");

WriteLiteral(" id=\"newBanner\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(" data-on-load=\"validateAdsOption\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 14 "..\..\Views\AdsOption\Create.cshtml"
       Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 15 "..\..\Views\AdsOption\Create.cshtml"
       Write(Html.ValidationSummary());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n            <div");

WriteLiteral(" class=\"input-form\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"vertical-dashed\"");

WriteLiteral("></div>\r\n\r\n                <div");

WriteLiteral(" class=\"msg-container\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"msg-box regular round-corners-five\"");

WriteLiteral("></p>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"input-container fixed-height\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"Type\"");

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">");

            
            #line 24 "..\..\Views\AdsOption\Create.cshtml"
                                                  Write(Admin.TypeAd);

            
            #line default
            #line hidden
WriteLiteral(":</label>\r\n                    <select");

WriteLiteral(" name=\"Type\"");

WriteLiteral(" id=\"Type\"");

WriteLiteral(">\r\n                        <option selected disabled>-- ");

            
            #line 26 "..\..\Views\AdsOption\Create.cshtml"
                                                Write(Admin.Choose);

            
            #line default
            #line hidden
WriteLiteral(" --</option>\r\n");

            
            #line 27 "..\..\Views\AdsOption\Create.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\AdsOption\Create.cshtml"
                         foreach (var type in Model.TypeList)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1220), Tuple.Create("\"", 1239)
            
            #line 29 "..\..\Views\AdsOption\Create.cshtml"
, Tuple.Create(Tuple.Create("", 1228), Tuple.Create<System.Object, System.Int32>(type.Value
            
            #line default
            #line hidden
, 1228), false)
);

WriteLiteral(">");

            
            #line 29 "..\..\Views\AdsOption\Create.cshtml"
                                                    Write(type.Value.ToInt32() == AdsType.Banner.ToInt32() ? Admin.Banner : Admin.Slide);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 30 "..\..\Views\AdsOption\Create.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </select>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"msg-container\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"msg-box regular round-corners-five\"");

WriteLiteral("></p>\r\n                </div>\r\n                <div");

WriteLiteral(" id=\"adsLocationContainer\"");

WriteLiteral(" class=\"input-container fixed-height\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"PositionType\"");

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">\r\n                        <span>");

            
            #line 39 "..\..\Views\AdsOption\Create.cshtml"
                         Write(Admin.Position);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    </label>\r\n                    <select");

WriteLiteral(" name=\"PositionType\"");

WriteLiteral(" id=\"PositionType\"");

WriteLiteral(" data-val=\"true\"");

WriteLiteral(" data-val-required=\"");

            
            #line 41 "..\..\Views\AdsOption\Create.cshtml"
                                                                                                Write(Admin.RequiredPosition);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                        <option selected disabled>-- ");

            
            #line 42 "..\..\Views\AdsOption\Create.cshtml"
                                                Write(Admin.Choose);

            
            #line default
            #line hidden
WriteLiteral(" --</option>\r\n");

            
            #line 43 "..\..\Views\AdsOption\Create.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 43 "..\..\Views\AdsOption\Create.cshtml"
                         foreach (var type in Model.PositionList)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <option");

WriteAttribute("value", Tuple.Create(" value=\"", 2129), Tuple.Create("\"", 2148)
            
            #line 45 "..\..\Views\AdsOption\Create.cshtml"
, Tuple.Create(Tuple.Create("", 2137), Tuple.Create<System.Object, System.Int32>(type.Value
            
            #line default
            #line hidden
, 2137), false)
);

WriteLiteral(">");

            
            #line 45 "..\..\Views\AdsOption\Create.cshtml"
                                                    Write(type.Value.ToInt32() == AdsPositionType.AdsLandingPage.ToInt32() ? Admin.MainPage : Admin.CategoriesPages);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 46 "..\..\Views\AdsOption\Create.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </select>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"msg-container\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"msg-box regular round-corners-five\"");

WriteLiteral("></p>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"input-container fixed-height\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"Title\"");

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">\r\n                        <span>");

            
            #line 55 "..\..\Views\AdsOption\Create.cshtml"
                         Write(Admin.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    </label>\r\n                    <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Title\"");

WriteLiteral(" name=\"Title\"");

WriteLiteral(" />\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"msg-container\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"msg-box regular round-corners-five\"");

WriteLiteral("></p>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"input-container fixed-height\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"Order\"");

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">\r\n                        <span>");

            
            #line 65 "..\..\Views\AdsOption\Create.cshtml"
                         Write(Admin.Priority);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    </label>\r\n                    <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Order\"");

WriteLiteral(" name=\"Order\"");

WriteLiteral(" />\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"msg-container\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"msg-box regular round-corners-five\"");

WriteLiteral("></p>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"input-container fixed-height\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"Price\"");

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">\r\n                        <span>");

            
            #line 75 "..\..\Views\AdsOption\Create.cshtml"
                         Write(Admin.Price);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    </label>\r\n                    <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Price\"");

WriteLiteral(" name=\"Price\"");

WriteLiteral(" />\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"input-container\"");

WriteLiteral("></div>\r\n            </div>\r\n        </form>\r\n\r\n        <div");

WriteLiteral(" class=\"form-button-container\"");

WriteLiteral(">\r\n            <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" form=\"newBanner\"");

WriteLiteral(" class=\"form-button right-form-btn ok-button round-corners-five disabled-btn-link" +
"\"");

WriteLiteral(" disabled=\"disabled\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 3944), Tuple.Create("\"", 4018)
, Tuple.Create(Tuple.Create("", 3954), Tuple.Create("javascript:", 3954), true)
, Tuple.Create(Tuple.Create(" ", 3965), Tuple.Create("form.action", 3966), true)
, Tuple.Create(Tuple.Create(" ", 3977), Tuple.Create("=", 3978), true)
, Tuple.Create(Tuple.Create(" ", 3979), Tuple.Create("\'", 3980), true)
            
            #line 85 "..\..\Views\AdsOption\Create.cshtml"
                                                                                                             , Tuple.Create(Tuple.Create("", 3981), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.AdsOption.Create())
            
            #line default
            #line hidden
, 3981), false)
, Tuple.Create(Tuple.Create("", 4016), Tuple.Create("\';", 4016), true)
);

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"fa fa-save\"");

WriteLiteral("></i>\r\n                <span>");

            
            #line 87 "..\..\Views\AdsOption\Create.cshtml"
                 Write(Admin.Save);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            </button>\r\n        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
