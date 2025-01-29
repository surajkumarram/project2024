
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
                public partial class AdditionQualificationManager
                {
                    public static AdditionQualification getAdditionalData(int studentSysCode)
                    {
                        return AdditionQualificationDB.getAdditionalData(studentSysCode);
                    }

                    public static string UpdateAdditionalData(AdditionQualification additionalQualification)
                    {
                        return AdditionQualificationDB.UpdateAdditionalData(additionalQualification);

                    }
                   


                                    
                }
                }
