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

namespace Advertise.Web.Views.ProductReview
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ProductReview/Edit.cshtml")]
    public partial class Edit : Advertise.Web.Framework.ViewEngines.Razor.WebViewPage<Advertise.Core.Models.ProductReview.ProductReviewEditViewModel>
    {
        public Edit()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 3 "..\..\Views\ProductReview\Edit.cshtml"
  
    Layout = MVC.Shared.Views.SiteLayout.Panel._PanelLayout;
    ViewBag.Title = Admin.EditReview;

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteLiteral(" class=\"dashboard-content\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"headline buttons primary\"");

WriteLiteral(">\r\n        <h4>");

            
            #line 9 "..\..\Views\ProductReview\Edit.cshtml"
       Write(Admin.EditReview);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"form-box-item profile-form\"");

WriteLiteral(">\r\n        <form");

WriteLiteral(" id=\"editProductReview\"");

WriteAttribute("action", Tuple.Create(" action=\"", 442), Tuple.Create("\"", 488)
            
            #line 12 "..\..\Views\ProductReview\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 451), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.ProductReview.Edit())
            
            #line default
            #line hidden
, 451), false)
);

WriteLiteral(" method=\"Post\"");

WriteLiteral("  data-on-load=\"validateProductReview\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 13 "..\..\Views\ProductReview\Edit.cshtml"
       Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 14 "..\..\Views\ProductReview\Edit.cshtml"
       Write(Html.ValidationSummary());

            
            #line default
            #line hidden
WriteLiteral("\r\n            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"Id\"");

WriteLiteral(" name=\"Id\"");

WriteAttribute("value", Tuple.Create(" value=\"", 671), Tuple.Create("\"", 688)
            
            #line 15 "..\..\Views\ProductReview\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 679), Tuple.Create<System.Object, System.Int32>(Model.Id
            
            #line default
            #line hidden
, 679), false)
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

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">");

            
            #line 30 "..\..\Views\ProductReview\Edit.cshtml"
                                       Write(Admin.Title);

            
            #line default
            #line hidden
WriteLiteral(" : ");

            
            #line 30 "..\..\Views\ProductReview\Edit.cshtml"
                                                      Write(Model.ProductTitle);

            
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

WriteLiteral(" clas=\"input-container fixed-height\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"IsActive\"");

WriteLiteral(" class=\"rl-label tooltipster\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1913), Tuple.Create("\"", 1954)
            
            #line 43 "..\..\Views\ProductReview\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1921), Tuple.Create<System.Object, System.Int32>(Admin.ItActivesOrDeactivesReview
            
            #line default
            #line hidden
, 1921), false)
);

WriteLiteral(">");

            
            #line 43 "..\..\Views\ProductReview\Edit.cshtml"
                                                                                                            Write(Admin.Status);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                    <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" id=\"IsActive\"");

WriteLiteral(" name=\"IsActive\"");

WriteLiteral(" value=\"true\"");

WriteAttribute("checked", Tuple.Create(" checked=\"", 2064), Tuple.Create("\"", 2089)
            
            #line 44 "..\..\Views\ProductReview\Edit.cshtml"
               , Tuple.Create(Tuple.Create("", 2074), Tuple.Create<System.Object, System.Int32>(Model.IsActive
            
            #line default
            #line hidden
, 2074), false)
);

WriteLiteral("/>\r\n                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"IsActive\"");

WriteLiteral(" value=\"false\"");

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

WriteAttribute("title", Tuple.Create(" title=\"", 2730), Tuple.Create("\"", 2762)
            
            #line 58 "..\..\Views\ProductReview\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2738), Tuple.Create<System.Object, System.Int32>(Admin.ItShowsReviewText
            
            #line default
            #line hidden
, 2738), false)
);

WriteLiteral(">");

            
            #line 58 "..\..\Views\ProductReview\Edit.cshtml"
                                                                                               Write(Admin.ReviewText);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                    <span");

WriteLiteral(" class=\"field-validation-error\"");

WriteLiteral(" data-valmsg-for=\"Body\"");

WriteLiteral(" data-valmsg-replace=\"true\"");

WriteLiteral("></span>\r\n                    <textarea");

WriteLiteral(" id=\"Body\"");

WriteLiteral(" name=\"Body\"");

WriteLiteral(" data-on-load=\"editorProductReview\"");

WriteLiteral(" data-val=\"true\"");

WriteLiteral(" data-val-required=\"");

            
            #line 60 "..\..\Views\ProductReview\Edit.cshtml"
                                                                                                                     Write(Admin.RequiredExplain);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">");

            
            #line 60 "..\..\Views\ProductReview\Edit.cshtml"
                                                                                                                                             Write(Model.Body);

            
            #line default
            #line hidden
WriteLiteral("</textarea>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"input-container\"");

WriteLiteral("></div>\r\n            </div>\r\n        </form>\r\n        \r\n        <div");

WriteLiteral(" class=\"form-button-container\"");

WriteLiteral(">\r\n            <button");

WriteLiteral(" form=\"editProductReview\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"form-button right-form-btn ok-button round-corners-five disabled-btn-link" +
"\"");

WriteLiteral(" disabled=\"disabled\"");

WriteLiteral(" >\r\n                <i");

WriteLiteral(" class=\"fa fa-save\"");

WriteLiteral("></i>\r\n                <span>");

            
            #line 70 "..\..\Views\ProductReview\Edit.cshtml"
                 Write(Admin.Save);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            </button>\r\n        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591