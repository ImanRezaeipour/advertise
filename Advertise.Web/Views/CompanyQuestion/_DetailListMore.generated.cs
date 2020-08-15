﻿using Advertise.Service.Managers.File;

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

namespace Advertise.Web.Views.CompanyQuestion
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
    
    #line 2 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
    using Advertise.Core.Extensions;
    
    #line default
    #line hidden
    using Advertise.Core.Languages;
    
    #line 3 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
#line default
    #line hidden
    using Advertise.Web;
    using Advertise.Web.Framework.ViewEngines.Razor;
    using Advertise.Web.Views.Shared.SiteLayout;
    using MvcSiteMapProvider.Web.Html;
    using MvcSiteMapProvider.Web.Html.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CompanyQuestion/_DetailListMore.cshtml")]
    public partial class _DetailListMore : Advertise.Web.Framework.ViewEngines.Razor.WebViewPage<Advertise.Core.Models.CompanyQuestion.CompanyQuestionListViewModel>
    {
        public _DetailListMore()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 5 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
  var index = 0;
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 6 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
 foreach (var item in Model.CompanyQuestions)
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 278), Tuple.Create("\"", 358)
, Tuple.Create(Tuple.Create("", 286), Tuple.Create("comment-wrap-each", 286), true)
, Tuple.Create(Tuple.Create(" ", 303), Tuple.Create<System.Object, System.Int32>(new System.Web.WebPages.HelperResult(__razor_attribute_value_writer => {

            
            #line 8 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
                                   if(item.ReplyId != null) {
            
            #line default
            #line hidden
WriteLiteralTo(__razor_attribute_value_writer, "reply-answer");

            
            #line 8 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
                                                                                      }
            
            #line default
            #line hidden
}), 304), false)
, Tuple.Create(Tuple.Create(" ", 357), Tuple.Create("", 357), true)
);

WriteLiteral(" data-index=\"");

            
            #line 8 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
                                                                                                 Write(index);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 392), Tuple.Create("\"", 446)
            
            #line 9 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
, Tuple.Create(Tuple.Create("", 399), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.User.Detail(item.UserUserName))
            
            #line default
            #line hidden
, 399), false)
);

WriteLiteral(">\r\n            <figure");

WriteLiteral(" class=\"user-avatar medium\"");

WriteLiteral(">\r\n");

            
            #line 11 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
                
            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
                 if (item.UserAvatar != null)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"product-detail company-logo\"");

WriteLiteral(">\r\n                        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 656), Tuple.Create("\"", 712)
            
            #line 14 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
, Tuple.Create(Tuple.Create("", 662), Tuple.Create<System.Object, System.Int32>(FileConst.ImagesWebPath.PlusWord(item.UserAvatar)
            
            #line default
            #line hidden
, 662), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 713), Tuple.Create("\"", 729)
            
            #line 14 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
            , Tuple.Create(Tuple.Create("", 719), Tuple.Create<System.Object, System.Int32>(item.Body
            
            #line default
            #line hidden
, 719), false)
);

WriteLiteral(">\r\n                    </div>\r\n");

            
            #line 16 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"product-detail company-logo\"");

WriteLiteral(">\r\n                        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 912), Tuple.Create("\"", 935)
            
            #line 20 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
, Tuple.Create(Tuple.Create("", 918), Tuple.Create<System.Object, System.Int32>(FileConst.NoLogo
            
            #line default
            #line hidden
, 918), false)
);

WriteLiteral(" alt=\"store without logo\"");

WriteLiteral(">\r\n                    </div>\r\n");

            
            #line 22 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </figure>\r\n        </a>\r\n        <div");

WriteLiteral(" class=\"comment\"");

WriteLiteral(">\r\n            <p");

WriteLiteral(" class=\"text-header\"");

WriteLiteral(">");

            
            #line 26 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
                              Write(item.UserFullName);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n            <p");

WriteLiteral(" class=\"timestamp\"");

WriteLiteral(">");

            
            #line 27 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
                            Write(item.CreatedOn.CastToRegularDate());

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n            <p>");

            
            #line 28 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
          Write(item.Body);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 29 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
            
            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
             if (item.IsMyself && item.ReplyId == null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <input");

WriteLiteral(" type=\"text\"");

WriteAttribute("id", Tuple.Create(" id=\"", 1349), Tuple.Create("\"", 1369)
, Tuple.Create(Tuple.Create("", 1354), Tuple.Create("Question_", 1354), true)
            
            #line 31 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
, Tuple.Create(Tuple.Create("", 1363), Tuple.Create<System.Object, System.Int32>(index
            
            #line default
            #line hidden
, 1363), false)
);

WriteAttribute("name", Tuple.Create(" name=\"", 1370), Tuple.Create("\"", 1393)
, Tuple.Create(Tuple.Create("", 1377), Tuple.Create("Question[", 1377), true)
            
            #line 31 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
, Tuple.Create(Tuple.Create("", 1386), Tuple.Create<System.Object, System.Int32>(index
            
            #line default
            #line hidden
, 1386), false)
, Tuple.Create(Tuple.Create("", 1392), Tuple.Create("]", 1392), true)
);

WriteLiteral(" placeholder=\"پاسخ دهید\"");

WriteLiteral(" />\r\n");

WriteLiteral("                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"button primary\"");

WriteAttribute("id", Tuple.Create(" id=\"", 1483), Tuple.Create("\"", 1502)
, Tuple.Create(Tuple.Create("", 1488), Tuple.Create("ReplyId_", 1488), true)
            
            #line 32 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
, Tuple.Create(Tuple.Create("", 1496), Tuple.Create<System.Object, System.Int32>(index
            
            #line default
            #line hidden
, 1496), false)
);

WriteAttribute("name", Tuple.Create(" name=\"", 1503), Tuple.Create("\"", 1525)
, Tuple.Create(Tuple.Create("", 1510), Tuple.Create("ReplyId[", 1510), true)
            
            #line 32 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
               , Tuple.Create(Tuple.Create("", 1518), Tuple.Create<System.Object, System.Int32>(index
            
            #line default
            #line hidden
, 1518), false)
, Tuple.Create(Tuple.Create("", 1524), Tuple.Create("]", 1524), true)
);

WriteAttribute("value", Tuple.Create(" value=\"", 1526), Tuple.Create("\"", 1542)
            
            #line 32 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
                               , Tuple.Create(Tuple.Create("", 1534), Tuple.Create<System.Object, System.Int32>(item.Id
            
            #line default
            #line hidden
, 1534), false)
);

WriteLiteral(" data-on-click=\"ajaxReplyToQuestion\"");

WriteLiteral(">پاسخ دادن</button>\r\n");

            
            #line 33 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n    </div>\r\n");

WriteLiteral("    <hr");

WriteLiteral(" class=\"line-separator\"");

WriteLiteral(">\r\n");

            
            #line 37 "..\..\Views\CompanyQuestion\_DetailListMore.cshtml"
    index = index + 1;
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
