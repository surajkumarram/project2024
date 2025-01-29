
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
    public partial class StudentManager
    {
        public static Student GetByStudentSysCode(long studentSysCode)
        {

            Student student;
            //if (cache.Contains("Student_" + studentSysCode.ToString()))
            //{
            //    student = (Student)cache.GetData("Student_" + studentSysCode.ToString());
            //}
            //else
            //{
            student = new Student();
            student.StudentSysCode = studentSysCode;
            StudentDB.GetByStudentSysCode(student);
            //   cache.Add("Student_" + student.StudentSysCode.ToString(), student);
            // }

            return student;

        }

        public static DataTable GetAllStudentSysCode()
        {
            return StudentDB.GetAllStudentSysCode();



        }


        public static DataTable GetStudentExperience(long StudentSysCode)
        {
            return StudentDB.GetStudentExperience(StudentSysCode);
        }

        public static DataTable GetStudentExamCentre(long StudentSysCode)
        {
            return StudentDB.GetStudentExamCentre(StudentSysCode);

        }
        public static DataTable SaveStudentExamCentre(long StudentSysCode,string Centre)
        {
            return StudentDB.SaveStudentExamCentre(StudentSysCode,Centre);

        }

        public static void UpdateStudent(Student student)
        {

            if (student == null)
                throw new ArgumentException("student is null.");
            if (student.StudentId == default(int))
                throw new ArgumentException("student.StudentId value not set.");
            StudentDB.UpdateStudent(student);
            cache.Remove("Student_" + student.StudentSysCode.ToString());
            cache.Remove("Student_" + student.StudentId.ToString());

        }

        public static List<Student> GetBySearch(int postId, DateTime dateOfBirth, string emailId, string mobileNo)
        {
            return StudentDB.GetBySearch(postId, dateOfBirth, emailId, mobileNo);
        }

        public static DataSet GetPrintbyStudentSysCode(long studentSysCode)
        {
            return StudentDB.GetPrintbyStudentSysCode(studentSysCode);

        }

        public static void RemoveCahe(long studentSysCode)
        {
            cache.Remove("Student_" + studentSysCode);
        }

        public static DataSet GetAdmitCardData(long studentSysCode, string ipAddress)
        {
            return StudentDB.GetAdmitCardData(studentSysCode, ipAddress);

        }
        public static DataSet GetAttendanceSheet(int page)
        {
            return StudentDB.GetAttendanceSheet(page);

        }
        
        public static DataSet GetOtherDetailStudentSysCode(long studentSysCode)
        {
            return StudentDB.GetOtherDetailStudentSysCode(studentSysCode);

        }

        public static DataSet GetPrefrence(long studentSysCode)
        {
            return StudentDB.GetPrefrence(studentSysCode);

        }

        

        public static DataSet GetAttendanceData(string centreCode, string programmeId)
        {
            return StudentDB.GetAttendanceData(centreCode, programmeId);

        }
    }
}
