using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using(UserContest db = new UserContest())
            {
                User user1 = new User { Name = "Tom", Age = 32 };
                User user2 = new User { Name = "Sam", Age = 26 };

                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
                Console.WriteLine("Objects are saved");

                var users = db.Users;
                Console.WriteLine("Users list:");
                foreach (var user in users)
                    Console.WriteLine("{0}.{1} - {2}", user.Id, user.Name, user.Age);
                Console.ReadLine();
            }
        }
    }
}
