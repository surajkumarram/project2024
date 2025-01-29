
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
    public partial class UserManager
    {

        /// <summary>
        /// Validaing User From DataBase
        /// </summary>
        /// <param name="userName">userName</param>
        /// <returns>User Object</returns>
        public static User ValidateUser(string userName)
        {
            return UserDB.ValidateUser(userName);
        }
    }
}
