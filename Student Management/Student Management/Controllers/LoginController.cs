using ClassLibrary2.BuisnessObject;
using ClassLibrary2.ViewModels;
using ClassLibrary3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_Management.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            Session.Clear();
            Session.Abandon();
            Session.RemoveAll();
            return View();
        }

        [HttpPost]
        public ActionResult loginDetails(LoginViewModel loginViewModel)
        {
          var businessObject =new LoginBusinessObject();
            List<LoginEntity> LoginDetails = businessObject.LoginBusiness(loginViewModel);
            foreach(var item in LoginDetails)
            {
                if(item.Username==loginViewModel.Username && item.Password == loginViewModel.Password)
                {
                    return RedirectToAction("Index", "ODCList", null);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Index");
        }
    }
}