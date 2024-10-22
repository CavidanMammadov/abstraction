using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.cs
{
    
    
        public class User : IAccount
        {
            private static int _id = 1;
            public int Id { get; set; }
            public string Fullname { get; set; }
            public string Email { get; set; }
            private string _password;

            public string Password
            {
            get { return _password; }
                set
                {
                    if (PasswordChecker(value))
                    {
                        _password = value;
                    }
                    else
                    {
                       Console.WriteLine("sifre sertlere uygun deyil");
                    }
                }
            }

            public User(string fullname, string email, string password)
            {
                Id = _id++;
                Fullname = fullname;
                Email = email;
                Password = password; 
            }

            public bool PasswordChecker(string password)
            {
            if (password.Length < 8)
            {
                return false;
            }

                bool hasUpper = false;
                bool hasLower = false;
                bool hasDigit = false;

                foreach (char c in password)
                {
                if (char.IsUpper(c)) 
                { hasUpper = true; }
                if (char.IsLower(c))
                { hasLower = true; }
                if (char.IsDigit(c))
                { hasDigit = true; }

                if (hasUpper && hasLower && hasDigit)
                {
                    return true;
                }
                }
                return false;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Id: {Id}, Fullname: {Fullname}, Email: {Email}");
            }
        }

    }

