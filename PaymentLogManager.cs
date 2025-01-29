
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
    public partial class PaymentLogManager
    {

        /// <summary>
        /// /get PaymentLog Details against TransactionId
        /// </summary>
        /// <param name="transactionId"></param>
        /// <returns></returns>
        public static PaymentLog GetByTransactionId(string transactionId)
        {
            return PaymentLogDB.GetByTransactionId(transactionId);
        }

        /// <summary>
        /// Get All Pending Transactions by Date Range
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="ToDate"></param>
        /// <returns></returns>
        public static List<PaymentLog> GetInitiatedByDateRange(DateTime fromDate, DateTime toDate)
        {
            return PaymentLogDB.GetInitiatedByDateRange(fromDate, toDate);
        }
    }
}
