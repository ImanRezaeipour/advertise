using System.Threading.Tasks;
using Advertise.Core.Models.Company;

namespace Advertise.Service.Validators.Companies
{
    public interface ICompanyValidator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="viewModel"></param>
        /// <param name="viewName"></param>
        /// <param name="actionName"></param>
        /// <returns></returns>
        Task EditValidationAsync(CompanyEditViewModel viewModel, string viewName = null, string actionName = null);
    }
}