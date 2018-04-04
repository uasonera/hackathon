using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.Entities
{
    public class StudentList
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string PhoneNo { get; set; }
        public string MobileNo { get; set; }
        public string ParentMobileNo { get; set; }
        public List<StudentList> listofstudents {get;set;}
    }
}
