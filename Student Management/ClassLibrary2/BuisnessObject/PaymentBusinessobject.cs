using System;
using StudentManagement.DataAccessObjects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.DataAccessObjects;
using ClassLibrary3.Entities;

namespace ClassLibrary2.BuisnessObject
{
   public class PaymentBusinessobject
    {
        Payment payment = new Payment();

        public List<ODCDetails> paymentDetails()
        {
            return payment.ODCList();
        }

        public List<ODCDetails> paymentDetailsList(int id)
        {
            return payment.PaymentDetails(id);
        }

        public void UpdateODCDetails(string[] odcid)
        {
           payment.UpdateODCDetails(odcid);
        }
        public List<ODCDetails> paymentDetailsLists(int id)
        {
            return payment.PaymentDetailslist(id);
        }
        public void AmountPaid(ODCDetails oDCDetails)
        {
             payment.AmountPaid(oDCDetails);
        }

        public int GetPaymentDetailsId()
        {
           return payment.GetPaidId();
        }

        public void InsertPaidODCID(string[] odcid, int PaymentDetailsID)
        {
          payment.InsertPaidODCID(odcid,PaymentDetailsID);
        }

    }
}
