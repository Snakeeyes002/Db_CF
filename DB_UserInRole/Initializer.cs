using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_CF
{
    public class Initializer: DropCreateDatabaseIfModelChanges<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            context.Users.AddRange(DataManager.users);
            context.UsersInRoles.AddRange(DataManager.userinroles);
            context.Roles.AddRange(DataManager.roles);
        }
    }
}
