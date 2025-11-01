using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GYMONE.Helper
{
    public class Utils
    {
        public string GetErrorCode(int nCode)
        {
            if (nCode == 0)
                return "Success";
            else if (nCode == -1)
                return "Unknown Error";
            else if (nCode == -2)
                return "Connection Error";
            else if (nCode == -3)
                return "Timeout Error";
            else
                return "Undefined Error Code";
        }
        public bool IsAdminUser(string userName)
        {
            // Placeholder logic for checking if a user is an admin
            var adminUsers = new List<string> { "admin", "superuser", "manager" };
            return adminUsers.Contains(userName.ToLower());
        }
    }
}