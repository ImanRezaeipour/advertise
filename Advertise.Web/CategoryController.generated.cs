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
namespace Advertise.Web.Controllers
{
    public partial class CategoryController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected CategoryController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult BreadCrumb()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.BreadCrumb);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> DeleteAjax()
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.DeleteAjax);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Detail()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Detail);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Edit()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> GetCategoriesAjax()
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetCategoriesAjax);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> GetFileAjax()
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetFileAjax);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> GetRelatedCategoriesAjax()
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetRelatedCategoriesAjax);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> GetSubCatergoriesWithRootAjax()
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetSubCatergoriesWithRootAjax);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> List()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.List);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public CategoryController Actions { get { return MVC.Category; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Category";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Category";
        [GeneratedCode("T4MVC", "2.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string BreadCrumb = "BreadCrumb";
            public readonly string Create = "Create";
            public readonly string DeleteAjax = "DeleteAjax";
            public readonly string Detail = "Detail";
            public readonly string Edit = "Edit";
            public readonly string GetCategoriesAjax = "GetCategoriesAjax";
            public readonly string GetFileAjax = "GetFileAjax";
            public readonly string GetMainCategoriesAjax = "GetMainCategoriesAjax";
            public readonly string GetRelatedCategoriesAjax = "GetRelatedCategoriesAjax";
            public readonly string GetSubCatergoriesWithRootAjax = "GetSubCatergoriesWithRootAjax";
            public readonly string GetTreeAjax = "GetTreeAjax";
            public readonly string List = "List";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string BreadCrumb = "BreadCrumb";
            public const string Create = "Create";
            public const string DeleteAjax = "DeleteAjax";
            public const string Detail = "Detail";
            public const string Edit = "Edit";
            public const string GetCategoriesAjax = "GetCategoriesAjax";
            public const string GetFileAjax = "GetFileAjax";
            public const string GetMainCategoriesAjax = "GetMainCategoriesAjax";
            public const string GetRelatedCategoriesAjax = "GetRelatedCategoriesAjax";
            public const string GetSubCatergoriesWithRootAjax = "GetSubCatergoriesWithRootAjax";
            public const string GetTreeAjax = "GetTreeAjax";
            public const string List = "List";
        }


        static readonly ActionParamsClass_BreadCrumb s_params_BreadCrumb = new ActionParamsClass_BreadCrumb();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_BreadCrumb BreadCrumbParams { get { return s_params_BreadCrumb; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_BreadCrumb
        {
            public readonly string categoryId = "categoryId";
            public readonly string currentTitle = "currentTitle";
            public readonly string isAllSearch = "isAllSearch";
        }
        static readonly ActionParamsClass_Create s_params_Create = new ActionParamsClass_Create();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Create CreateParams { get { return s_params_Create; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Create
        {
            public readonly string viewModel = "viewModel";
        }
        static readonly ActionParamsClass_DeleteAjax s_params_DeleteAjax = new ActionParamsClass_DeleteAjax();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_DeleteAjax DeleteAjaxParams { get { return s_params_DeleteAjax; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_DeleteAjax
        {
            public readonly string code = "code";
        }
        static readonly ActionParamsClass_Detail s_params_Detail = new ActionParamsClass_Detail();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Detail DetailParams { get { return s_params_Detail; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Detail
        {
            public readonly string alias = "alias";
            public readonly string slug = "slug";
        }
        static readonly ActionParamsClass_Edit s_params_Edit = new ActionParamsClass_Edit();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Edit EditParams { get { return s_params_Edit; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Edit
        {
            public readonly string alias = "alias";
            public readonly string viewModel = "viewModel";
        }
        static readonly ActionParamsClass_GetCategoriesAjax s_params_GetCategoriesAjax = new ActionParamsClass_GetCategoriesAjax();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetCategoriesAjax GetCategoriesAjaxParams { get { return s_params_GetCategoriesAjax; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetCategoriesAjax
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_GetFileAjax s_params_GetFileAjax = new ActionParamsClass_GetFileAjax();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetFileAjax GetFileAjaxParams { get { return s_params_GetFileAjax; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetFileAjax
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_GetRelatedCategoriesAjax s_params_GetRelatedCategoriesAjax = new ActionParamsClass_GetRelatedCategoriesAjax();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetRelatedCategoriesAjax GetRelatedCategoriesAjaxParams { get { return s_params_GetRelatedCategoriesAjax; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetRelatedCategoriesAjax
        {
            public readonly string alias = "alias";
        }
        static readonly ActionParamsClass_GetSubCatergoriesWithRootAjax s_params_GetSubCatergoriesWithRootAjax = new ActionParamsClass_GetSubCatergoriesWithRootAjax();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetSubCatergoriesWithRootAjax GetSubCatergoriesWithRootAjaxParams { get { return s_params_GetSubCatergoriesWithRootAjax; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetSubCatergoriesWithRootAjax
        {
            public readonly string id = "id";
        }
        static readonly ActionParamsClass_List s_params_List = new ActionParamsClass_List();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_List ListParams { get { return s_params_List; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_List
        {
            public readonly string request = "request";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string _AddItem = "_AddItem";
                public readonly string _BreadCrumb = "_BreadCrumb";
                public readonly string _CompanyItemList = "_CompanyItemList";
                public readonly string _Item = "_Item";
                public readonly string _ListMore = "_ListMore";
                public readonly string _ProductItemList = "_ProductItemList";
                public readonly string Create = "Create";
                public readonly string Detail = "Detail";
                public readonly string Edit = "Edit";
                public readonly string List = "List";
            }
            public readonly string _AddItem = "~/Views/Category/_AddItem.cshtml";
            public readonly string _BreadCrumb = "~/Views/Category/_BreadCrumb.cshtml";
            public readonly string _CompanyItemList = "~/Views/Category/_CompanyItemList.cshtml";
            public readonly string _Item = "~/Views/Category/_Item.cshtml";
            public readonly string _ListMore = "~/Views/Category/_ListMore.cshtml";
            public readonly string _ProductItemList = "~/Views/Category/_ProductItemList.cshtml";
            public readonly string Create = "~/Views/Category/Create.cshtml";
            public readonly string Detail = "~/Views/Category/Detail.cshtml";
            public readonly string Edit = "~/Views/Category/Edit.cshtml";
            public readonly string List = "~/Views/Category/List.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_CategoryController : Advertise.Web.Controllers.CategoryController
    {
        public T4MVC_CategoryController() : base(Dummy.Instance) { }

        [NonAction]
        partial void BreadCrumbOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, System.Guid? categoryId, string currentTitle, bool? isAllSearch);

        [NonAction]
        public override System.Web.Mvc.ActionResult BreadCrumb(System.Guid? categoryId, string currentTitle, bool? isAllSearch)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.BreadCrumb);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "categoryId", categoryId);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "currentTitle", currentTitle);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "isAllSearch", isAllSearch);
            BreadCrumbOverride(callInfo, categoryId, currentTitle, isAllSearch);
            return callInfo;
        }

        [NonAction]
        partial void CreateOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Advertise.Core.Models.Category.CategoryCreateViewModel viewModel);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Create(Advertise.Core.Models.Category.CategoryCreateViewModel viewModel)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Create);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "viewModel", viewModel);
            CreateOverride(callInfo, viewModel);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void CreateOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Create()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Create);
            CreateOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void DeleteAjaxOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, string code);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> DeleteAjax(string code)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.DeleteAjax);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "code", code);
            DeleteAjaxOverride(callInfo, code);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }

        [NonAction]
        partial void DetailOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string alias, string slug);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Detail(string alias, string slug)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Detail);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "alias", alias);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "slug", slug);
            DetailOverride(callInfo, alias, slug);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void EditOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string alias);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Edit(string alias)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "alias", alias);
            EditOverride(callInfo, alias);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void EditOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Advertise.Core.Models.Category.CategoryEditViewModel viewModel);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Edit(Advertise.Core.Models.Category.CategoryEditViewModel viewModel)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Edit);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "viewModel", viewModel);
            EditOverride(callInfo, viewModel);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void GetCategoriesAjaxOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, System.Guid? id);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> GetCategoriesAjax(System.Guid? id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetCategoriesAjax);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            GetCategoriesAjaxOverride(callInfo, id);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }

        [NonAction]
        partial void GetFileAjaxOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, System.Guid? id);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> GetFileAjax(System.Guid? id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetFileAjax);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            GetFileAjaxOverride(callInfo, id);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }

        [NonAction]
        partial void GetMainCategoriesAjaxOverride(T4MVC_System_Web_Mvc_JsonResult callInfo);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> GetMainCategoriesAjax()
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetMainCategoriesAjax);
            GetMainCategoriesAjaxOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }

        [NonAction]
        partial void GetRelatedCategoriesAjaxOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, string alias);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> GetRelatedCategoriesAjax(string alias)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetRelatedCategoriesAjax);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "alias", alias);
            GetRelatedCategoriesAjaxOverride(callInfo, alias);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }

        [NonAction]
        partial void GetSubCatergoriesWithRootAjaxOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, System.Guid? id);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> GetSubCatergoriesWithRootAjax(System.Guid? id)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetSubCatergoriesWithRootAjax);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "id", id);
            GetSubCatergoriesWithRootAjaxOverride(callInfo, id);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }

        [NonAction]
        partial void GetTreeAjaxOverride(T4MVC_System_Web_Mvc_JsonResult callInfo);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> GetTreeAjax()
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.GetTreeAjax);
            GetTreeAjaxOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }

        [NonAction]
        partial void ListOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Advertise.Core.Models.Category.CategorySearchRequest request);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> List(Advertise.Core.Models.Category.CategorySearchRequest request)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.List);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "request", request);
            ListOverride(callInfo, request);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
