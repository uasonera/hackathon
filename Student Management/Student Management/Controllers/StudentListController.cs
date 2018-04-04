using ClassLibrary2.BuisnessObject;
using ClassLibrary2.ViewModels;
using ClassLibrary3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_Management.Controllers
{
    public class StudentListController : Controller
    {
        // GET: StudentList
        public ActionResult Index()
        {
            var businessObject = new StudentListBusinessObject();
            var studentList =new StudenListViewModel();
            studentList.listStudent = businessObject.ListOfStudent() ;
            return View(studentList);
        }
        public ActionResult DeleteStudent(int id)
        {
            var businessObject = new StudentListBusinessObject();
            businessObject.DeleteStudent(id);
            return RedirectToAction("Index");
        }
    }
}