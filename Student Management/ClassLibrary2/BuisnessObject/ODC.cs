using ClassLibrary1.DataAccessObjects;
using ClassLibrary2.ViewModels;
using ClassLibrary3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.BuisnessObject
{
    public class ODC
    {
        ODCDataAccess oDCDataAccess = new ODCDataAccess();
        public void AddStudent(AddODCDetailsViewModel addODCDetailsViewModel)
        {
            var odcDetails = new ODCDetails()
            {
                NameOfCandidate = addODCDetailsViewModel.NameOfCandidate,
                SurnameOfCandidate=addODCDetailsViewModel.SurnameOfCandidate,
                CodeOfCandidate=addODCDetailsViewModel.CodeOfCandidate,
                Place=addODCDetailsViewModel.Place,
                Timing=addODCDetailsViewModel.Timing,
                AmountPaid=addODCDetailsViewModel.AmountPaid,
                DateOfPayement=addODCDetailsViewModel.DateOfPayement,
                DateOfODC=addODCDetailsViewModel.DateOfODC,
                Department=addODCDetailsViewModel.Department,
                Conveyence=addODCDetailsViewModel.Conveyence
                
            };

            oDCDataAccess.AddStudent(odcDetails);
        }

        public List<ODCDetails> ODCList()
        {
            return oDCDataAccess.ODCList();
        }
        public List<ODCDetails> ODCstudencodeList()
        {
            return oDCDataAccess.ODstudencodeCList();
        }
    }
}

