using System;
using System.Collections.Generic;
using Advertise.Core.Domains.Categories;
using Advertise.Core.Domains.Common;
using Advertise.Core.Domains.Users;
using Advertise.Core.Types;

namespace Advertise.Core.Domains.Adses
{
    public class Ads : BaseEntity
    {
        /// <summary>
        ///     عنوان بنر
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        ///     نام عکس بنر
        /// </summary>
        public virtual string ImageFileName { get; set; }

        /// <summary>
        ///     (نام انتیتی مربوط به بنر (دسته‌بندی، کمپانی یا محصول
        /// </summary>
        public virtual string EntityName { get; set; }

        /// <summary>
        ///     (کدشناسایی بنر مربوط به آدرس دهی (نام مستعار دسته‌بندی، نام مستعار کمپانی یا کد محصول
        /// </summary>
        public virtual Guid? EntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Guid? TargetId { get; set; }
        
        /// <summary>
        ///     مشخص می‌کند که آیا نوبت به بنر رسیده‌است یا خیر
        /// </summary>
        public virtual bool? IsApprove { get; set; }

        /// <summary>
        ///     مدت زمان رزرو هر بنر در سایت
        /// </summary>
        public virtual DurationType? DurationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual decimal? FinalPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual int? Order { get; set; }
        
        /// <summary>
        /// </summary>
        public virtual User Owner { get; set; }
        
        /// <summary>
        /// </summary>
        public virtual Guid? OwnerId { get; set; }

        /// <summary>
        /// </summary>
        public virtual AdsOption AdsOption { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid? AdsOptionId { get; set; }

        /// <summary>
        /// </summary>
        public virtual Category Category { get; set; }

        /// <summary>
        /// </summary>
        public virtual Guid? CategoryId { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<AdsPayment> Payments { get; set; }

        /// <summary>
        /// </summary>
        public virtual ICollection<AdsReserve> Reserves { get; set; }
    }
}