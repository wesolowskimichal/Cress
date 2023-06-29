using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cress.Model
{
    public class PasswordChecker
    {
        public enum RegStatus
        {
            SUCCESS,
            W_USERNAME,
            ERROR
        };

        public static RegStatus Authenticate(string username, string password)
        {
            if (username == null || password == null || username.Length == 0 || password.Length == 0)
                return RegStatus.ERROR;
            DBManager dBManager = DBManager.Instance;
            if (dBManager.ExecuteQueryGetCount($"SELECT COUNT(*) FROM users WHERE username = '{username}'") != 0)
                return RegStatus.W_USERNAME;
            return RegStatus.SUCCESS;
        }

        public static int CheckStrength(string password)
        {
            int score = 1;

            if (password.Length < 1)
                return 0;
            if (password.Length < 4)
                return 1;

            if (password.Length >= 8)
                score++;
            if (password.Length >= 12)
                score++;
            if (Regex.Match(password, @"\d").Success)
                score++;
            if (Regex.Match(password, @"[a-z]").Success && Regex.Match(password, @"[A-Z]").Success)
                score++;
            if (Regex.Match(password, @"[!@#$%^&*?_~-£()]").Success)
                score++;

            return score;
        }
    }
}
