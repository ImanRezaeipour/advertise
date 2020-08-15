﻿using Advertise.Core.Models.Common;
using System.Collections.Generic;

namespace Advertise.Core.Models.SpecificationOption
{

    public class SpecificationOptionListViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// لیست اعداد برای نمایش در هر صفحه
        /// </summary>
        public IEnumerable<SelectListItem> PageSizeList { get; set; }

        public SpecificationOptionSearchRequest SearchRequest { get; set; }

        /// <summary>
        /// جهت
        /// </summary>
        public IEnumerable<SelectListItem> SortDirectionList { get; set; }

        /// <summary>
        /// لیست فیلد هایی که برای مرتب سازی استفاده خواهند شد
        /// </summary>
        public IEnumerable<SelectListItem> SortMemberList { get; set; }

        public IEnumerable<SelectListItem> SpecificationList { get; set; }
        public IEnumerable<SpecificationOptionViewModel> SpecificationOptions { get; set; }

        #endregion Public Properties
    }
}