
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.IO;
using BusinessObjects;
using DataLayer;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Caching;

namespace BusinessLayer
{
    public partial class ProgrammeManager
    {
        /// <summary>
        /// Get For Drop Down List
        /// </summary>
        /// <param name="programmeId"></param>
        /// <returns></returns>
        public static Dictionary<string, string> BindForDropDownList(int postId)
        {
            return ProgrammeDB.BindForDropDownList(postId);
        }
    }
}
