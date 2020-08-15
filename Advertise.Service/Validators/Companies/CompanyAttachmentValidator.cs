using Advertise.Core.Exceptions;
using Advertise.Service.Services.Companies;
using System;
using System.Threading.Tasks;

namespace Advertise.Service.Validators.Companies
{

    public class CompanyAttachmentValidator : ICompanyAttachmentValidator
    {
        #region Private Fields

        private readonly ICompanyAttachmentService _companyAttachmentService;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        ///
        /// </summary>
        /// <param name="companyAttachmentService"></param>
        public CompanyAttachmentValidator(ICompanyAttachmentService companyAttachmentService)
        {
            _companyAttachmentService = companyAttachmentService;
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <param name="viewName"></param>
        /// <param name="actionName"></param>
        /// <returns></returns>
        public async Task IsMineAsync(Guid id, string viewName = null, string actionName = null)
        {
            var result = await _companyAttachmentService.IsMineAsync(id);
            if (!result)
                throw new ValidationException("عدم دسترسی به این فایل");
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <param name="viewName"></param>
        /// <param name="actionName"></param>
        /// <returns></returns>
        public async Task MyDeleteAjaxValidation(Guid id, string viewName = null, string actionName = null)
        {
            var result = await _companyAttachmentService.IsMineAsync(id);
            if (!result)
                throw new ValidationException("عدم دسترسی به این فایل");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="viewName"></param>
        /// <param name="actionName"></param>
        /// <returns></returns>
        public async Task MyEditValidation(Guid id, string viewName = null, string actionName = null)
        {
            var result = await _companyAttachmentService.IsMineAsync(id);
            if (!result)
                throw new ValidationException("عدم دسترسی به این فایل");
        }

        #endregion Public Methods
    }
}