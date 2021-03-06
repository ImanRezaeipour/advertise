// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static partial class MVC
{
    public static Advertise.Web.Controllers.AccountController Account = new Advertise.Web.Controllers.T4MVC_AccountController();
    public static Advertise.Web.Controllers.AdsController Ads = new Advertise.Web.Controllers.T4MVC_AdsController();
    public static Advertise.Web.Controllers.AdsOptionController AdsOption = new Advertise.Web.Controllers.T4MVC_AdsOptionController();
    public static Advertise.Web.Controllers.AdsPaymentController AdsPayment = new Advertise.Web.Controllers.T4MVC_AdsPaymentController();
    public static Advertise.Web.Controllers.AdsReserveController AdsReserve = new Advertise.Web.Controllers.T4MVC_AdsReserveController();
    public static Advertise.Web.Controllers.BagController Bag = new Advertise.Web.Controllers.T4MVC_BagController();
    public static Advertise.Web.Controllers.BaseController Base = new Advertise.Web.Controllers.T4MVC_BaseController();
    public static Advertise.Web.Controllers.CatalogController Catalog = new Advertise.Web.Controllers.T4MVC_CatalogController();
    public static Advertise.Web.Controllers.CategoryController Category = new Advertise.Web.Controllers.T4MVC_CategoryController();
    public static Advertise.Web.Controllers.CategoryFollowController CategoryFollow = new Advertise.Web.Controllers.T4MVC_CategoryFollowController();
    public static Advertise.Web.Controllers.CategoryReviewController CategoryReview = new Advertise.Web.Controllers.T4MVC_CategoryReviewController();
    public static Advertise.Web.Controllers.CityController City = new Advertise.Web.Controllers.T4MVC_CityController();
    public static Advertise.Web.Controllers.CompanyAttachmentController CompanyAttachment = new Advertise.Web.Controllers.T4MVC_CompanyAttachmentController();
    public static Advertise.Web.Controllers.CompanyBalanceController CompanyBalance = new Advertise.Web.Controllers.T4MVC_CompanyBalanceController();
    public static Advertise.Web.Controllers.CompanyController Company = new Advertise.Web.Controllers.T4MVC_CompanyController();
    public static Advertise.Web.Controllers.CompanyConversationController CompanyConversation = new Advertise.Web.Controllers.T4MVC_CompanyConversationController();
    public static Advertise.Web.Controllers.CompanyFollowController CompanyFollow = new Advertise.Web.Controllers.T4MVC_CompanyFollowController();
    public static Advertise.Web.Controllers.CompanyHourController CompanyHour = new Advertise.Web.Controllers.T4MVC_CompanyHourController();
    public static Advertise.Web.Controllers.CompanyImageController CompanyImage = new Advertise.Web.Controllers.T4MVC_CompanyImageController();
    public static Advertise.Web.Controllers.CompanyQuestionController CompanyQuestion = new Advertise.Web.Controllers.T4MVC_CompanyQuestionController();
    public static Advertise.Web.Controllers.CompanyReviewController CompanyReview = new Advertise.Web.Controllers.T4MVC_CompanyReviewController();
    public static Advertise.Web.Controllers.CompanySlideController CompanySlide = new Advertise.Web.Controllers.T4MVC_CompanySlideController();
    public static Advertise.Web.Controllers.CompanySocialController CompanySocial = new Advertise.Web.Controllers.T4MVC_CompanySocialController();
    public static Advertise.Web.Controllers.CompanyTagController CompanyTag = new Advertise.Web.Controllers.T4MVC_CompanyTagController();
    public static Advertise.Web.Controllers.CompanyVideoController CompanyVideo = new Advertise.Web.Controllers.T4MVC_CompanyVideoController();
    public static Advertise.Web.Controllers.ComplaintController Complaint = new Advertise.Web.Controllers.T4MVC_ComplaintController();
    public static Advertise.Web.Controllers.ErrorController Error = new Advertise.Web.Controllers.T4MVC_ErrorController();
    public static Advertise.Web.Controllers.ExportController Export = new Advertise.Web.Controllers.T4MVC_ExportController();
    public static Advertise.Web.Controllers.FileController File = new Advertise.Web.Controllers.T4MVC_FileController();
    public static Advertise.Web.Controllers.FineUploaderController FineUploader = new Advertise.Web.Controllers.T4MVC_FineUploaderController();
    public static Advertise.Web.Controllers.GuaranteeController Guarantee = new Advertise.Web.Controllers.T4MVC_GuaranteeController();
    public static Advertise.Web.Controllers.HomeController Home = new Advertise.Web.Controllers.T4MVC_HomeController();
    public static Advertise.Web.Controllers.ImportController Import = new Advertise.Web.Controllers.T4MVC_ImportController();
    public static Advertise.Web.Controllers.ManufacturerController Manufacturer = new Advertise.Web.Controllers.T4MVC_ManufacturerController();
    public static Advertise.Web.Controllers.NewsController News = new Advertise.Web.Controllers.T4MVC_NewsController();
    public static Advertise.Web.Controllers.NewsletterController Newsletter = new Advertise.Web.Controllers.T4MVC_NewsletterController();
    public static Advertise.Web.Controllers.NotificationController Notification = new Advertise.Web.Controllers.T4MVC_NotificationController();
    public static Advertise.Web.Controllers.PageController Page = new Advertise.Web.Controllers.T4MVC_PageController();
    public static Advertise.Web.Controllers.PanelController Panel = new Advertise.Web.Controllers.T4MVC_PanelController();
    public static Advertise.Web.Controllers.PermissionController Permission = new Advertise.Web.Controllers.T4MVC_PermissionController();
    public static Advertise.Web.Controllers.PlanController Plan = new Advertise.Web.Controllers.T4MVC_PlanController();
    public static Advertise.Web.Controllers.PlanDiscountController PlanDiscount = new Advertise.Web.Controllers.T4MVC_PlanDiscountController();
    public static Advertise.Web.Controllers.PlanPaymentController PlanPayment = new Advertise.Web.Controllers.T4MVC_PlanPaymentController();
    public static Advertise.Web.Controllers.ProductCommentController ProductComment = new Advertise.Web.Controllers.T4MVC_ProductCommentController();
    public static Advertise.Web.Controllers.ProductController Product = new Advertise.Web.Controllers.T4MVC_ProductController();
    public static Advertise.Web.Controllers.ProductFeatureController ProductFeature = new Advertise.Web.Controllers.T4MVC_ProductFeatureController();
    public static Advertise.Web.Controllers.ProductImageController ProductImage = new Advertise.Web.Controllers.T4MVC_ProductImageController();
    public static Advertise.Web.Controllers.ProductLikeController ProductLike = new Advertise.Web.Controllers.T4MVC_ProductLikeController();
    public static Advertise.Web.Controllers.ProductNotifyController ProductNotify = new Advertise.Web.Controllers.T4MVC_ProductNotifyController();
    public static Advertise.Web.Controllers.ProductRateController ProductRate = new Advertise.Web.Controllers.T4MVC_ProductRateController();
    public static Advertise.Web.Controllers.ProductReviewController ProductReview = new Advertise.Web.Controllers.T4MVC_ProductReviewController();
    public static Advertise.Web.Controllers.ProductSpecificationController ProductSpecification = new Advertise.Web.Controllers.T4MVC_ProductSpecificationController();
    public static Advertise.Web.Controllers.ProductTagController ProductTag = new Advertise.Web.Controllers.T4MVC_ProductTagController();
    public static Advertise.Web.Controllers.ProfileController Profile = new Advertise.Web.Controllers.T4MVC_ProfileController();
    public static Advertise.Web.Controllers.ReceiptController Receipt = new Advertise.Web.Controllers.T4MVC_ReceiptController();
    public static Advertise.Web.Controllers.ReceiptOptionController ReceiptOption = new Advertise.Web.Controllers.T4MVC_ReceiptOptionController();
    public static Advertise.Web.Controllers.ReceiptPaymentController ReceiptPayment = new Advertise.Web.Controllers.T4MVC_ReceiptPaymentController();
    public static Advertise.Web.Controllers.ReportController Report = new Advertise.Web.Controllers.T4MVC_ReportController();
    public static Advertise.Web.Controllers.RoleController Role = new Advertise.Web.Controllers.T4MVC_RoleController();
    public static Advertise.Web.Controllers.SeoSettingController SeoSetting = new Advertise.Web.Controllers.T4MVC_SeoSettingController();
    public static Advertise.Web.Controllers.SeoUrlController SeoUrl = new Advertise.Web.Controllers.T4MVC_SeoUrlController();
    public static Advertise.Web.Controllers.SettingController Setting = new Advertise.Web.Controllers.T4MVC_SettingController();
    public static Advertise.Web.Controllers.SpecificationController Specification = new Advertise.Web.Controllers.T4MVC_SpecificationController();
    public static Advertise.Web.Controllers.SpecificationOptionController SpecificationOption = new Advertise.Web.Controllers.T4MVC_SpecificationOptionController();
    public static Advertise.Web.Controllers.StatisticController Statistic = new Advertise.Web.Controllers.T4MVC_StatisticController();
    public static Advertise.Web.Controllers.TagController Tag = new Advertise.Web.Controllers.T4MVC_TagController();
    public static Advertise.Web.Controllers.UserBudgetController UserBudget = new Advertise.Web.Controllers.T4MVC_UserBudgetController();
    public static Advertise.Web.Controllers.UserController User = new Advertise.Web.Controllers.T4MVC_UserController();
    public static Advertise.Web.Controllers.UserSettingController UserSetting = new Advertise.Web.Controllers.T4MVC_UserSettingController();
    public static Advertise.Web.Controllers.UserViolationController UserViolation = new Advertise.Web.Controllers.T4MVC_UserViolationController();
    public static T4MVC.CatalogSpecificationController CatalogSpecification = new T4MVC.CatalogSpecificationController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
}

#pragma warning disable 0436
namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}
#pragma warning restore 0436

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}
[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_JsonResult : System.Web.Mvc.JsonResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_JsonResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}
[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_FileResult : System.Web.Mvc.FileResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_FileResult(string area, string controller, string action, string protocol = null): base(" ")
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    protected override void WriteFile(System.Web.HttpResponseBase response) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}
[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_Advertise_Web_Framework_Results_CaptchaImageResult : Advertise.Web.Framework.Results.CaptchaImageResult, IT4MVCActionResult
{
    public T4MVC_Advertise_Web_Framework_Results_CaptchaImageResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114


