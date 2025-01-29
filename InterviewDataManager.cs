
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
    public partial class InterviewDataManager
    {
        /// <summary>
        /// Get All Details of Student.
        /// </summary>
        /// <param name="studentSysCode"></param>
        /// <returns></returns>
        public static InterviewData GetByStudentSysCode(long studentSysCode)
        {

            InterviewData student = new InterviewData();
            student.StudentSysCode = studentSysCode;
            InterviewDataDB.GetByStudentSysCode(student);
            return student;

        }

    }
}
