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

namespace Advertise.Web.Views.CompanySlide
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
    
    #line 2 "..\..\Views\CompanySlide\Create.cshtml"
    using Advertise.Service.Services.Permissions;
    
    #line default
    #line hidden
    using Advertise.Web;
    using Advertise.Web.Framework.ViewEngines.Razor;
    using Advertise.Web.Views.Shared.SiteLayout;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CompanySlide/Create.cshtml")]
    public partial class Create : Advertise.Web.Framework.ViewEngines.Razor.WebViewPage<Advertise.Core.Models.CompanySlide.CompanySlideCreateViewModel>
    {
        public Create()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 4 "..\..\Views\CompanySlide\Create.cshtml"
  
    Layout = MVC.Shared.Views.SiteLayout.Profile._ProfileLayout;
    ViewBag.Title = "ایجاد اسلاید کمپانی";

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"profile-content\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"headline buttons primary\"");

WriteLiteral(">\r\n        <h4>ایجاد اسلاید کمپانی</h4>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"form-box-item profile-form\"");

WriteLiteral(">\r\n        <form");

WriteLiteral(" id=\"newCompanySlide\"");

WriteLiteral(" data-on-load=\"validateCompanySlide\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 14 "..\..\Views\CompanySlide\Create.cshtml"
       Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 15 "..\..\Views\CompanySlide\Create.cshtml"
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

WriteLiteral(" for=\"Title\"");

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">\r\n                        <span>");

            
            #line 25 "..\..\Views\CompanySlide\Create.cshtml"
                         Write(Admin.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    </label>\r\n                    <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Title\"");

WriteLiteral(" name=\"Title\"");

WriteLiteral(" class=\"tooltipster\"");

WriteLiteral(" />\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"msg-container\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"msg-box regular round-corners-five\"");

WriteLiteral("></p>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"input-container fixed-height\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"ImageFileName\"");

WriteLiteral(" class=\"rl-label tooltipster\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1446), Tuple.Create("\"", 1475)
            
            #line 34 "..\..\Views\CompanySlide\Create.cshtml"
   , Tuple.Create(Tuple.Create("", 1454), Tuple.Create<System.Object, System.Int32>(Admin.ItChoosesImage
            
            #line default
            #line hidden
, 1454), false)
);

WriteLiteral(">");

            
            #line 34 "..\..\Views\CompanySlide\Create.cshtml"
                                                                                                     Write(Admin.UploadAdPhoto);

            
            #line default
            #line hidden
WriteLiteral(" :</label>\r\n");

WriteLiteral("                    ");

            
            #line 35 "..\..\Views\CompanySlide\Create.cshtml"
               Write(Html.Partial(MVC.Shared.Views.FineUploaderTemplates._FineUploaderTemplate));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" name=\"ImageFileName\"");

WriteLiteral(" id=\"ImageFileName\"");

WriteLiteral(" data-on-load=\"uploaderCompanySlide\"");

WriteLiteral("></div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"msg-container\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"msg-box regular round-corners-five\"");

WriteLiteral("></p>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"input-container fixed-height\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">\r\n                        <span>");

            
            #line 44 "..\..\Views\CompanySlide\Create.cshtml"
                         Write(Admin.ThisAdIsUsedFor);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    </label>\r\n                    <label");

WriteLiteral(" class=\"enabled-form-iradio-label\"");

WriteLiteral(" for=\"CompanyEntity\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" name=\"EntityName\"");

WriteLiteral(" value=\"CompanyEntity\"");

WriteLiteral(" id=\"CompanyEntity\"");

WriteLiteral(" data-on-change=\"disableEntity\"");

WriteLiteral(" checked />\r\n                        <span>کمپانی من</span>\r\n                    " +
"</label>\r\n                    <label");

WriteLiteral(" class=\"disabled-form-iradio-label\"");

WriteLiteral(" for=\"ProductEntity\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" name=\"EntityName\"");

WriteLiteral(" value=\"ProductEntity\"");

WriteLiteral(" id=\"ProductEntity\"");

WriteLiteral(" data-on-change=\"enableEntity\"");

WriteLiteral(" />\r\n                        <span>محصولات</span>\r\n                    </label>\r\n" +
"                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"msg-container hide-none\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"msg-box regular round-corners-five\"");

WriteLiteral("></p>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"input-container fixed-height hide-none\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"ProductId\"");

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">محصولات</label>\r\n                    <select");

WriteLiteral(" name=\"ProductId\"");

WriteLiteral(" id=\"ProductId\"");

WriteLiteral(">\r\n                        <option selected disabled>-- ");

            
            #line 62 "..\..\Views\CompanySlide\Create.cshtml"
                                                Write(Admin.Choose);

            
            #line default
            #line hidden
WriteLiteral(" --</option>\r\n");

            
            #line 63 "..\..\Views\CompanySlide\Create.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 63 "..\..\Views\CompanySlide\Create.cshtml"
                         foreach (var item in Model.EntityList)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <option");

WriteAttribute("value", Tuple.Create(" value=\"", 3276), Tuple.Create("\"", 3295)
            
            #line 65 "..\..\Views\CompanySlide\Create.cshtml"
, Tuple.Create(Tuple.Create("", 3284), Tuple.Create<System.Object, System.Int32>(item.Value
            
            #line default
            #line hidden
, 3284), false)
);

WriteAttribute("selected", Tuple.Create(" selected=\"", 3296), Tuple.Create("\"", 3350)
            
            #line 65 "..\..\Views\CompanySlide\Create.cshtml"
, Tuple.Create(Tuple.Create("", 3307), Tuple.Create<System.Object, System.Int32>(Model.ProductId.ToString() == item.Value
            
            #line default
            #line hidden
, 3307), false)
);

WriteLiteral(">");

            
            #line 65 "..\..\Views\CompanySlide\Create.cshtml"
                                                                                                          Write(item.Text);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 66 "..\..\Views\CompanySlide\Create.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </select>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"input-container\"");

WriteLiteral("></div>\r\n            </div>\r\n        </form>\r\n        <div");

WriteLiteral(" class=\"form-button-container\"");

WriteLiteral(">\r\n            <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" form=\"newCompanySlide\"");

WriteLiteral(" class=\"form-button right-form-btn ok-button round-corners-five disabled-btn-link" +
"\"");

WriteLiteral(" disabled=\"disabled\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 3750), Tuple.Create("\"", 3827)
, Tuple.Create(Tuple.Create("", 3760), Tuple.Create("javascript:", 3760), true)
, Tuple.Create(Tuple.Create(" ", 3771), Tuple.Create("form.action", 3772), true)
, Tuple.Create(Tuple.Create(" ", 3783), Tuple.Create("=", 3784), true)
, Tuple.Create(Tuple.Create(" ", 3785), Tuple.Create("\'", 3786), true)
            
            #line 74 "..\..\Views\CompanySlide\Create.cshtml"
                                                                                                                   , Tuple.Create(Tuple.Create("", 3787), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.CompanySlide.Create())
            
            #line default
            #line hidden
, 3787), false)
, Tuple.Create(Tuple.Create("", 3825), Tuple.Create("\';", 3825), true)
);

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"fa fa-save\"");

WriteLiteral("></i>\r\n                <span>ذخیره</span>\r\n            </button>\r\n        </div>\r" +
"\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
