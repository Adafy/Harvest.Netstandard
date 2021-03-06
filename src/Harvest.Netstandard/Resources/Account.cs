﻿using System.Threading.Tasks;
using Adafy.Harvest.Netstandard.Models;

namespace Adafy.Harvest.Netstandard
{
    public partial class HarvestRestClient
    {
        private const string WHOAMI_RESOURCE = "account/who_am_i";

        // https://github.com/harvesthq/api/blob/master/Sections/Accounts.md

        /// <summary>
        /// List user and account information for the authenticated account. Makes a GET request to the Account/Who_Am_I resource.
        /// </summary>
        public Account WhoAmI()
        {
            var request = Request(WHOAMI_RESOURCE);

            return Execute<Account>(request);
        }

        /// <summary>
        /// List user and account information for the authenticated account. Makes a GET request to the Account/Who_Am_I resource.
        /// </summary>
        public Task<Account> WhoAmIAsync()
        {
            var request = Request(WHOAMI_RESOURCE);

            return ExecuteAsync<Account>(request);
        }
    }
}
