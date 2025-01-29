using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessObjects;

namespace BusinessLayer
{
    public class CommonManager
    {
        /// <summary>
        /// Get Common use Data in Dataset for Registration purpose
        /// </summary>
        /// <returns></returns>
        public static DataSet GetInitialData()
        {
            return CommonDB.GetInitialData();
        }

        /// <summary>
        /// Get Common use Data in Dataset for Registration purpose with post Id
        /// </summary>
        /// <returns></returns>
        public static DataSet GetInitialData(int postId)
        {
            return CommonDB.GetInitialData(postId);
        }

        /// <summary>
        /// Get All Course by Programme/Group
        /// </summary>
        /// <param name="programmeId"></param>
        /// <returns></returns>
        public static Dictionary<string, string> GetAllCourse(string programmeIds)
        {
            return CommonDB.GetAllCourse(programmeIds);
        }

        /// <summary>
        /// Get All City by state
        /// </summary>
        /// <param name="stateId"></param>
        /// <returns></returns>
        public static Dictionary<string, string> GetAllCity(int stateId)
        {
            return CommonDB.GetAllCity(stateId);
        }

      

        /// <summary>
        /// Get all course for dropdown list 
        /// </summary>
        /// <param name="programSysCode"></param>
        /// <returns></returns>
        public static Dictionary<string, string> GetAllQualification(string courseIds)
        {
            return EligibilityDB.GetAllQualification(courseIds);
        }
    }
}
