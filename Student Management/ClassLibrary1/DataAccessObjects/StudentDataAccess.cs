using ClassLibrary3.Entities;
using Dapper;
using StudentManagement.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace StudentManagement.DataAccessObjects
{
    public class StudentDataAccess
    {
        IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentManagementSystem"].ConnectionString);
        public void AddStudent(Student student)
        {
            try
            {

                if (connection.State == ConnectionState.Closed)
                
                    connection.Open();
                
                    string AddStudentQuery = "Insert into Student values(@Surname,@FirstName,@MiddleName,@FatherName,@DateOfBirth,@Age,@Gender,@Nationality,@CourseApplied,@Category,@PassportNo,@MaritialStatus,@DateOfRegistration)";
                    connection.Execute(AddStudentQuery, new
                    {
                        student.Surname,
                        student.FirstName,
                        student.MiddleName,
                        student.FatherName,
                        student.DateOfBirth,
                        student.Age,
                        student.Gender,
                        student.Nationality,
                        student.CourseApplied,
                        student.Category,
                        student.PassportNo,
                        student.MaritialStatus,
                        student.DateOfRegistration
                    });
                
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
        public void AddContactDetails(StudentContactDetails studentContactDetails,Student student)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)

                    connection.Open();
                string query = "select id as StudentId from Student where FirstName='" + student.FirstName + "' and FatherName='" + student.FatherName + "' and Datepart(YEAR,DateOFBirth) ='" + student.DateOfBirth.Year + "' and Datepart(MONTH,DateOFBirth) ='" + student.DateOfBirth.Month + "' and Datepart(DAY,DateOFBirth) ='" + student.DateOfBirth.Day + "'";
                var id = connection.Query<string>(query).SingleOrDefault();
                studentContactDetails.StudentId = Convert.ToInt32(id);
                string AddContactDetails = "Insert into StudentContactDetails values(@CorrespondenceAddress,@StateName,@City,@PinCode,@PermanentAddress,@PermanentStateName,@PermanentCity,@PermanentPinCode,@Email,@MobileNo,@PhoneNo,@ParentMobileNo,@StudentId)";
                connection.Execute(AddContactDetails, new
                {
                    studentContactDetails.CorrespondenceAddress,
                    studentContactDetails.StateName,
                    studentContactDetails.City,
                    studentContactDetails.PinCode,
                    studentContactDetails.PermanentAddress,
                    studentContactDetails.PermanentStateName,
                    studentContactDetails.PermanentCity,
                    studentContactDetails.PermanentPinCode,
                    studentContactDetails.Email,
                    studentContactDetails.MobileNo,
                    studentContactDetails.PhoneNo,
                    studentContactDetails.ParentMobileNo,
                    studentContactDetails.StudentId
                });
            }
            catch(Exception ex)
            {

            }
            

        }
        public void AddDocumentDetails(SubmittedDocuments submittedDocuments, Student student)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)

                    connection.Open();

                string query = "select id as StudentId from Student where FirstName='" + student.FirstName + "' and FatherName='" + student.FatherName + "' and Datepart(YEAR,DateOFBirth) ='" + student.DateOfBirth.Year + "' and Datepart(MONTH,DateOFBirth) ='" + student.DateOfBirth.Month + "' and Datepart(DAY,DateOFBirth) ='" + student.DateOfBirth.Day + "'";
                var id = connection.Query<string>(query).SingleOrDefault();
                submittedDocuments.StudentId = Convert.ToInt32(id);
                string AddContactDetails = "Insert into SubmittedDocuments values(@TenthMarksheet,@TwelthMarksheet,@GraduationMarksheet,@SchoolLeavingCerti,@VoterId,@DrivingLicense,@Passport,@ElectricBill,@StudentId,@ProvisionalCerti,@TransferCerti,@CharacterCerti,@AadharCard,@Remark)";
                connection.Execute(AddContactDetails, new
                {
                    submittedDocuments.TenthMarksheet,
                    submittedDocuments.TwelthMarksheet,
                    submittedDocuments.GraduationMarksheet,
                    submittedDocuments.SchoolLeavingCerti,
                    submittedDocuments.VoterId,
                    submittedDocuments.DrivingLicense,
                    submittedDocuments.Passport,
                    submittedDocuments.ElectricBill,
                    submittedDocuments.StudentId,
                    submittedDocuments.ProvisionalCerti,
                    submittedDocuments.TransferCerti,
                    submittedDocuments.CharacterCerti,
                    submittedDocuments.AadharCard,
                    submittedDocuments.Remark
                });

            }
            catch (Exception ex)
            {

            }
        }

        public List<StudentList> StudentList()
        {
try
            {
                if (connection.State == ConnectionState.Closed)
                connection.Open();

                string query = "Select id,FirstName,Surname,FatherName,PhoneNo,MobileNo,ParentMobileNo from Student join StudentContactDetails on Student.id=StudentContactDetails.StudentId";
             return connection.Query<StudentList>(query).ToList();
            }
            catch(Exception ex)
            {

            }
            return null;
        }
        public void DeleteStudent(int id)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                string query = "Delete from StudentContactDetails where StudentId ='" + id+"'";
                 connection.Execute(query);
                string query1 = "Delete from SubmittedDocuments where StudentId ='" + id + "'";
                connection.Execute(query1);
                string query2 = "Delete from Student where id ='" + id + "'";
                connection.Execute(query2);
            }
            catch(Exception ex)
            {

            }
        }
        //public bool AddAcadamicDetails(AcademicDetails academicDetails)
        //{
        //    if (connection.State == ConnectionState.Closed)
        //    {
        //        connection.Open();
        //        string AddAcadamicsQuery = "Insert Into Student values(@LevelOfExamination,@BoardUniversity,@YearOfPassing,@MarksObtained,@Percentage,@Grade)";
        //        connection.Execute(AddAcadamicsQuery, new
        //        {
        //            academicDetails.LevelOfExamination,
        //            academicDetails.BoardUniversity,
        //            academicDetails.YearOfPassing,
        //            academicDetails.MarksObtained,
        //            academicDetails.Percentage,
        //            academicDetails.Grade
        //        });
        //        }
        //    return true;
        //}
    }
}