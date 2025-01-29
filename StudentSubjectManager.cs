
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
    public partial class StudentSubjectManager
    {
        public static string InsertAll(long studentSysCode,string subjectIds)
        {
            return StudentSubjectDB.InsertAll(studentSysCode, subjectIds);
        }

    }
}
