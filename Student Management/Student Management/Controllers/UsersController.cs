using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_Management.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult UserList()
        {
            return View();
        }
        public ActionResult UserDetails()
        {
            return View();
        }
        public ActionResult CreateUser()
        {
            return View();
        }
        public ActionResult EditUser()
        {
            return View();
        }
    }
}