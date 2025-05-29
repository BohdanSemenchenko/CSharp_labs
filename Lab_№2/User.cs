using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class User
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        private string _password {  get; set; } 

        public User(string userName, string email, string password)
        {
            UserName = userName;
            Email = email;
            _password = password;
        }

        public void SetPassword(string email,string oldPassword, string newPassword)
        {
            if(!Authenticate(email, oldPassword))
            {
                return;
                _password = newPassword;    
            }
        }

        public bool Authenticate(string email, string inputPassword)
        {
            return email == Email & _password == inputPassword;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"UserName: {UserName}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
