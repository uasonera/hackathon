using ClassLibrary3.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.DataAccessObjects
{
   public class Payment
    {
        IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentManagementSystem"].ConnectionString);
        public List<ODCDetails> ODCList()
        {
            string query = "select distinct NameOfCandidate,SurnameOfCandidate,CodeOfCandidate from ODCDetails";
            return connection.Query<ODCDetails>(query).ToList();
        }


        public List<ODCDetails> PaymentDetailslist(int id)
        {
            string query = "select * from PaidList join PaymentDetails on PaidList.PaymentDetailsID = PaymentDetails.PaymentDetailsId join ODCDetails on PaidList.ODCId = ODCDetails.ODCId where CodeOfCandidate = '"+id+"' and isPaymentDone = 1";
            /*var list=*/
            return connection.Query<ODCDetails>(query).ToList();
        }

        public List<ODCDetails> PaymentDetails(int id)
        {
            string query = "select * from ODCDetails where CodeOfCandidate='"+id+"' and isPaymentDone=0";
            /*var list =*/ return connection.Query<ODCDetails>(query).ToList();
            //List<int> odcids = new List<int>();
            //List<ODCDetails> ODCDetailslist = new List<ODCDetails>();

            //foreach (var item in list)
            //{
            //    string query1 = "select * from ODCDetails join paidlist on ODCDetails.ODCId = PaidList.ODCId join PaymentDetails on PaidList.PaidId = PaymentDetails.PaymentDetailsId where PaidList.ODCId = '" + item.ODCId + "' and ODCDetails.CodeofCandidate='" + id + "'";
            //    var list1 = connection.Query<ODCDetails>(query).LastOrDefault();
            //    if (list1.NameOfCandidate == null)
            //    {
            //        odcids.Add(list1.ODCId);
            //    }
            //}
            //foreach (var item in odcids)
            //{
            //    string query3 = "select ODCId from ODCDetails where ODCId='" + id + "'";
            //    var list3 = connection.Query<ODCDetails>(query).SingleOrDefault();
            //    ODCDetailslist.Add(list3);
            //}
            //return ODCDetailslist;

        }

        public void AmountPaid(ODCDetails OdcDetails)
        {
            DateTime DateofPayement = OdcDetails.DateOfPayement;
                string query = "insert into PaymentDetails values (@AmountPaid,@DateOfPayement)";
            connection.Execute(query,new {OdcDetails.AmountPaid,OdcDetails.DateOfPayement});
        }

        public void UpdateODCDetails(string[] odcid)
        {
            for (var i = 0; i < odcid.Length; i++)
            {
                int ODCId = Convert.ToInt32(odcid.ElementAt(i));
                int val = 1;
                string query = "update ODCDetails set isPaymentDone=@val where ODCId=@odcid";
                connection.Execute(query,new {val,ODCId});
     }
        }

        public int GetPaidId()
        {
            string query = "Select top 1 PaymentDetailsId from PaymentDetails order by 1 desc";
            return connection.Query<int>(query).SingleOrDefault();
        }

        public void InsertPaidODCID(string[] odcid ,int PaymentDetailsID)
        {
            for(var i = 0; i < odcid.Length; i++) { 
           int ODCId = Convert.ToInt32(odcid.ElementAt(i));
            
            string query = "insert into PaidList values (@ODCId,@PaymentDetailsID)";
            connection.Execute(query, new { ODCId, PaymentDetailsID });
            }
        }

    }
}
