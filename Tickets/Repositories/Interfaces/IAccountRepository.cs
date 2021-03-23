using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.Model;

namespace Tickets
{
    public interface IAccountRepository : IDatabaseRepository<Account>
    {
        Task<Account> IsAccountValidAsync(string user, string passowrd);
    }
}
