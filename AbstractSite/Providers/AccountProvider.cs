using AbstractSite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractSite.Providers
{
    public class AccountProvider: IAccountProvider
    {
        public string GetCustomSubject()
        {
            return "New Reviews";
        }
    }
}
