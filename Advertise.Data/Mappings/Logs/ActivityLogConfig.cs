﻿using System.Data.Entity.ModelConfiguration;
using Advertise.Core.Domains.Logs;
using Advertise.Data.Mappings.Common;

namespace Advertise.Data.Mappings.Logs
{

    public class ActivityLogConfig : BaseConfig<ActivityLog>
    {
        /// <summary>
        /// </summary>
        public ActivityLogConfig()
        {
        }
    }
}