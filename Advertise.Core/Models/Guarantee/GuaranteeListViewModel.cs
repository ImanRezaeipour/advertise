using System.Collections.Generic;
using Advertise.Core.Models.Common;
using Advertise.Core.Models.Email;
using Advertise.Core.Types;

namespace Advertise.Core.Models.Guarantee
{
    public class GuaranteeListViewModel : BaseViewModel
    {

        public IEnumerable<GuaranteeViewModel> Guarantees { get;set;}
        public IEnumerable<SelectListItem> PageSizeList { get; set; }
        public GuaranteeSearchRequest SearchRequest { get; set; }
        public IEnumerable<SelectListItem> SortDirectionList { get; set; }

        public IEnumerable<SelectListItem> SortMemberList { get; set; }
    }
}