using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Admin: User
    {
        public Admin(string userName, string email, string password)
            : base(userName, email, password) { }

        public void BlockUser(User user)
        {
            Console.WriteLine($"User {user.UserName} has been blocked.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Role: Administrator");
        }
    }
}
