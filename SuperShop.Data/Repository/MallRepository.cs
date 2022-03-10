using SuperShop.Core.Contracts;
using SuperShop.Core.Domains;
using SuperShop.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop.Data.Repository
{
    public class MallRepository : IMallRepository
    {
        private readonly SuperShopContext _superShopContext;
        public MallRepository(SuperShopContext cctx)
        {
            _superShopContext = cctx;
        }
        public async Task<int> CreateMall(Mall mall)
        {
            try
            {
                mall.CreationDate = DateTime.Now;
                mall.IsDeleted = false;
                _superShopContext.Malls.Add(mall);
               var x = await _superShopContext.SaveChangesAsync();
                return x;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public async Task<IEnumerable<Mall>> getAllMalls()
        {
            try
            {
                var malls = _superShopContext.Malls.ToList();
                return malls;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool>RemoveMall(string mallId)
        {
            try
            {
                var resp = _superShopContext.Malls.Where(x => x.Id.Equals(Convert.ToInt32(mallId))).FirstOrDefault();
                resp.IsDeleted = true;
                var x = await _superShopContext.SaveChangesAsync();
                if (x == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task UpdateMall(Mall mall)
        {
            throw new NotImplementedException();
        }
    }
}
