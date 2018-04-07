using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.ViewModels
{
   public class AddODCDetailsViewModel
    {
        public string NameOfCandidate { get; set; }
        public string SurnameOfCandidate { get; set; }
        public string CodeOfCandidate { get; set; }
        public string Place { get; set; }
        public string Timing { get; set; }
        public int AmountPaid { get; set; }
        public DateTime DateOfPayement { get; set; }
        public DateTime DateOfODC { get; set; }
        public string Department { get; set; }
        public int Conveyence { get; set; }
        public List<AddODCDetailsViewModel> ODCList { get; set; }
    }
}
