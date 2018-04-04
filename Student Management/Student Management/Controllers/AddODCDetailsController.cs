using ClassLibrary2.BuisnessObject;
using ClassLibrary2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_Management.Controllers
{
    public class AddODCDetailsController : Controller
    {
        // GET: ODC
        public ActionResult Index()
        {
            var odc = new ODC();
            var oDCListViewModel = new ODCListViewModel();
            oDCListViewModel.ListofODC = odc.ODCstudencodeList();
            return View(oDCListViewModel);
        }
        [HttpPost]
        public ActionResult AddODCDetails(AddODCDetailsViewModel addODCDetailsViewModel)
        {
           var odc=new ODC();
            odc.AddStudent(addODCDetailsViewModel);
            return Content("<script language='javascript' type='text/javascript'>alert('Saved Successfully');window.location = '/ODCList/Index';</script>"); ;
        }
    }
}