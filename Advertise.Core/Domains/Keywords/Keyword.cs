using System;
using System.Collections.Generic;
using Advertise.Core.Domains.Common;
using Advertise.Core.Domains.Products;
using Advertise.Core.Domains.Users;

namespace Advertise.Core.Domains.Keywords
{
    /// <summary>
    /// 
    /// </summary>
    public class Keyword : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool IsActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual ICollection<ProductKeyword> ProductKeywords { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual Guid? CreatedById { get; set; }
    }
}
