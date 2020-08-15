using System;
using System.Threading.Tasks;

namespace Advertise.Service.Validators.Companies
{
    public interface ICompanyAttachmentValidator
    {
        Task IsMineAsync(Guid id, string viewName = null, string actionName = null);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <param name="viewName"></param>
        /// <param name="actionName"></param>
        /// <returns></returns>
        Task MyDeleteAjaxValidation(Guid id, string viewName = null, string actionName = null);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="viewName"></param>
        /// <param name="actionName"></param>
        /// <returns></returns>
        Task MyEditValidation(Guid id, string viewName = null, string actionName = null);
    }
}