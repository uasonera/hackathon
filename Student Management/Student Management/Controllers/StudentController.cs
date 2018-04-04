using StudentManagement.ViewModels;
using StudentManagement.BuisnessObject;
using StudentManagement.Entities;
using System.Web.Mvc;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult CreateStudent()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult AddStudent(StudentDetailsViewModel student)
        {
            var studentBuissness = new StudentBuissness();
            studentBuissness.AddStudent(student);
             return Content("<script language='javascript' type='text/javascript'>alert('Saved Successfully');window.location = '/StudentList/Index';</script>"); ;
        }
    }
}