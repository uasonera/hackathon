using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Entities
{
    public class StudentContactDetails
    {
        [Required]
        public int ContactId { get; set; }
        public string CorrespondenceAddress { get; set; }
        public string StateName { get; set; }
        public string City { get; set; }
        public string PinCode { get; set; }
        [Required]
        public string PermanentAddress { get; set; }
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
        public int StudentId { get; set; }

        
    }
}
