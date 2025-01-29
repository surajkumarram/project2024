
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
    public partial class AdminUserManager
    {
        /// <summary>
        /// Validaing User From DataBase
        /// </summary>
        /// <param name="userName">userName</param>
        /// <returns>User Object</returns>
        public static AdminUser ValidateUser(string userName)
        {
            return AdminUserDB.ValidateUser(userName);
        }

    }
}
