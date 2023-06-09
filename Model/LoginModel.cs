using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cress.Model
{
    public class LoginModel
    {
        public bool Authenticate(string username, string password)
        {
            DBManager dBManager = DBManager.Instance;
            if (dBManager.ExecuteQueryGetCount($"SELECT COUNT(*) FROM users WHERE username = '{username}' AND password = '{password}'") == 1)
                return true;
            return false;

        }
    }
}
