using ClassLibrary3.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.DataAccessObjects
{
   public class ODCDataAccess
    {
        IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentManagementSystem"].ConnectionString);

        public void AddStudent(ODCDetails oDCDetails)
        {
            try
            {

                if (connection.State == ConnectionState.Closed)

                    connection.Open();
                oDCDetails.IsPaymentDone = false;
                string query = "Insert into ODCDetails values (@NameOfCandidate,@SurnameOfCandidate,@CodeOfCandidate,@Place,@Timing,@DateOfODC,@Department,@IsPaymentDone)";
                connection.Execute(query, new
                {
                    oDCDetails.NameOfCandidate,
                    oDCDetails.SurnameOfCandidate,
                    oDCDetails.CodeOfCandidate,
                    oDCDetails.Place,
                    oDCDetails.Timing,
                    oDCDetails.DateOfODC,
                    oDCDetails.Department,
                    oDCDetails.IsPaymentDone
                });

            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        public List<ODCDetails> ODCList()
        {
            string query = "select * from ODCDetails";
            return connection.Query<ODCDetails>(query).ToList();
        }

        public List<ODCDetails> ODstudencodeCList()
        {
            string query = "select distinct NameOfCandidate,CodeOfCandidate from odcdetails";
            return connection.Query<ODCDetails>(query).ToList();
        }
    }
}
