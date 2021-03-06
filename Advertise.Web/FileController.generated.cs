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
    public partial class FileController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected FileController(Dummy d) { }

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
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> CreateFromUploadAjax()
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.CreateFromUploadAjax);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> DeleteFromImageWebAjax()
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.DeleteFromImageWebAjax);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> DeleteFromUploadAjax()
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.DeleteFromUploadAjax);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.FileResult> GetFileFromThumb()
        {
            var callInfo = new T4MVC_System_Web_Mvc_FileResult(Area, Name, ActionNames.GetFileFromThumb);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.FileResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.FileResult> GetFileFromUpload()
        {
            var callInfo = new T4MVC_System_Web_Mvc_FileResult(Area, Name, ActionNames.GetFileFromUpload);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.FileResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> ListFromUploadAjax()
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.ListFromUploadAjax);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> SaveFromAttachmentAjax()
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.SaveFromAttachmentAjax);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> SaveFromImageWebAjax()
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.SaveFromImageWebAjax);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> SaveFromUploadAjax()
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.SaveFromUploadAjax);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> SaveFromUploaderAjax()
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.SaveFromUploaderAjax);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public FileController Actions { get { return MVC.File; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "File";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "File";
        [GeneratedCode("T4MVC", "2.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string CreateFromUploadAjax = "CreateFromUploadAjax";
            public readonly string DeleteFromImageWebAjax = "DeleteFromImageWebAjax";
            public readonly string DeleteFromUploadAjax = "DeleteFromUploadAjax";
            public readonly string GetFileFromThumb = "GetFileFromThumb";
            public readonly string GetFileFromUpload = "GetFileFromUpload";
            public readonly string ListFromUploadAjax = "ListFromUploadAjax";
            public readonly string RemoveAjax = "RemoveAjax";
            public readonly string SaveFromAttachmentAjax = "SaveFromAttachmentAjax";
            public readonly string SaveFromImageWebAjax = "SaveFromImageWebAjax";
            public readonly string SaveFromUploadAjax = "SaveFromUploadAjax";
            public readonly string SaveFromUploaderAjax = "SaveFromUploaderAjax";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string CreateFromUploadAjax = "CreateFromUploadAjax";
            public const string DeleteFromImageWebAjax = "DeleteFromImageWebAjax";
            public const string DeleteFromUploadAjax = "DeleteFromUploadAjax";
            public const string GetFileFromThumb = "GetFileFromThumb";
            public const string GetFileFromUpload = "GetFileFromUpload";
            public const string ListFromUploadAjax = "ListFromUploadAjax";
            public const string RemoveAjax = "RemoveAjax";
            public const string SaveFromAttachmentAjax = "SaveFromAttachmentAjax";
            public const string SaveFromImageWebAjax = "SaveFromImageWebAjax";
            public const string SaveFromUploadAjax = "SaveFromUploadAjax";
            public const string SaveFromUploaderAjax = "SaveFromUploaderAjax";
        }


        static readonly ActionParamsClass_CreateFromUploadAjax s_params_CreateFromUploadAjax = new ActionParamsClass_CreateFromUploadAjax();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_CreateFromUploadAjax CreateFromUploadAjaxParams { get { return s_params_CreateFromUploadAjax; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_CreateFromUploadAjax
        {
            public readonly string name = "name";
            public readonly string path = "path";
        }
        static readonly ActionParamsClass_DeleteFromImageWebAjax s_params_DeleteFromImageWebAjax = new ActionParamsClass_DeleteFromImageWebAjax();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_DeleteFromImageWebAjax DeleteFromImageWebAjaxParams { get { return s_params_DeleteFromImageWebAjax; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_DeleteFromImageWebAjax
        {
            public readonly string fileNames = "fileNames";
        }
        static readonly ActionParamsClass_DeleteFromUploadAjax s_params_DeleteFromUploadAjax = new ActionParamsClass_DeleteFromUploadAjax();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_DeleteFromUploadAjax DeleteFromUploadAjaxParams { get { return s_params_DeleteFromUploadAjax; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_DeleteFromUploadAjax
        {
            public readonly string fileNames = "fileNames";
        }
        static readonly ActionParamsClass_GetFileFromThumb s_params_GetFileFromThumb = new ActionParamsClass_GetFileFromThumb();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetFileFromThumb GetFileFromThumbParams { get { return s_params_GetFileFromThumb; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetFileFromThumb
        {
            public readonly string path = "path";
        }
        static readonly ActionParamsClass_GetFileFromUpload s_params_GetFileFromUpload = new ActionParamsClass_GetFileFromUpload();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_GetFileFromUpload GetFileFromUploadParams { get { return s_params_GetFileFromUpload; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_GetFileFromUpload
        {
            public readonly string path = "path";
        }
        static readonly ActionParamsClass_ListFromUploadAjax s_params_ListFromUploadAjax = new ActionParamsClass_ListFromUploadAjax();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ListFromUploadAjax ListFromUploadAjaxParams { get { return s_params_ListFromUploadAjax; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ListFromUploadAjax
        {
            public readonly string path = "path";
        }
        static readonly ActionParamsClass_SaveFromAttachmentAjax s_params_SaveFromAttachmentAjax = new ActionParamsClass_SaveFromAttachmentAjax();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SaveFromAttachmentAjax SaveFromAttachmentAjaxParams { get { return s_params_SaveFromAttachmentAjax; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SaveFromAttachmentAjax
        {
            public readonly string files = "files";
        }
        static readonly ActionParamsClass_SaveFromImageWebAjax s_params_SaveFromImageWebAjax = new ActionParamsClass_SaveFromImageWebAjax();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SaveFromImageWebAjax SaveFromImageWebAjaxParams { get { return s_params_SaveFromImageWebAjax; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SaveFromImageWebAjax
        {
            public readonly string files = "files";
        }
        static readonly ActionParamsClass_SaveFromUploadAjax s_params_SaveFromUploadAjax = new ActionParamsClass_SaveFromUploadAjax();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SaveFromUploadAjax SaveFromUploadAjaxParams { get { return s_params_SaveFromUploadAjax; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SaveFromUploadAjax
        {
            public readonly string files = "files";
        }
        static readonly ActionParamsClass_SaveFromUploaderAjax s_params_SaveFromUploaderAjax = new ActionParamsClass_SaveFromUploaderAjax();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SaveFromUploaderAjax SaveFromUploaderAjaxParams { get { return s_params_SaveFromUploaderAjax; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SaveFromUploaderAjax
        {
            public readonly string file = "file";
            public readonly string path = "path";
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
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_FileController : Advertise.Web.Controllers.FileController
    {
        public T4MVC_FileController() : base(Dummy.Instance) { }

        [NonAction]
        partial void CreateFromUploadAjaxOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, string name, string path);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> CreateFromUploadAjax(string name, string path)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.CreateFromUploadAjax);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "name", name);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "path", path);
            CreateFromUploadAjaxOverride(callInfo, name, path);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }

        [NonAction]
        partial void DeleteFromImageWebAjaxOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, string[] fileNames);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> DeleteFromImageWebAjax(string[] fileNames)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.DeleteFromImageWebAjax);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "fileNames", fileNames);
            DeleteFromImageWebAjaxOverride(callInfo, fileNames);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }

        [NonAction]
        partial void DeleteFromUploadAjaxOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, string[] fileNames);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> DeleteFromUploadAjax(string[] fileNames)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.DeleteFromUploadAjax);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "fileNames", fileNames);
            DeleteFromUploadAjaxOverride(callInfo, fileNames);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }

        [NonAction]
        partial void GetFileFromThumbOverride(T4MVC_System_Web_Mvc_FileResult callInfo, string path);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.FileResult> GetFileFromThumb(string path)
        {
            var callInfo = new T4MVC_System_Web_Mvc_FileResult(Area, Name, ActionNames.GetFileFromThumb);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "path", path);
            GetFileFromThumbOverride(callInfo, path);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.FileResult);
        }

        [NonAction]
        partial void GetFileFromUploadOverride(T4MVC_System_Web_Mvc_FileResult callInfo, string path);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.FileResult> GetFileFromUpload(string path)
        {
            var callInfo = new T4MVC_System_Web_Mvc_FileResult(Area, Name, ActionNames.GetFileFromUpload);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "path", path);
            GetFileFromUploadOverride(callInfo, path);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.FileResult);
        }

        [NonAction]
        partial void ListFromUploadAjaxOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, string path);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> ListFromUploadAjax(string path)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.ListFromUploadAjax);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "path", path);
            ListFromUploadAjaxOverride(callInfo, path);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }

        [NonAction]
        partial void RemoveAjaxOverride(T4MVC_System_Web_Mvc_JsonResult callInfo);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> RemoveAjax()
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.RemoveAjax);
            RemoveAjaxOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }

        [NonAction]
        partial void SaveFromAttachmentAjaxOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, System.Collections.Generic.IEnumerable<System.Web.HttpPostedFileBase> files);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> SaveFromAttachmentAjax(System.Collections.Generic.IEnumerable<System.Web.HttpPostedFileBase> files)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.SaveFromAttachmentAjax);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "files", files);
            SaveFromAttachmentAjaxOverride(callInfo, files);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }

        [NonAction]
        partial void SaveFromImageWebAjaxOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, System.Collections.Generic.IEnumerable<System.Web.HttpPostedFileBase> files);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> SaveFromImageWebAjax(System.Collections.Generic.IEnumerable<System.Web.HttpPostedFileBase> files)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.SaveFromImageWebAjax);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "files", files);
            SaveFromImageWebAjaxOverride(callInfo, files);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }

        [NonAction]
        partial void SaveFromUploadAjaxOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, System.Collections.Generic.IEnumerable<System.Web.HttpPostedFileBase> files);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> SaveFromUploadAjax(System.Collections.Generic.IEnumerable<System.Web.HttpPostedFileBase> files)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.SaveFromUploadAjax);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "files", files);
            SaveFromUploadAjaxOverride(callInfo, files);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }

        [NonAction]
        partial void SaveFromUploaderAjaxOverride(T4MVC_System_Web_Mvc_JsonResult callInfo, System.Web.HttpPostedFileBase file, string path);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.JsonResult> SaveFromUploaderAjax(System.Web.HttpPostedFileBase file, string path)
        {
            var callInfo = new T4MVC_System_Web_Mvc_JsonResult(Area, Name, ActionNames.SaveFromUploaderAjax);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "file", file);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "path", path);
            SaveFromUploaderAjaxOverride(callInfo, file, path);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.JsonResult);
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
