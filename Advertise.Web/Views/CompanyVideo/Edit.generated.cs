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

namespace Advertise.Web.Views.CompanyVideo
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
    
    #line 3 "..\..\Views\CompanyVideo\Edit.cshtml"
    using Auth = Advertise.Service.Services.Permissions.PermissionConst;
    
    #line default
    #line hidden
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CompanyVideo/Edit.cshtml")]
    public partial class Edit : Advertise.Web.Framework.ViewEngines.Razor.WebViewPage<Advertise.Core.Models.CompanyVideo.CompanyVideoEditViewModel>
    {
        public Edit()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 4 "..\..\Views\CompanyVideo\Edit.cshtml"
  
    Layout = Model.IsMine != true ? MVC.Shared.Views.SiteLayout.Panel._PanelLayout : MVC.Shared.Views.SiteLayout.Profile._ProfileLayout;
    ViewBag.Title = "ویرایش فیلم";

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"dashboard-content\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"headline buttons primary\"");

WriteLiteral(">\r\n        <h4> ویرایش فیلم</h4>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"form-box-item profile-form\"");

WriteLiteral(">\r\n        <form");

WriteLiteral(" id=\"editCompanyVideo\"");

WriteLiteral(" action=\"\"");

WriteLiteral(" method=\"Post\"");

WriteLiteral(" data-on-load=\"validateCompanyVideo\"");

WriteLiteral(" >\r\n");

WriteLiteral("            ");

            
            #line 14 "..\..\Views\CompanyVideo\Edit.cshtml"
       Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 15 "..\..\Views\CompanyVideo\Edit.cshtml"
       Write(Html.ValidationSummary());

            
            #line default
            #line hidden
WriteLiteral("\r\n            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"Id\"");

WriteLiteral(" name=\"Id\"");

WriteAttribute("value", Tuple.Create(" value=\"", 764), Tuple.Create("\"", 781)
            
            #line 16 "..\..\Views\CompanyVideo\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 772), Tuple.Create<System.Object, System.Int32>(Model.Id
            
            #line default
            #line hidden
, 772), false)
);

WriteLiteral(" />\r\n\r\n            <div");

WriteLiteral(" class=\"input-form\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"vertical-dashed\"");

WriteLiteral("></div>\r\n                \r\n                <div");

WriteLiteral(" class=\"msg-container\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"msg-box regular round-corners-five\"");

WriteLiteral(">\r\n                        <p>\r\n                            <i");

WriteLiteral(" class=\"fa fa-quote-right\"");

WriteLiteral("></i>\r\n                            <span></span>\r\n                            <i");

WriteLiteral(" class=\"fa fa-quote-left\"");

WriteLiteral("></i>\r\n                        </p>\r\n                    </div>\r\n                " +
"</div>\r\n                <div");

WriteLiteral(" class=\"input-container fixed-height\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"Title\"");

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">");

            
            #line 31 "..\..\Views\CompanyVideo\Edit.cshtml"
                                                   Write(Admin.Title);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                    <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Title\"");

WriteLiteral(" name=\"Title\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1492), Tuple.Create("\"", 1512)
            
            #line 32 "..\..\Views\CompanyVideo\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1500), Tuple.Create<System.Object, System.Int32>(Model.Title
            
            #line default
            #line hidden
, 1500), false)
);

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 1513), Tuple.Create("\"", 1539)
            
            #line 32 "..\..\Views\CompanyVideo\Edit.cshtml"
                 , Tuple.Create(Tuple.Create("", 1527), Tuple.Create<System.Object, System.Int32>(Admin.Title
            
            #line default
            #line hidden
, 1527), false)
);

WriteLiteral(" class=\"tooltipster\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1560), Tuple.Create("\"", 1591)
            
            #line 32 "..\..\Views\CompanyVideo\Edit.cshtml"
                                                          , Tuple.Create(Tuple.Create("", 1568), Tuple.Create<System.Object, System.Int32>(Admin.ItShowsImageName
            
            #line default
            #line hidden
, 1568), false)
);

WriteLiteral("/>\r\n                </div>\r\n                \r\n                <div");

WriteLiteral(" class=\"msg-container\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"msg-box regular round-corners-five\"");

WriteLiteral(">\r\n                        <p>\r\n                            <i");

WriteLiteral(" class=\"fa fa-quote-right\"");

WriteLiteral("></i>\r\n                            <span></span>\r\n                            <i");

WriteLiteral(" class=\"fa fa-quote-left\"");

WriteLiteral("></i>\r\n                        </p>\r\n                    </div>\r\n                " +
"</div>\r\n                <div");

WriteLiteral(" class=\"input-container fixed-height\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"Order\"");

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">اولویت</label>\r\n                    <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Order\"");

WriteLiteral(" name=\"Order\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2226), Tuple.Create("\"", 2246)
            
            #line 46 "..\..\Views\CompanyVideo\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2234), Tuple.Create<System.Object, System.Int32>(Model.Order
            
            #line default
            #line hidden
, 2234), false)
);

WriteLiteral(" placeholder=\"الویت\"");

WriteLiteral(" class=\"tooltipster\"");

WriteAttribute("title", Tuple.Create(" title=\"", 2287), Tuple.Create("\"", 2318)
            
            #line 46 "..\..\Views\CompanyVideo\Edit.cshtml"
                                                   , Tuple.Create(Tuple.Create("", 2295), Tuple.Create<System.Object, System.Int32>(Admin.ItShowsImageName
            
            #line default
            #line hidden
, 2295), false)
);

WriteLiteral("/>\r\n                </div>\r\n                \r\n                <div");

WriteLiteral(" class=\"msg-container\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"msg-box regular round-corners-five\"");

WriteLiteral(">\r\n                        <p>\r\n                            <i");

WriteLiteral(" class=\"fa fa-quote-right\"");

WriteLiteral("></i>\r\n                            <span></span>\r\n                            <i");

WriteLiteral(" class=\"fa fa-quote-left\"");

WriteLiteral("></i>\r\n                        </p>\r\n                    </div>\r\n                " +
"</div>\r\n                <div");

WriteLiteral(" class=\"input-container fixed-height\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"files\"");

WriteLiteral(" class=\"rl-label tooltipster\"");

WriteAttribute("title", Tuple.Create(" title=\"", 2886), Tuple.Create("\"", 2915)
            
            #line 59 "..\..\Views\CompanyVideo\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2894), Tuple.Create<System.Object, System.Int32>(Admin.UploadingPhoto
            
            #line default
            #line hidden
, 2894), false)
);

WriteLiteral(">بارگذاری فیلم</label>\r\n");

WriteLiteral("                    ");

            
            #line 60 "..\..\Views\CompanyVideo\Edit.cshtml"
               Write(Html.Partial(MVC.Shared.Views.FineUploaderTemplates._FineUploaderTemplate));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" name=\"files\"");

WriteLiteral(" id=\"files\"");

WriteLiteral(" data-on-load=\"uploaderCompanyVideo\"");

WriteLiteral(" data-param=\"edit\"");

WriteLiteral("></div>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"input-container\"");

WriteLiteral("></div>\r\n            </div>\r\n        </form>\r\n        \r\n        <div");

WriteLiteral(" class=\"form-button-container\"");

WriteLiteral(">\r\n");

            
            #line 69 "..\..\Views\CompanyVideo\Edit.cshtml"
            
            
            #line default
            #line hidden
            
            #line 69 "..\..\Views\CompanyVideo\Edit.cshtml"
             if (User.IsInRole(Auth.CanCompanyVideoEditApprove) && Model.IsMine != true)
            {

            
            #line default
            #line hidden
WriteLiteral("                <button");

WriteLiteral(" form=\"editCompanyVideo\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"form-button right-form-btn ok-button round-corners-five disabled-btn-link" +
"\"");

WriteLiteral(" disabled=\"disabled\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 3587), Tuple.Create("\"", 3669)
, Tuple.Create(Tuple.Create("", 3597), Tuple.Create("javascript:", 3597), true)
, Tuple.Create(Tuple.Create(" ", 3608), Tuple.Create("form.action", 3609), true)
, Tuple.Create(Tuple.Create(" ", 3620), Tuple.Create("=", 3621), true)
, Tuple.Create(Tuple.Create(" ", 3622), Tuple.Create("\'", 3623), true)
            
            #line 71 "..\..\Views\CompanyVideo\Edit.cshtml"
                                                                                                                        , Tuple.Create(Tuple.Create("", 3624), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.CompanyVideo.EditApprove())
            
            #line default
            #line hidden
, 3624), false)
, Tuple.Create(Tuple.Create("", 3667), Tuple.Create("\';", 3667), true)
);

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-check-circle\"");

WriteLiteral("></i>\r\n                    <span>");

            
            #line 73 "..\..\Views\CompanyVideo\Edit.cshtml"
                     Write(Admin.OkAndClose);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </button>\r\n");

WriteLiteral("                <button");

WriteLiteral(" form=\"editCompany\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"form-button right-form-btn ok-button round-corners-five disabled-btn-link" +
"\"");

WriteLiteral(" disabled=\"disabled\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 3966), Tuple.Create("\"", 4047)
, Tuple.Create(Tuple.Create("", 3976), Tuple.Create("javascript:", 3976), true)
, Tuple.Create(Tuple.Create(" ", 3987), Tuple.Create("form.action", 3988), true)
, Tuple.Create(Tuple.Create(" ", 3999), Tuple.Create("=", 4000), true)
, Tuple.Create(Tuple.Create(" ", 4001), Tuple.Create("\'", 4002), true)
            
            #line 75 "..\..\Views\CompanyVideo\Edit.cshtml"
                                                                                                                   , Tuple.Create(Tuple.Create("", 4003), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.CompanyVideo.EditReject())
            
            #line default
            #line hidden
, 4003), false)
, Tuple.Create(Tuple.Create("", 4045), Tuple.Create("\';", 4045), true)
);

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-times-circle\"");

WriteLiteral("></i>\r\n                    <span>");

            
            #line 77 "..\..\Views\CompanyVideo\Edit.cshtml"
                     Write(Admin.CancelAndClose);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </button>\r\n");

            
            #line 79 "..\..\Views\CompanyVideo\Edit.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <button");

WriteLiteral(" form=\"editCompanyVideo\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"form-button right-form-btn ok-button round-corners-five disabled-btn-link" +
"\"");

WriteLiteral(" disabled=\"disabled\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 4401), Tuple.Create("\"", 4478)
, Tuple.Create(Tuple.Create("", 4411), Tuple.Create("javascript:", 4411), true)
, Tuple.Create(Tuple.Create(" ", 4422), Tuple.Create("form.action", 4423), true)
, Tuple.Create(Tuple.Create(" ", 4434), Tuple.Create("=", 4435), true)
, Tuple.Create(Tuple.Create(" ", 4436), Tuple.Create("\'", 4437), true)
            
            #line 82 "..\..\Views\CompanyVideo\Edit.cshtml"
                                                                                                                        , Tuple.Create(Tuple.Create("", 4438), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.CompanyVideo.MyEdit())
            
            #line default
            #line hidden
, 4438), false)
, Tuple.Create(Tuple.Create("", 4476), Tuple.Create("\';", 4476), true)
);

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-save\"");

WriteLiteral("></i>\r\n                    <span>");

            
            #line 84 "..\..\Views\CompanyVideo\Edit.cshtml"
                     Write(Admin.Save);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </button>\r\n");

            
            #line 86 "..\..\Views\CompanyVideo\Edit.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
