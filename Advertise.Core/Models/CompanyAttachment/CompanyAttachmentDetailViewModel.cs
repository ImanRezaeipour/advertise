using Advertise.Core.Models.Common;
using Advertise.Core.Types;
using System;
using System.Collections.Generic;
using Advertise.Core.Models.CompanyAttachmentFile;
using Advertise.Core.Languages;

namespace Advertise.Core.Models.CompanyAttachment
{

    public class CompanyAttachmentDetailViewModel : BaseViewModel
    {
        #region Public Properties
        
        /// <summary>
        /// </summary>
        public Guid Id { get; set; }

        public int Order { get; set; }

        /// <summary>
        /// توضیح برای عدم تائید
        /// </summary>
        public string RejectDescription { get; set; }

        /// <summary>
        ///تائید یا عدم تائید
        /// </summary>
        public StateType State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Title { get; set; }
        
        /// <summary>
        /// </summary>
        public bool IsMyself { get; set; }

        public IEnumerable<CompanyAttachmentFileViewModel> Files { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CompanyLogo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CompanyAlias { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public string CompanyTitle { get; set; }

        #endregion Public Properties
    }
}