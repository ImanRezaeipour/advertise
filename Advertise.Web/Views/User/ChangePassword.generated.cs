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

namespace Advertise.Web.Views.User
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/User/ChangePassword.cshtml")]
    public partial class ChangePassword : Advertise.Web.Framework.ViewEngines.Razor.WebViewPage<Advertise.Core.Models.User.UserChangePasswordViewModel>
    {
        public ChangePassword()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 3 "..\..\Views\User\ChangePassword.cshtml"
  
    Layout = MVC.Shared.Views.SiteLayout.Profile._ProfileLayout;
    ViewBag.Title = Admin.ChangePassWord;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"dashboard-content\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"headline buttons primary\"");

WriteLiteral(">\r\n        <h4>");

            
            #line 9 "..\..\Views\User\ChangePassword.cshtml"
       Write(Admin.ChangePassWord);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"form-box-item profile-form\"");

WriteLiteral(">\r\n        <form");

WriteLiteral(" id=\"editUser\"");

WriteAttribute("action", Tuple.Create(" action=\"", 433), Tuple.Create("\"", 483)
            
            #line 12 "..\..\Views\User\ChangePassword.cshtml"
, Tuple.Create(Tuple.Create("", 442), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Account.ChangePassword())
            
            #line default
            #line hidden
, 442), false)
);

WriteLiteral(" method=\"Post\"");

WriteLiteral(" data-on-load=\"validateChangePassWord\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 13 "..\..\Views\User\ChangePassword.cshtml"
       Write(Html.AntiForgeryToken());

            
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

WriteLiteral(" for=\"OldPassword\"");

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">");

            
            #line 28 "..\..\Views\User\ChangePassword.cshtml"
                                                         Write(Admin.PreviousPassword);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                    <input");

WriteLiteral(" type=\"password\"");

WriteLiteral(" id=\"OldPassword\"");

WriteLiteral(" name=\"OldPassword\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" class=\"form-control tooltipster\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1357), Tuple.Create("\"", 1395)
            
            #line 29 "..\..\Views\User\ChangePassword.cshtml"
                                                , Tuple.Create(Tuple.Create("", 1365), Tuple.Create<System.Object, System.Int32>(Admin.ItShowsPasswordPrevious
            
            #line default
            #line hidden
, 1365), false)
);

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 1396), Tuple.Create("\"", 1433)
            
            #line 29 "..\..\Views\User\ChangePassword.cshtml"
                                                                                             , Tuple.Create(Tuple.Create("", 1410), Tuple.Create<System.Object, System.Int32>(Admin.PreviousPassword
            
            #line default
            #line hidden
, 1410), false)
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

WriteLiteral(" for=\"NewPassword\"");

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">");

            
            #line 42 "..\..\Views\User\ChangePassword.cshtml"
                                                         Write(Admin.NewPassword);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                    <input");

WriteLiteral(" type=\"password\"");

WriteLiteral(" id=\"NewPassword\"");

WriteLiteral(" name=\"NewPassword\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" class=\"form-control tooltipster\"");

WriteAttribute("title", Tuple.Create(" title=\"", 2144), Tuple.Create("\"", 2177)
            
            #line 43 "..\..\Views\User\ChangePassword.cshtml"
                                                , Tuple.Create(Tuple.Create("", 2152), Tuple.Create<System.Object, System.Int32>(Admin.ItShowsPasswordNew
            
            #line default
            #line hidden
, 2152), false)
);

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 2178), Tuple.Create("\"", 2210)
            
            #line 43 "..\..\Views\User\ChangePassword.cshtml"
                                                                                        , Tuple.Create(Tuple.Create("", 2192), Tuple.Create<System.Object, System.Int32>(Admin.NewPassword
            
            #line default
            #line hidden
, 2192), false)
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

WriteLiteral(" for=\"ConfirmPassword\"");

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">");

            
            #line 56 "..\..\Views\User\ChangePassword.cshtml"
                                                             Write(Admin.NewPasswordRepeat);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                    <input");

WriteLiteral(" type=\"password\"");

WriteLiteral(" id=\"ConfirmPassword\"");

WriteLiteral(" name=\"ConfirmPassword\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" class=\"form-control tooltipster\"");

WriteAttribute("title", Tuple.Create(" title=\"", 2939), Tuple.Create("\"", 2975)
            
            #line 57 "..\..\Views\User\ChangePassword.cshtml"
                                                        , Tuple.Create(Tuple.Create("", 2947), Tuple.Create<System.Object, System.Int32>(Admin.ItShowsPasswordRepeat
            
            #line default
            #line hidden
, 2947), false)
);

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 2976), Tuple.Create("\"", 3014)
            
            #line 57 "..\..\Views\User\ChangePassword.cshtml"
                                                                                                   , Tuple.Create(Tuple.Create("", 2990), Tuple.Create<System.Object, System.Int32>(Admin.NewPasswordRepeat
            
            #line default
            #line hidden
, 2990), false)
);

WriteLiteral("/>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"input-container\"");

WriteLiteral("></div>\r\n            </div>\r\n        </form>\r\n        \r\n        <div");

WriteLiteral(" class=\"form-button-container\"");

WriteLiteral(">\r\n            <button");

WriteLiteral(" form=\"editUser\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"form-button right-form-btn ok-button round-corners-five disabled-btn-link" +
"\"");

WriteLiteral(" disabled=\"disabled\"");

WriteLiteral(" >\r\n                <i");

WriteLiteral(" class=\"fa fa-save\"");

WriteLiteral("></i>\r\n                <span>");

            
            #line 67 "..\..\Views\User\ChangePassword.cshtml"
                 Write(Admin.Save);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            </button>\r\n        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591