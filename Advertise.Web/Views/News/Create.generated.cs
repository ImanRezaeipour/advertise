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
    using Advertise.Core.Languages;
    using Advertise.Web;
    using Advertise.Web.Framework.ViewEngines.Razor;
    using Advertise.Web.Views.Shared.SiteLayout;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/News/Create.cshtml")]
    public partial class Create : Advertise.Web.Framework.ViewEngines.Razor.WebViewPage<Advertise.Core.Models.News.NewsCreateViewModel>
    {
        public Create()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 3 "..\..\Views\News\Create.cshtml"
  
    Layout = MVC.Shared.Views.SiteLayout.Panel._PanelLayout;
    ViewBag.Title = Admin.CreateNews;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"dashboard-content\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"headline buttons primary\"");

WriteLiteral(">\r\n        <h4>");

            
            #line 9 "..\..\Views\News\Create.cshtml"
       Write(Admin.CreateNews);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"form-box-item profile-form\"");

WriteLiteral(">\r\n        <form");

WriteLiteral(" id=\"newNews\"");

WriteAttribute("action", Tuple.Create(" action=\"", 412), Tuple.Create("\"", 451)
            
            #line 12 "..\..\Views\News\Create.cshtml"
, Tuple.Create(Tuple.Create("", 421), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.News.Create())
            
            #line default
            #line hidden
, 421), false)
);

WriteLiteral(" method=\"Post\"");

WriteLiteral(" data-on-load=\"validateNews\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 13 "..\..\Views\News\Create.cshtml"
       Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 14 "..\..\Views\News\Create.cshtml"
       Write(Html.ValidationSummary());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n            <div");

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

            
            #line 29 "..\..\Views\News\Create.cshtml"
                                                   Write(Admin.Title);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                    <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"Title\"");

WriteLiteral(" name=\"Title\"");

WriteLiteral(" class=\"form-control tooltipster\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 1312), Tuple.Create("\"", 1338)
            
            #line 30 "..\..\Views\News\Create.cshtml"
                             , Tuple.Create(Tuple.Create("", 1326), Tuple.Create<System.Object, System.Int32>(Admin.Title
            
            #line default
            #line hidden
, 1326), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 1339), Tuple.Create("\"", 1370)
            
            #line 30 "..\..\Views\News\Create.cshtml"
                                                  , Tuple.Create(Tuple.Create("", 1347), Tuple.Create<System.Object, System.Int32>(Admin.ItShowsNewsTitle
            
            #line default
            #line hidden
, 1347), false)
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

WriteAttribute("title", Tuple.Create(" title=\"", 1937), Tuple.Create("\"", 1967)
            
            #line 43 "..\..\Views\News\Create.cshtml"
, Tuple.Create(Tuple.Create("", 1945), Tuple.Create<System.Object, System.Int32>(Admin.ItShowsNewsText
            
            #line default
            #line hidden
, 1945), false)
);

WriteLiteral(">");

            
            #line 43 "..\..\Views\News\Create.cshtml"
                                                                                             Write(Admin.FullExplanation);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                    <textarea");

WriteLiteral(" id=\"Body\"");

WriteLiteral(" name=\"Body\"");

WriteLiteral(" data-on-load=\"editorNews\"");

WriteLiteral("></textarea>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"input-container\"");

WriteLiteral("></div>\r\n            </div>\r\n        </form>\r\n        \r\n        <div");

WriteLiteral(" class=\"form-button-container\"");

WriteLiteral(">\r\n            <button");

WriteLiteral(" form=\"newNews\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"form-button right-form-btn ok-button round-corners-five disabled-btn-link" +
"\"");

WriteLiteral(" disabled=\"disabled\"");

WriteLiteral(" >\r\n                <i");

WriteLiteral(" class=\"fa fa-save\"");

WriteLiteral("></i>\r\n                <span>");

            
            #line 54 "..\..\Views\News\Create.cshtml"
                 Write(Admin.Save);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            </button>\r\n        </div>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
