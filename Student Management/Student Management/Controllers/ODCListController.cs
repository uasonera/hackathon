using ClassLibrary2.BuisnessObject;
using ClassLibrary2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_Management.Controllers
{
    public class ODCListController : Controller
    {
        // GET: ODCList
        public ActionResult Index()
        {
            var odc = new ODC();
            var oDCListViewModel = new ODCListViewModel();
            oDCListViewModel.ListofODC= odc.ODCList();
            return View(oDCListViewModel);
        }
    }
}