using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates
{
    class Second
    {
        public static void SecondExample()
        {

            User u = new User();
            u.PrintUser(u.AllUsers());
            u.PrintUser(u.ValidUser(IsValidUser));
        }

        public  static bool IsValidUser(User u)
        {
            if (u.Age > 20)
                return true;
            else
                return false;
        }
    }

    public delegate bool isValid(User user);
    public  class User
    {
      
        public string Name { get; set; }
        public int Age { get; set; }

        public bool IsValid { get; set; } = false;

        public List<User> AllUsers()
        {
            List<User> users = new List<User>();
            users.Add(new User { Name = "Ashutosh", Age = 45 });
            users.Add(new User { Name = "Robert", Age = 18 });
           return users;
        }

        public List<User> ValidUser(isValid isvalid)
        {
            List<User> users = AllUsers();
            foreach (var item in users)
            {
                if(isvalid(item))
                {
                    item.IsValid = true;
                }
            }

            return users;
        }

        public void PrintUser(List<User> users)
        {
            foreach (var item in users)
            {
                Console.WriteLine($"Name : {item.Name}, Age:{item.Age}, Valid:{item.IsValid}");
            }
        }
    }
}
