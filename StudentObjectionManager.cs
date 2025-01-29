
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
    public partial class StudentObjectionManager
    {

        /// <summary>
        /// Get all StudentObjection
        /// </summary>
        /// <returns>List<StudentObjection></returns>
        public static List<StudentObjection> GetAll(long studentSysCode)
        {
            return StudentObjectionDB.GetAll(studentSysCode);
        }
    }
}
