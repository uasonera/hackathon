using StudentManagement.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.ViewModels
{
    public class StudentDetailsViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string MiddleName { get; set; }
        [Required]
        public string FatherName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        public string CourseApplied { get; set; }
        [Required]
        public string Category { get; set; }
        public string PassportNo { get; set; }
        [Required]
        public string MaritialStatus { get; set; }
        [Required]
        public DateTime DateOfRegistration { get; set; }
        // public int ContactId { get; set; }
        public string CorrespondenceAddress { get; set; }
        public string StateName { get; set; }
        public string City { get; set; }
        public string PinCode { get; set; }
        [Required]
        public string PermenantAddress { get; set; }
        [Required]
        public string PermanentStateName { get; set; }
        [Required]
        public string PermanentCity { get; set; }
        [Required]
        public string PermanentPinCode { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string MobileNo { get; set; }
        public string PhoneNo { get; set; }
        [Required]
        public string ParentMobileNo { get; set; }
        // public int DocID { get; set; }
        public string TenthMarksheet { get; set; }
        public string TwelthMarksheet { get; set; }
        public string GraduationMarksheet { get; set; }
        public string SchoolLeavingCerti { get; set; }
        public string VoterId { get; set; }
        public string DrivingLicense { get; set; }
        public string Passport { get; set; }
        public string ElectricBill { get; set; }
        //public List<AcademicDetails> AcademicDetailList { get; set; }

        public string ProvisionalCerti { get;set;}
        public string TransferCerti  { get;set;}
        public string CharacterCerti { get;set;}
        public string AadharCard { get;set;}
        public string Remark { get; set; }
    }
}