using System.Threading.Tasks;
using System.Web;
using Advertise.Core.Exceptions;
using Advertise.Core.Models.Company;
using Advertise.Service.Services.Companies;
using Advertise.Service.Services.WebContext;

namespace Advertise.Service.Validators.Companies
{

    public class CompanyValidator 
    {
        #region Private Fields

        private readonly ICompanyService _companyService;
        private readonly IWebContextManager _webContextManager;
        private readonly ICompanyReserveService _companyReserveService;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        ///
        /// </summary>
        /// <param name="companyService"></param>
        public CompanyValidator(ICompanyService companyService, IWebContextManager webContextManager, ICompanyReserveService companyReserveService)
        {
            _companyService = companyService;
            _webContextManager = webContextManager;
            _companyReserveService = companyReserveService;
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewModel"></param>
        /// <param name="viewName"></param>
        /// <param name="actionName"></param>
        /// <returns></returns>
        public async Task EditValidationAsync(CompanyEditViewModel viewModel,string viewName = null, string actionName = null)
        {
            var isExistAlias = await _companyReserveService.IsExistByAlias(viewModel.Alias);
            if (isExistAlias)
                throw new ValidationException("این ساب دومین وجود دارد", viewName, actionName);

          

        }

        #endregion Public Methods
    }
}