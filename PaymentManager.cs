
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
    public partial class PaymentManager
    {
        /// <summary>
        /// Get all Post
        /// </summary>
        /// <returns>List<Post></returns>
        /// 
        public static List<Payment> GetAllSettlementDetail()
        {
            return PaymentDB.GetAllSettlementDetail();
        }

        public static List<Payment> GetAllTransDetail()
        {
            return PaymentDB.GetAllTransDetail();
        }
        public static List<Payment> GetAllPostTransDetail()
        {
            return PaymentDB.GetAllPostTransDetail();
        }
        public static List<Payment> GetDateWiseAllTransDetail(string txnDate)
        {
            return PaymentDB.GetDateWiseAllTransDetail(txnDate);
        }
        public static List<Payment> GetDateWiseAllSettlementDetail(string utrNo)
        {
            return PaymentDB.GetDateWiseAllSettlementDetail(utrNo);
        }
        public static List<Payment> GetTransaction(int PostId)
        {
            return PaymentDB.GetTransaction(PostId);
        }
        public static List<Payment> GetTransactionFormWise(int PostId)
        {
            return PaymentDB.GetTransactionFormWise(PostId);
        }



    }
}
