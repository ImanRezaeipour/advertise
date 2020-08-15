using System.Threading.Tasks;

namespace Advertise.Service.Validators.Categories
{
    public interface ICategoryValidator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryAlias"></param>
        /// <param name="slug"></param>
        /// <returns></returns>
        Task DetailValidationAsync(string categoryAlias ,string slug, string viewName = null, string actionName = null);
    }
}