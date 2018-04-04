using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagement.Entities
{
    public class Student
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
        public int ContactId { get; set; }
        public int DocID { get; set; }
    }
}
