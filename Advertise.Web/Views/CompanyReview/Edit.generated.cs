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

namespace Advertise.Web.Views.CompanyReview
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
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CompanyReview/Edit.cshtml")]
    public partial class Edit : Advertise.Web.Framework.ViewEngines.Razor.WebViewPage<Advertise.Core.Models.CompanyReview.CompanyReviewEditViewModel>
    {
        public Edit()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 3 "..\..\Views\CompanyReview\Edit.cshtml"
  
    Layout = MVC.Shared.Views.SiteLayout.Panel._PanelLayout;
    ViewBag.Title = Admin.EditReview;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"dashboard-content\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"headline buttons primary\"");

WriteLiteral(">\r\n        <h4>");

            
            #line 9 "..\..\Views\CompanyReview\Edit.cshtml"
       Write(Admin.EditReview);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"form-box-item profile-form\"");

WriteLiteral(">\r\n        <form");

WriteLiteral(" id=\"editCompanyReview\"");

WriteAttribute("action", Tuple.Create(" action=\"", 438), Tuple.Create("\"", 484)
            
            #line 12 "..\..\Views\CompanyReview\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 447), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.CompanyReview.Edit())
            
            #line default
            #line hidden
, 447), false)
);

WriteLiteral(" method=\"Post\"");

WriteLiteral(" data-on-load=\"validateCompanyReview\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 13 "..\..\Views\CompanyReview\Edit.cshtml"
       Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 14 "..\..\Views\CompanyReview\Edit.cshtml"
       Write(Html.ValidationSummary());

            
            #line default
            #line hidden
WriteLiteral("\r\n            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"CompanyId\"");

WriteLiteral(" name=\"CompanyId\"");

WriteAttribute("value", Tuple.Create(" value=\"", 680), Tuple.Create("\"", 704)
            
            #line 15 "..\..\Views\CompanyReview\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 688), Tuple.Create<System.Object, System.Int32>(Model.CompanyId
            
            #line default
            #line hidden
, 688), false)
);

WriteLiteral("/>\r\n\r\n            <div");

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

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">");

            
            #line 30 "..\..\Views\CompanyReview\Edit.cshtml"
                                       Write(Admin.BrandName);

            
            #line default
            #line hidden
WriteLiteral(" : ");

            
            #line 30 "..\..\Views\CompanyReview\Edit.cshtml"
                                                          Write(Model.CompanyTitle);

            
            #line default
            #line hidden
WriteLiteral(" </label>\r\n                </div>\r\n                \r\n                <div");

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

WriteLiteral(" class=\"rl-label tooltipster\"");

WriteLiteral(" title=\"عنوان را وارد کنید\"");

WriteLiteral(">عنوان</label>\r\n                    <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Title\"");

WriteLiteral(" name=\"Title\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2035), Tuple.Create("\"", 2055)
            
            #line 44 "..\..\Views\CompanyReview\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2043), Tuple.Create<System.Object, System.Int32>(Model.Title
            
            #line default
            #line hidden
, 2043), false)
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

WriteLiteral(" for=\"Body\"");

WriteLiteral(" class=\"rl-label tooltipster\"");

WriteAttribute("title", Tuple.Create(" title=\"", 2622), Tuple.Create("\"", 2654)
            
            #line 57 "..\..\Views\CompanyReview\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2630), Tuple.Create<System.Object, System.Int32>(Admin.ItShowsReviewText
            
            #line default
            #line hidden
, 2630), false)
);

WriteLiteral(">");

            
            #line 57 "..\..\Views\CompanyReview\Edit.cshtml"
                                                                                               Write(Admin.ReviewText);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                    <textarea");

WriteLiteral(" id=\"Body\"");

WriteLiteral(" name=\"Body\"");

WriteLiteral(" data-on-load=\"editorCompanyReview\"");

WriteLiteral(" data-val=\"true\"");

WriteLiteral(" data-val-required=\"");

            
            #line 58 "..\..\Views\CompanyReview\Edit.cshtml"
                                                                                                                     Write(Admin.RequiredExplain);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">");

            
            #line 58 "..\..\Views\CompanyReview\Edit.cshtml"
                                                                                                                                             Write(Model.Body);

            
            #line default
            #line hidden
WriteLiteral("</textarea>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"input-container\"");

WriteLiteral("></div>\r\n            </div>\r\n        </form>\r\n        \r\n        <div");

WriteLiteral(" class=\"form-button-container\"");

WriteLiteral(">\r\n            <button");

WriteLiteral(" form=\"editCompanyReview\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"form-button right-form-btn ok-button round-corners-five disabled-btn-link" +
"\"");

WriteLiteral(" disabled=\"disabled\"");

WriteLiteral(" >\r\n                <i");

WriteLiteral(" class=\"fa fa-save\"");

WriteLiteral("></i>\r\n                <span>");

            
            #line 68 "..\..\Views\CompanyReview\Edit.cshtml"
                 Write(Admin.Save);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            </button>\r\n        </div>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
