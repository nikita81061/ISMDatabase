using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Model1 db = new Model1())
            {
                User p = new User { Name = "Name", Surname = "Surname", Login = "Login", Password = "Password", Phone = "+380968565869" };
                db.Users.Add(p);
                db.SaveChanges();
            }
        }
        }

    }

