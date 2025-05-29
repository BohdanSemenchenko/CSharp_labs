using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class RegularUser: User
    {
        public RegularUser(string userName, string email, string password)
           : base(userName, email, password) { }

        public void PostComment()
        {
            Console.WriteLine("Comment has been posted.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Role: Regular User");
        }
    }
}
