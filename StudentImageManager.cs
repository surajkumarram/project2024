
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
                public partial class StudentImageManager
                {
                    public static void StudentImageUpdate(StudentImage studentImage)
                    {
                        StudentImageDB.StudentImageUpdate(studentImage);

                    }
                    public static StudentImage GetStudentImage(long StudentSysCode)
                    {
                        StudentImage _student = new StudentImage();
                        return _student = StudentImageDB.GetStudentImage(StudentSysCode);
                    }
                                    
                }
                }
