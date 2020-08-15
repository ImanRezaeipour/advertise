using System;
using System.Threading.Tasks;

namespace Advertise.Service.Validators.Companies
{
    public interface ICompanyImageValidator
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="companyImageId"></param>
        /// <param name="viewName"></param>
        /// <param name="actionName"></param>
        /// <returns></returns>
        Task MyDeleteAjaxValidation(Guid companyImageId, string viewName = null, string actionName = null);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="companyImageId"></param>
        /// <param name="viewName"></param>
        /// <param name="actionName"></param>
        /// <returns></returns>
        Task MyEditValidation(Guid companyImageId, string viewName = null, string actionName = null);
    }
}