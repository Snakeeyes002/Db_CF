using DB_CF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersInRolesConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Database.SetInitializer(new Initializer());
            UserContext context = new UserContext();
            Console.WriteLine(context.Users.First().UserName);
            SqlParameter parameterProg = new SqlParameter("roleName", "programmer");
            SqlParameter parameterManag = new SqlParameter("@roleName", "manager");
            string SqlQuery = "Select * From UsersByRole(@roleName)";
            try
            {
                var TableOfUsers = context.Database.SqlQuery<UsersInRoleTable>(SqlQuery, parameterProg);
                foreach (var user in TableOfUsers)
                {
                    Console.WriteLine($"{user.UserName} {user.DateBirthday} {user.RoleName}");
                }
                Console.WriteLine();
                TableOfUsers = context.Database.SqlQuery<UsersInRoleTable>(SqlQuery, parameterManag);
                foreach (var user in TableOfUsers)
                {
                    Console.WriteLine($"{user.UserName} {user.DateBirthday} {user.RoleName}");
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

