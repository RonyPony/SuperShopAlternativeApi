using SuperShop.Data.Data;
using superShopAlternativeImplementation.CORE.Domains;
using superShopAlternativeImplementation.CORE.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop.Data.Services
{
    public class BranchService : IBranchService
    {
        private readonly SuperShopContext _superShopContext;

        public BranchService(SuperShopContext polidomContext)
        {
            _superShopContext = polidomContext;
        }

        public Task<int> BranchCount()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Branch> GetAllBranchs()
        {
            var x=  _superShopContext.branches.ToList();
            return x;
        }

        public Task<Branch> GetBranchById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Branch>> GetBranchesById(string accountId)
        {
            throw new NotImplementedException();
        }

        public Task<Branch> GetBranchFromMall(string mallId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveBranchs(Branch branch)
        {
            _superShopContext.branches.Add(new Branch {Name=branch.Name,ImageUrl=branch.ImageUrl,Description= branch.Description}); 
            int x = await _superShopContext.SaveChangesAsync();
            if (x > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
