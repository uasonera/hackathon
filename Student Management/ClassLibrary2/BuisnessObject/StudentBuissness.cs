using StudentManagement.DataAccessObjects;
using StudentManagement.Entities;
using StudentManagement.ViewModels;
using System.Collections.Generic;

namespace StudentManagement.BuisnessObject
{
    public class StudentBuissness
    {
        StudentDataAccess studentDataAccess = new StudentDataAccess();
        public void AddStudent(StudentDetailsViewModel studentviewmodel)
        {
            var student = new Student()
            {
                Surname = studentviewmodel.Surname,
                FirstName = studentviewmodel.FirstName,
                MiddleName = studentviewmodel.FatherName,
                FatherName = studentviewmodel.FatherName,
                Age = studentviewmodel.Age,
                DateOfBirth = studentviewmodel.DateOfBirth,
                DateOfRegistration = studentviewmodel.DateOfRegistration,
                MaritialStatus = studentviewmodel.MaritialStatus,
                Category = studentviewmodel.Category,
                Gender = studentviewmodel.Gender,
                Nationality = studentviewmodel.Nationality,
                CourseApplied = studentviewmodel.CourseApplied,
                PassportNo = studentviewmodel.PassportNo
            };

            var contactDetails = new StudentContactDetails()
            {
                CorrespondenceAddress = studentviewmodel.CorrespondenceAddress,
                StateName = studentviewmodel.StateName,
                City = studentviewmodel.City,
                PinCode = studentviewmodel.PinCode,
                PermanentAddress = studentviewmodel.PermenantAddress,
                PermanentStateName = studentviewmodel.PermanentStateName,
                PermanentCity = studentviewmodel.PermanentCity,
                PermanentPinCode = studentviewmodel.PermanentPinCode,
                Email = studentviewmodel.Email,
                ParentMobileNo = studentviewmodel.ParentMobileNo,
                MobileNo = studentviewmodel.MobileNo,
                PhoneNo = studentviewmodel.PhoneNo
            };

            var documnet = new SubmittedDocuments()
            {
                TenthMarksheet = studentviewmodel.TenthMarksheet,
                TwelthMarksheet = studentviewmodel.TwelthMarksheet,
                GraduationMarksheet = studentviewmodel.GraduationMarksheet,
                SchoolLeavingCerti = studentviewmodel.SchoolLeavingCerti,
                VoterId = studentviewmodel.VoterId,
                DrivingLicense = studentviewmodel.DrivingLicense,
                Passport = studentviewmodel.Passport,
                ElectricBill = studentviewmodel.ElectricBill,
                ProvisionalCerti=studentviewmodel.ProvisionalCerti,
                TransferCerti = studentviewmodel.TransferCerti,
                CharacterCerti = studentviewmodel.CharacterCerti,
                AadharCard = studentviewmodel.AadharCard,
                Remark=studentviewmodel.Remark
            };
            //foreach (var item in studentviewmodel.AcademicDetailList)
            //{
            //    var listOfAcademicDetails = new AcademicDetails()
            //    {
            //        LevelOfExamination = item.LevelOfExamination,
            //        BoardUniversity = item.BoardUniversity,
            //        YearOfPassing = item.YearOfPassing,
            //        MarksObtained = item.MarksObtained,
            //        Percentage = item.Percentage,
            //        Grade = item.Grade
            //    };
            //    studentDataAccess.AddAcadamicDetails(listOfAcademicDetails);
            //}
            studentDataAccess.AddStudent(student);
            studentDataAccess.AddContactDetails(contactDetails,student);
            studentDataAccess.AddDocumentDetails(documnet,student);
            
            
        }
    }
}
