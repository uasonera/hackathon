using ClassLibrary1.DataAccessObjects;
using System;
using ClassLibrary3;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2.ViewModels;

namespace ClassLibrary2.BuisnessObject
{
    public class LoginBusinessObject
    {
        Login login = new Login();
        
        public List<LoginEntity> LoginBusiness(LoginViewModel loginDetails)
        {
            var loginEntity = new LoginEntity()
            {
                Username = loginDetails.Username,
                Password = loginDetails.Password
            };
            return login.LoginDetails(loginEntity);
        }

    }
}
