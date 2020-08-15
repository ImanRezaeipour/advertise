using Advertise.Core.Exceptions;
using Advertise.Service.Services.Companies;
using System;
using System.Threading.Tasks;

namespace Advertise.Service.Validators.Companies
{

    public class CompanyImageValidator : ICompanyImageValidator
    {
        #region Private Fields

        private ICompanyImageService _companyImageService;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        ///
        /// </summary>
        /// <param name="companyImageService"></param>
        public CompanyImageValidator(ICompanyImageService companyImageService)
        {
            _companyImageService = companyImageService;
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        ///
        /// </summary>
        /// <param name="companyImageId"></param>
        /// <param name="viewName"></param>
        /// <param name="actionName"></param>
        /// <returns></returns>
        public async Task MyDeleteAjaxValidation(Guid companyImageId, string viewName = null, string actionName = null)
        {
            var isMine = await _companyImageService.IsMineAsync(companyImageId);
            if (!isMine)
                throw new ValidationException("عدم دسترسی");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="companyImageId"></param>
        /// <param name="viewName"></param>
        /// <param name="actionName"></param>
        /// <returns></returns>
        public async Task MyEditValidation(Guid companyImageId, string viewName = null, string actionName = null)
        {
            var isMine = await _companyImageService.IsMineAsync(companyImageId);
            if (!isMine)
                throw new ValidationException("عدم دسترسی");
        }


        #endregion Public Methods
    }
}