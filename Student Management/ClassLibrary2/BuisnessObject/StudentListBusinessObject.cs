using System;
using System.Collections.Generic;
using System.Linq;
using StudentManagement.DataAccessObjects;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3.Entities;

namespace ClassLibrary2.BuisnessObject
{
    public class StudentListBusinessObject
    {
        StudentDataAccess studentDataAccess;
        public StudentListBusinessObject()
            {
            studentDataAccess = new StudentDataAccess();
            }

        public List<StudentList> ListOfStudent()
        {
           return studentDataAccess.StudentList();
        }
        public void DeleteStudent(int id)
        {
            studentDataAccess.DeleteStudent(id);
        }
        
    }
}
