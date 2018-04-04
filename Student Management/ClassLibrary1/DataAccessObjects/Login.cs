using ClassLibrary3;
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
    public class Login
    {
        IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentManagementSystem"].ConnectionString);

        public List<LoginEntity> LoginDetails(LoginEntity Login)
        {
            try
            {

                if (connection.State == ConnectionState.Closed)

                    connection.Open();

                string query = "select * from UserDetails";
               return connection.Query<LoginEntity>(query).ToList();
            }
            catch (System.Exception ex)
            {

                throw;
            }
            return null;
        }
    }
}
