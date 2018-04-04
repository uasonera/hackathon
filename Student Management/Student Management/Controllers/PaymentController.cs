using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClassLibrary2.BuisnessObject;
using ClassLibrary2.ViewModels;
using System.Web.Mvc;
using ClassLibrary3.Entities;

namespace Student_Management.Controllers
{
    public class PaymentController : Controller
    {
        // GET: Payment
        public ActionResult Index()
        {
            var paymentBusinessObject = new PaymentBusinessobject();
            var ODCListViewModel = new ODCListViewModel();
            ODCListViewModel.ListofODC = paymentBusinessObject.paymentDetails();
            return View(ODCListViewModel);
        }

        public ActionResult PaymentDetails(int id)
        {
            var paymentBusinessObject = new PaymentBusinessobject();
            var ODCListViewModel = new ODCListViewModel();
            ODCListViewModel.ListofODC=paymentBusinessObject.paymentDetailsList(id);
            return View(ODCListViewModel);
        }

        public ActionResult PaymentDetailslist(int id)
        {
            var paymentBusinessObject = new PaymentBusinessobject();
            var ODCListViewModel = new ODCListViewModel();
            ODCListViewModel.ListofODC = paymentBusinessObject.paymentDetailsLists(id);
            return View(ODCListViewModel);
        }

        public ActionResult SubmitAmountPaid(FormCollection form,ODCDetails oDCDetails)
        {
            string checkbox = form["Checkbox"].ToString();
            string[] odcid = checkbox.Split(',');
            var paymentBusinessObject = new PaymentBusinessobject();
            paymentBusinessObject.AmountPaid(oDCDetails);
            int paymentDetailsid=paymentBusinessObject.GetPaymentDetailsId();
            paymentBusinessObject.InsertPaidODCID(odcid, paymentDetailsid);
            paymentBusinessObject.UpdateODCDetails(odcid);
            return Content("<script language='javascript' type='text/javascript'>alert('Saved Successfully');window.location = '/Payment/Index';</script>");
        }
    }
}