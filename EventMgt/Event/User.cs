using System;
using System.Collections.Generic;
using System.Text;
using System;

namespace Event
{
    public static class User
    {
        public static string login(String username, String password)
        {
            if (username != "user")
            {
                return "User does not exist";
            }
            else
            {
                if (password == "password")
                {
                    return "Login successful";
                }
                else
                {
                    return "Wrong password";
                }
            }
        }
    }
}
