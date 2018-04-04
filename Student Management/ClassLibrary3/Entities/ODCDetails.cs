using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.Entities
{
   public class ODCDetails
    {
        public int ODCId { get; set; }
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
        public string Checkbox { get; set; }

        public bool IsPaymentDone { get; set; }
    }
}
