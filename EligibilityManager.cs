
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
    public partial class EligibilityManager
    {

        /// <summary>
        /// Get all Eligibility
        /// </summary>
        /// <returns>List<Eligibility></returns>
        public static List<Eligibility> GetAllWithCourse(int courseSysCode)
        {
            return EligibilityDB.GetAllWithCourse(courseSysCode);
        }
    }
}
