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

namespace Advertise.Web.Views.Bag
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
    
    #line 2 "..\..\Views\Bag\Edit.cshtml"
    using Advertise.Core.Extensions;
    
    #line default
    #line hidden
    using Advertise.Core.Languages;
    using Advertise.Web;
    using Advertise.Web.Framework.ViewEngines.Razor;
    using Advertise.Web.Views.Shared.SiteLayout;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Bag/Edit.cshtml")]
    public partial class Edit : Advertise.Web.Framework.ViewEngines.Razor.WebViewPage<Advertise.Core.Models.Bag.BagMyInfoViewModel>
    {
        public Edit()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 4 "..\..\Views\Bag\Edit.cshtml"
  
    Layout = MVC.Shared.Views.SiteLayout.Panel._PanelLayout;
    ViewBag.Title = Admin.ProfileEdit;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("scripts", () => {

WriteLiteral("\r\n    <script async defer");

WriteLiteral(" src=\'https://maps.googleapis.com/maps/api/js?key=AIzaSyDsVAy5ATsGkBA11NPQWSakpy0" +
"BiNuBPTc&callback=mapSet\'");

WriteLiteral("></script>\r\n");

});

WriteLiteral("<div");

WriteLiteral(" class=\"dashboard-content\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"headline buttons primary\"");

WriteLiteral(">\r\n        <h4>");

            
            #line 13 "..\..\Views\Bag\Edit.cshtml"
       Write(Admin.ProfileEdit);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"form-box-item profile-form\"");

WriteLiteral(">\r\n        <form");

WriteLiteral(" id=\"editInfo\"");

WriteAttribute("action", Tuple.Create(" action=\"", 611), Tuple.Create("\"", 647)
            
            #line 16 "..\..\Views\Bag\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 620), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Bag.Edit())
            
            #line default
            #line hidden
, 620), false)
);

WriteLiteral(" method=\"post\"");

WriteLiteral(" data-on-load=\"validateBag\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 17 "..\..\Views\Bag\Edit.cshtml"
       Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
WriteLiteral("\r\n            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"CreatedById\"");

WriteLiteral(" name=\"CreatedById\"");

WriteAttribute("value", Tuple.Create(" value=\"", 798), Tuple.Create("\"", 824)
            
            #line 18 "..\..\Views\Bag\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 806), Tuple.Create<System.Object, System.Int32>(Model.CreatedById
            
            #line default
            #line hidden
, 806), false)
);

WriteLiteral(" />\r\n\r\n            <div");

WriteLiteral(" class=\"input-form\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"vertical-dashed\"");

WriteLiteral("></div>\r\n\r\n                <div");

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

WriteLiteral(">\r\n                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"Address_Longitude\"");

WriteLiteral(" name=\"Address.Longitude\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1467), Tuple.Create("\"", 1512)
            
            #line 33 "..\..\Views\Bag\Edit.cshtml"
                , Tuple.Create(Tuple.Create("", 1475), Tuple.Create<System.Object, System.Int32>(Model.Address.Longitude.ZeroIfNull()
            
            #line default
            #line hidden
, 1475), false)
);

WriteLiteral(" />\r\n                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"Address_Latitude\"");

WriteLiteral(" name=\"Address.Latitude\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1604), Tuple.Create("\"", 1648)
            
            #line 34 "..\..\Views\Bag\Edit.cshtml"
              , Tuple.Create(Tuple.Create("", 1612), Tuple.Create<System.Object, System.Int32>(Model.Address.Latitude.ZeroIfNull()
            
            #line default
            #line hidden
, 1612), false)
);

WriteLiteral(" />\r\n                    <div");

WriteLiteral(" id=\"setMap\"");

WriteLiteral("></div>\r\n                </div>\r\n\r\n                <div");

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

WriteLiteral(" for=\"province\"");

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">");

            
            #line 48 "..\..\Views\Bag\Edit.cshtml"
                                                      Write(Admin.Province);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"ProvinceId\"");

WriteLiteral(" id=\"ProvinceId\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" />\r\n                    <select");

WriteLiteral(" id=\"province\"");

WriteLiteral(" name=\"province\"");

WriteLiteral(" data-on-change=\"ajaxSelectProvince\"");

WriteLiteral(">\r\n                        <option");

WriteLiteral(" value=\"\"");

WriteLiteral(" selected disabled>-- ");

            
            #line 51 "..\..\Views\Bag\Edit.cshtml"
                                                         Write(Admin.Choose);

            
            #line default
            #line hidden
WriteLiteral(" --</option>\r\n");

            
            #line 52 "..\..\Views\Bag\Edit.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 52 "..\..\Views\Bag\Edit.cshtml"
                         foreach (var province in Model.AddressProvince)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <option");

WriteAttribute("value", Tuple.Create(" value=\"", 2672), Tuple.Create("\"", 2695)
            
            #line 54 "..\..\Views\Bag\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 2680), Tuple.Create<System.Object, System.Int32>(province.Value
            
            #line default
            #line hidden
, 2680), false)
);

WriteLiteral(">");

            
            #line 54 "..\..\Views\Bag\Edit.cshtml"
                                                       Write(province.Text);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 55 "..\..\Views\Bag\Edit.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </select>\r\n                </div>\r\n\r\n                <div");

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

WriteLiteral(" for=\"city\"");

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">");

            
            #line 69 "..\..\Views\Bag\Edit.cshtml"
                                                  Write(Admin.City);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"CityId\"");

WriteLiteral(" id=\"CityId\"");

WriteLiteral(" value=\"\"");

WriteLiteral(" />\r\n                    <select");

WriteLiteral(" id=\"city\"");

WriteLiteral(" name=\"city\"");

WriteLiteral(" data-on-load=\"ajaxSelectCity\"");

WriteLiteral(">\r\n                        <option");

WriteLiteral(" value=\"\"");

WriteLiteral(">-- ");

            
            #line 72 "..\..\Views\Bag\Edit.cshtml"
                                       Write(Admin.Choose);

            
            #line default
            #line hidden
WriteLiteral(" --</option>\r\n                    </select>\r\n                </div>\r\n\r\n          " +
"      <div");

WriteLiteral(" class=\"msg-container\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"msg-box regular round-corners-five\"");

WriteLiteral(">\r\n                        <p>\r\n                            <i");

WriteLiteral(" class=\"fa fa-quote-right\"");

WriteLiteral("></i>\r\n                            <span></span>\r\n                            <i");

WriteLiteral(" class=\"fa fa-quote-left\"");

WriteLiteral("></i>\r\n                        </p>\r\n                    </div>\r\n                " +
"</div>\r\n                <div");

WriteLiteral(" class=\"input-container fixed-height address-area\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" for=\"address\"");

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">");

            
            #line 86 "..\..\Views\Bag\Edit.cshtml"
                                                     Write(Admin.Address);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                    <textarea");

WriteLiteral(" rows=\"2\"");

WriteLiteral(" id=\"address\"");

WriteLiteral(" name=\"address\"");

WriteLiteral(" class=\"info-address-textarea\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 4271), Tuple.Create("\"", 4299)
            
            #line 87 "..\..\Views\Bag\Edit.cshtml"
                              , Tuple.Create(Tuple.Create("", 4285), Tuple.Create<System.Object, System.Int32>(Admin.Address
            
            #line default
            #line hidden
, 4285), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 4300), Tuple.Create("\"", 4326)
            
            #line 87 "..\..\Views\Bag\Edit.cshtml"
                                                     , Tuple.Create(Tuple.Create("", 4308), Tuple.Create<System.Object, System.Int32>(Model.UserAddress
            
            #line default
            #line hidden
, 4308), false)
);

WriteLiteral("></textarea>\r\n                </div>\r\n\r\n                <div");

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

WriteLiteral(" for=\"postalCode\"");

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">");

            
            #line 100 "..\..\Views\Bag\Edit.cshtml"
                                                        Write(Admin.PostalCode);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                    <input");

WriteLiteral(" type=\"number\"");

WriteLiteral(" id=\"postalCode\"");

WriteLiteral(" name=\"postalCode\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 4983), Tuple.Create("\"", 5021)
            
            #line 101 "..\..\Views\Bag\Edit.cshtml"
        , Tuple.Create(Tuple.Create("", 4997), Tuple.Create<System.Object, System.Int32>(Admin.ExamplePostalCode
            
            #line default
            #line hidden
, 4997), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 5022), Tuple.Create("\"", 5047)
            
            #line 101 "..\..\Views\Bag\Edit.cshtml"
                                         , Tuple.Create(Tuple.Create("", 5030), Tuple.Create<System.Object, System.Int32>(Model.PostalCode
            
            #line default
            #line hidden
, 5030), false)
);

WriteLiteral(" />\r\n                </div>\r\n\r\n                <div");

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

WriteLiteral(" for=\"firstName\"");

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">");

            
            #line 114 "..\..\Views\Bag\Edit.cshtml"
                                                       Write(Admin.FirstName);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                    <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"firstName\"");

WriteLiteral(" name=\"firstName\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 5689), Tuple.Create("\"", 5719)
            
            #line 115 "..\..\Views\Bag\Edit.cshtml"
    , Tuple.Create(Tuple.Create("", 5703), Tuple.Create<System.Object, System.Int32>(Admin.FirstName
            
            #line default
            #line hidden
, 5703), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 5720), Tuple.Create("\"", 5748)
            
            #line 115 "..\..\Views\Bag\Edit.cshtml"
                             , Tuple.Create(Tuple.Create("", 5728), Tuple.Create<System.Object, System.Int32>(Model.UserFirstName
            
            #line default
            #line hidden
, 5728), false)
);

WriteLiteral(" />\r\n                </div>\r\n\r\n                <div");

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

WriteLiteral(" for=\"lastName\"");

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">");

            
            #line 128 "..\..\Views\Bag\Edit.cshtml"
                                                      Write(Admin.LastName);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                    <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"lastName\"");

WriteLiteral(" name=\"lastName\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 6386), Tuple.Create("\"", 6415)
            
            #line 129 "..\..\Views\Bag\Edit.cshtml"
  , Tuple.Create(Tuple.Create("", 6400), Tuple.Create<System.Object, System.Int32>(Admin.LastName
            
            #line default
            #line hidden
, 6400), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 6416), Tuple.Create("\"", 6443)
            
            #line 129 "..\..\Views\Bag\Edit.cshtml"
                          , Tuple.Create(Tuple.Create("", 6424), Tuple.Create<System.Object, System.Int32>(Model.UserLastName
            
            #line default
            #line hidden
, 6424), false)
);

WriteLiteral(" />\r\n                </div>\r\n\r\n                <div");

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

WriteLiteral(" for=\"nationalCode\"");

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">");

            
            #line 142 "..\..\Views\Bag\Edit.cshtml"
                                                          Write(Admin.NationalCode);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                    <input");

WriteLiteral(" type=\"number\"");

WriteLiteral(" id=\"nationalCode\"");

WriteLiteral(" name=\"nationalCode\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 7099), Tuple.Create("\"", 7139)
            
            #line 143 "..\..\Views\Bag\Edit.cshtml"
            , Tuple.Create(Tuple.Create("", 7113), Tuple.Create<System.Object, System.Int32>(Admin.ExampleNationalCode
            
            #line default
            #line hidden
, 7113), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 7140), Tuple.Create("\"", 7171)
            
            #line 143 "..\..\Views\Bag\Edit.cshtml"
                                               , Tuple.Create(Tuple.Create("", 7148), Tuple.Create<System.Object, System.Int32>(Model.UserNationalCode
            
            #line default
            #line hidden
, 7148), false)
);

WriteLiteral(" />\r\n                </div>\r\n\r\n                <div");

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

WriteLiteral(" for=\"phoneNumber\"");

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">");

            
            #line 156 "..\..\Views\Bag\Edit.cshtml"
                                                         Write(Admin.Phone);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                    <input");

WriteLiteral(" type=\"number\"");

WriteLiteral(" id=\"phoneNumber\"");

WriteLiteral(" name=\"phoneNumber\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 7817), Tuple.Create("\"", 7856)
            
            #line 157 "..\..\Views\Bag\Edit.cshtml"
          , Tuple.Create(Tuple.Create("", 7831), Tuple.Create<System.Object, System.Int32>(Admin.ExamplePhoneNumber
            
            #line default
            #line hidden
, 7831), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 7857), Tuple.Create("\"", 7883)
            
            #line 157 "..\..\Views\Bag\Edit.cshtml"
                                            , Tuple.Create(Tuple.Create("", 7865), Tuple.Create<System.Object, System.Int32>(Model.PhoneNumber
            
            #line default
            #line hidden
, 7865), false)
);

WriteLiteral(" />\r\n                </div>\r\n\r\n                <div");

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

WriteLiteral(" for=\"mobileNumber\"");

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">");

            
            #line 170 "..\..\Views\Bag\Edit.cshtml"
                                                          Write(Admin.Mobile);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                    <input");

WriteLiteral(" type=\"number\"");

WriteLiteral(" id=\"mobileNumber\"");

WriteLiteral(" name=\"mobileNumber\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 8533), Tuple.Create("\"", 8573)
            
            #line 171 "..\..\Views\Bag\Edit.cshtml"
            , Tuple.Create(Tuple.Create("", 8547), Tuple.Create<System.Object, System.Int32>(Admin.ExampleMobileNumber
            
            #line default
            #line hidden
, 8547), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 8574), Tuple.Create("\"", 8601)
            
            #line 171 "..\..\Views\Bag\Edit.cshtml"
                                               , Tuple.Create(Tuple.Create("", 8582), Tuple.Create<System.Object, System.Int32>(Model.MobileNumber
            
            #line default
            #line hidden
, 8582), false)
);

WriteLiteral(" />\r\n                </div>\r\n\r\n                <div");

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

WriteLiteral(" for=\"transfereeName\"");

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">");

            
            #line 184 "..\..\Views\Bag\Edit.cshtml"
                                                            Write(Admin.TransfereeName.PlusWord(" (").PlusWord(Admin.Optional).PlusWord(")"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                    <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"transfereeName\"");

WriteLiteral(" name=\"transfereeName\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 9317), Tuple.Create("\"", 9352)
            
            #line 185 "..\..\Views\Bag\Edit.cshtml"
              , Tuple.Create(Tuple.Create("", 9331), Tuple.Create<System.Object, System.Int32>(Admin.TransfereeName
            
            #line default
            #line hidden
, 9331), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 9353), Tuple.Create("\"", 9382)
            
            #line 185 "..\..\Views\Bag\Edit.cshtml"
                                            , Tuple.Create(Tuple.Create("", 9361), Tuple.Create<System.Object, System.Int32>(Model.TransfereeName
            
            #line default
            #line hidden
, 9361), false)
);

WriteLiteral(" />\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"msg-container\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"msg-box regular round-corners-five\"");

WriteLiteral(">\r\n                        <p>\r\n                            <i");

WriteLiteral(" class=\"fa fa-quote-right\"");

WriteLiteral("></i>\r\n                            <span></span>\r\n                            <i");

WriteLiteral(" class=\"fa fa-quote-left\"");

WriteLiteral("></i>\r\n                        </p>\r\n                    </div>\r\n                " +
"</div>\r\n                <div");

WriteLiteral(" class=\"input-container fixed-height payment-wrapper\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">");

            
            #line 198 "..\..\Views\Bag\Edit.cshtml"
                                       Write(Admin.PaymentType);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                    <ul");

WriteLiteral(" class=\"payment-holder\"");

WriteLiteral(">\r\n                        <li");

WriteLiteral(" class=\"payment-label-list\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" for=\"paymentType1\"");

WriteLiteral(" class=\"payment-label\"");

WriteLiteral(">\r\n                                <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" id=\"paymentType1\"");

WriteLiteral(" name=\"Payment\"");

WriteLiteral(" value=\"1\"");

WriteLiteral(" checked>\r\n                                <span>");

            
            #line 203 "..\..\Views\Bag\Edit.cshtml"
                                 Write(Admin.OnlinePayment);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                            </label>\r\n                        </li>\r\n   " +
"                     <li");

WriteLiteral(" class=\"payment-label-list\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" for=\"paymentType2\"");

WriteLiteral(" class=\"payment-label\"");

WriteLiteral(">\r\n                                <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" id=\"paymentType2\"");

WriteLiteral(" name=\"Payment\"");

WriteLiteral(" value=\"2\"");

WriteLiteral(">\r\n                                <span>");

            
            #line 209 "..\..\Views\Bag\Edit.cshtml"
                                 Write(Admin.PayInPerson);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                            </label>\r\n                        </li>\r\n   " +
"                     <li");

WriteLiteral(" class=\"payment-label-list\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" for=\"paymentType3\"");

WriteLiteral(" class=\"payment-label\"");

WriteLiteral(">\r\n                                <input");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" id=\"paymentType3\"");

WriteLiteral(" name=\"Payment\"");

WriteLiteral(" value=\"3\"");

WriteLiteral(">\r\n                                <span>");

            
            #line 215 "..\..\Views\Bag\Edit.cshtml"
                                 Write(Admin.PaymentViaATM);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                            </label>\r\n                        </li>\r\n   " +
"                 </ul>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"input-container\"");

WriteLiteral("></div>\r\n            </div>\r\n        </form>\r\n\r\n        <div");

WriteLiteral(" class=\"form-button-container\"");

WriteLiteral(">\r\n            <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" form=\"editInfo\"");

WriteLiteral(" class=\"form-button right-form-btn ok-button round-corners-five disabled-btn-link" +
"\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"fa fa-save\"");

WriteLiteral("></i>\r\n                <span>");

            
            #line 228 "..\..\Views\Bag\Edit.cshtml"
                 Write(Admin.Save);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            </button>\r\n        </div>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
