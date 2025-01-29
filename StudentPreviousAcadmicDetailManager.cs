
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
    public partial class StudentPreviousAcadmicDetailManager
    {
        /// <summary>
        /// Insertion Throug XML
        /// </summary>
        /// <param name="academicDetails"></param>
        /// <returns></returns>
        public static int InsertWithXML(string academicDetails, string expericence, string council, long userId, long studentSysCode, string sixMonth, string oneYear,string paperXML)
        {
            return StudentPreviousAcadmicDetailDB.InsertWithXML(academicDetails, expericence, council, userId, studentSysCode,  sixMonth,  oneYear, paperXML);
        }

        /// <summary>
        /// Get All Filled Details
        /// </summary>
        /// <param name="studentSysCode"></param>
        /// <returns></returns>
        public static DataSet GetAllFilledDetails(long studentSysCode, string courseIds)
        {
            return StudentPreviousAcadmicDetailDB.GetAllFilledDetails(studentSysCode, courseIds);
        }

    }
}
