using Advertise.Core.Exceptions;
using Advertise.Service.Services.Categories;
using Advertise.Service.Services.Seo;
using System.Threading.Tasks;

namespace Advertise.Service.Validators.Categories
{

    public class CategoryValidator : ICategoryValidator
    {
        #region Private Fields

        private readonly ICategoryService _categoryService;
        private readonly ISeoService _seoService;

        #endregion Private Fields

        #region Public Constructors

        ///  <summary>
        /// 
        ///  </summary>
        ///  <param name="seoService"></param>
        /// <param name="categoryService"></param>
        public CategoryValidator(ISeoService seoService, ICategoryService categoryService)
        {
            _seoService = seoService;
            _categoryService = categoryService;
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        ///
        /// </summary>
        /// <param name="categoryAlias"></param>
        /// <param name="slug"></param>
        /// <returns></returns>
        public async Task DetailValidationAsync(string categoryAlias, string slug, string viewName = null, string actionName = null)
        {
            var seoExist = await _seoService.IsExistCategoryByIdAsync(categoryAlias);
            if (seoExist)
                throw new ValidationException("Category is modified.", viewName, actionName);

            var slugResult = await _categoryService.IsCompareNameAndSlugAsync(categoryAlias, slug);
            if (!slugResult)
                throw new ValidationException("عدم تطابق اسلاگ", viewName, actionName);
        }

        #endregion Public Methods
    }
}