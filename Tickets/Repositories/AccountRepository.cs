using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.Data;
using Tickets.Model;

namespace Tickets
{
    public class AccountRepository : EntityFrameworkRepository<Account>, IAccountRepository
    {
        public AccountRepository(AppDbContext context) : base(context) { }

        public async Task<Account> IsAccountValidAsync(string user, string passowrd)
        {
            var userdb = await _dbSet.SingleOrDefaultAsync(i => i.User == user);
            if (userdb != null)
            {
                if (userdb.Password == passowrd)
                    return userdb;
                else
                    return null;
            }
            else
                return null;
        }
    }
}
