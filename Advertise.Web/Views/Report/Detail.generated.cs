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

namespace ASP
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
    
    #line 1 "..\..\Views\Report\Detail.cshtml"
    using Stimulsoft.Report.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Report/Detail.cshtml")]
    public partial class _Views_Report_Detail_cshtml : Advertise.Web.Framework.ViewEngines.Razor.WebViewPage<dynamic>
    {
        public _Views_Report_Detail_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Report\Detail.cshtml"
  
    Layout = MVC.Shared.Views.SiteLayout.Panel._PanelLayout;
    ViewBag.Title = "نمایش گزارش";

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 6 "..\..\Views\Report\Detail.cshtml"
Write(Html.Stimulsoft().StiMvcViewer("ReportDetail", new StiMvcViewerOptions
{
    Actions =
    {
        GetReportSnapshot = "DetailReport",
        ViewerEvent = "DetailViewerEvent",
        ExportReport = "DetailExportReport",
        PrintReport = "DetailPrintReport",
        Interaction = "DetailInteraction",
        DesignReport = "",
        EmailReport = ""
    },
    Appearance =
    {
        RightToLeft = true,
        ScrollbarsMode = true,
        PageAlignment = StiContentAlignment.Center,
    },
    Server =
    {
        GlobalReportCache = false,
    },
    Localization = "~/Files/Localization/fa.xml",
    Theme = StiTheme.Default,
    Toolbar = new StiMvcViewerOptions.ToolbarOptions
    {
        ShowAboutButton = false,
    },
    Height = 700
}));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591