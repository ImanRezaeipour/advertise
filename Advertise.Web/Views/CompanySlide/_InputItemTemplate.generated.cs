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
    using Advertise.Web;
    using Advertise.Web.Framework.ViewEngines.Razor;
    using Advertise.Web.Views.Shared.SiteLayout;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CompanySlide/_InputItemTemplate.cshtml")]
    public partial class _InputItemTemplate : Advertise.Web.Framework.ViewEngines.Razor.WebViewPage<dynamic>
    {
        public _InputItemTemplate()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"input-form hide-none-imp\"");

WriteLiteral(" data-index=\"*\"");

WriteLiteral(">\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"SlideList[*].Index\"");

WriteLiteral(" value=\"*\"");

WriteLiteral(" />\r\n\r\n    <div");

WriteLiteral(" class=\"vertical-dashed\"");

WriteLiteral("></div>\r\n\r\n    <div");

WriteLiteral(" class=\"msg-container\"");

WriteLiteral(">\r\n        <p");

WriteLiteral(" class=\"msg-box regular round-corners-five\"");

WriteLiteral("></p>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"input-container fixed-height\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" for=\"SlideList_*_.Title\"");

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">\r\n            <span>");

            
            #line 12 "..\..\Views\CompanySlide\_InputItemTemplate.cshtml"
             Write(Admin.Title);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </label>\r\n        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"SlideList_*_.Title\"");

WriteLiteral(" name=\"SlideList[*].Title\"");

WriteLiteral(" />\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"msg-container\"");

WriteLiteral(">\r\n        <p");

WriteLiteral(" class=\"msg-box regular round-corners-five\"");

WriteLiteral("></p>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"input-container fixed-height\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" for=\"SlideList_*_.ImageFileName\"");

WriteLiteral(" class=\"rl-label tooltipster\"");

WriteAttribute("title", Tuple.Create(" title=\"", 810), Tuple.Create("\"", 839)
            
            #line 21 "..\..\Views\CompanySlide\_InputItemTemplate.cshtml"
     , Tuple.Create(Tuple.Create("", 818), Tuple.Create<System.Object, System.Int32>(Admin.ItChoosesImage
            
            #line default
            #line hidden
, 818), false)
);

WriteLiteral(">");

            
            #line 21 "..\..\Views\CompanySlide\_InputItemTemplate.cshtml"
                                                                                                      Write(Admin.UploadAdPhoto);

            
            #line default
            #line hidden
WriteLiteral(" :</label>\r\n");

WriteLiteral("        ");

            
            #line 22 "..\..\Views\CompanySlide\_InputItemTemplate.cshtml"
   Write(Html.Partial(MVC.Shared.Views.FineUploaderTemplates._FineUploaderTemplate));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" id=\"SlideList_*_.ImageFileName\"");

WriteLiteral(" name=\"SlideList[*].ImageFileName\"");

WriteLiteral(" ");

WriteLiteral(" data-param=\"create\"></div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"msg-container\"");

WriteLiteral(">\r\n        <p");

WriteLiteral(" class=\"msg-box regular round-corners-five\"");

WriteLiteral("></p>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"input-container fixed-height\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" for=\"SlideList_*_.ProductId\"");

WriteLiteral(" class=\"rl-label\"");

WriteLiteral(">محصولات</label>\r\n        <select");

WriteLiteral(" id=\"SlideList_*_.ProductId\"");

WriteLiteral(" name=\"SlideList[*].ProductId\"");

WriteLiteral(">\r\n            <option selected disabled>-- ");

            
            #line 32 "..\..\Views\CompanySlide\_InputItemTemplate.cshtml"
                                    Write(Admin.Choose);

            
            #line default
            #line hidden
WriteLiteral(" --</option>\r\n");

            
            #line 33 "..\..\Views\CompanySlide\_InputItemTemplate.cshtml"
                
            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\CompanySlide\_InputItemTemplate.cshtml"
                 foreach (var product in Model.ProductList)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1601), Tuple.Create("\"", 1623)
            
            #line 35 "..\..\Views\CompanySlide\_InputItemTemplate.cshtml"
, Tuple.Create(Tuple.Create("", 1609), Tuple.Create<System.Object, System.Int32>(product.Value
            
            #line default
            #line hidden
, 1609), false)
);

WriteAttribute("selected", Tuple.Create(" selected=\"", 1624), Tuple.Create("\"", 1651)
            
            #line 35 "..\..\Views\CompanySlide\_InputItemTemplate.cshtml"
, Tuple.Create(Tuple.Create("", 1635), Tuple.Create<System.Object, System.Int32>(product.Value
            
            #line default
            #line hidden
, 1635), false)
);

WriteLiteral(">");

            
            #line 35 "..\..\Views\CompanySlide\_InputItemTemplate.cshtml"
                                                                          Write(product.Text);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 36 "..\..\Views\CompanySlide\_InputItemTemplate.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            <option>-- هیچکدام --</option>\r\n        </select>\r\n    </div>\r\n</div>" +
"");

        }
    }
}
#pragma warning restore 1591
