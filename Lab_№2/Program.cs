using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab2
{
    internal class Program
    {
        static void Main()
        {
            List<User> users = new List<User>
            {
                new Admin("AdminUser", "admin@example.com", "admin123"),
                new Moderator("ModUser", "mod@example.com", "mod123"),
                new RegularUser("RegUser", "user@example.com", "user123")
            };

            Console.WriteLine("\n=== Інформація про користувачів ===");
            foreach (var user in users)
            {
                user.DisplayInfo();
                Console.WriteLine();
            }

            Console.WriteLine("=== Тестування методів ===");

          
            foreach (var user in users)
            {
                if (user is Admin admin)
                {
                    admin.BlockUser(users[2]); 
                }
                else if (user is Moderator moderator)
                {
                    moderator.ModerateContent();
                }
                else if (user is RegularUser regularUser)
                {
                    regularUser.PostComment();
                }
            }

            Console.WriteLine("\n=== Перевірка аутентифікації ===");

            var loginAttempts = new List<(User user, string email, string password)>
            {
                (users[0], "admin@example.com", "admin123"), 
                (users[1], "mod@example.com", "wrongpassword"), 
                (users[2], "user@example.com", "user123") 
            };

            foreach (var attempt in loginAttempts)
            {
                bool isAuthenticated = attempt.user.Authenticate(attempt.email, attempt.password);
                Console.WriteLine($"{attempt.user.UserName}: {(isAuthenticated ? "Успішна аутентифікація" : "Невірний пароль")}");
            }
        }
    }
}

