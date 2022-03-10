using SuperShop.Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop.Core.Contracts
{
    public interface IMallRepository
    {
        /// <summary>
        /// Register a new record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>
        public Task<int> CreateMall(Mall mall);

        public Task<IEnumerable<Mall>> getAllMalls();

        /// <summary>
        /// Update a specific record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>
        public Task UpdateMall(Mall mall);

        /// <summary>
        ///  Remove a specific record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>
        public  Task<bool> RemoveMall(string mallId);
    }
}
