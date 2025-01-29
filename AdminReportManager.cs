using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessObjects
{
    public class AdminReportManager
    {
        public static DataSet GetSummary()
        {
            return AdminReportDB.GetSummary();
        }

        public static DataSet GetProgrammeWiseSummary(int postId)
        {
            return AdminReportDB.GetProgrammeWiseSummary(postId);
        }

        public static DataSet GetStepWiseSummary(int programmeId)
        {
            return AdminReportDB.GetStepWiseSummary(programmeId);
        }

        public static DataSet GetCourseWiseSummary(int programmeId)
        {
            return AdminReportDB.GetCourseWiseSummary(programmeId);
        }

        public static DataSet GetImageStatus()
        {
            return AdminReportDB.GetImageStatus();
        }
    }
}
