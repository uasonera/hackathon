using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Entities
{
    public class AcademicDetails
    {
        [Key]
        public int AcademicDetailsId { get; set; }
        public string LevelOfExamination { get; set; }
        public string BoardUniversity { get; set; }
        public string YearOfPassing { get; set; }
        public string MarksObtained { get; set; }
        public int Percentage { get; set; }
        public string Grade { get; set; }
    }
}
