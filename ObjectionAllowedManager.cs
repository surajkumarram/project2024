
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
    public partial class ObjectionAllowedManager
    {
        public static ObjectionAllowed GetByStudentSysCode(long studentSysCode)
        {

            ObjectionAllowed objection;
            if (cache.Contains("ObjectionAllowed_BYS_" + studentSysCode.ToString()))
            {
                objection = (ObjectionAllowed)cache.GetData("ObjectionAllowed_BYS_" + studentSysCode.ToString());
            }
            else
            {
                objection = new ObjectionAllowed();
                objection.StudentSysCode = studentSysCode;
                ObjectionAllowedDB.GetByStudentSysCode(objection);
                cache.Add("ObjectionAllowed_BYS_" + objection.StudentSysCode.ToString(), objection);
            }

            return objection;

        }

    }
}
