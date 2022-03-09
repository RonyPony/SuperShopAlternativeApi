using SuperShop.Data.Data;
using superShopAlternativeImplementation.CORE.CONTRACTS;
using superShopAlternativeImplementation.CORE.Domains;
using superShopAlternativeImplementation.CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop.Data.Repository
{
    public class BranchRepository : IBranchRepository
    {
        private readonly SuperShopContext _superShopContext;
        public async Task<int> CreateBranch(BranchToRegister branch)
        {
            if (branch is null)
                throw new Exception("InvalidBranchRequest");

            branch.BranchID = "6455";
            branch.Description = "desc";
            Branch brch = new Branch();
            brch.IsDeleted = false;
            _superShopContext.branches.Add(brch);
            var ret = await _superShopContext.SaveChangesAsync();
            return brch.Id;
        }

        public Task RemoveBranch(string branchId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBranch(BranchToRegister branch)
        {
            throw new NotImplementedException();
        }
    }
}
