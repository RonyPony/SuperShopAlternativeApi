using SuperShop.Core.Contracts;
using SuperShop.Core.Domains;
using SuperShop.Core.Interfaces;
using SuperShop.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop.Data.Services
{
    public class MallService : IMallService
    {
        private readonly IMallRepository _repo;

        public MallService(IMallRepository repox)
        {
            _repo = repox;
        }

        public Task<bool> DeleteMall(string id)
        {
            if (id == null)
            {
                return Task.FromResult(false);
            }
            else
            {
                return _repo.RemoveMall(id);
            }
        }

        public async Task<IEnumerable<Mall>> GetAllMalls()
        {
            var malls = await _repo.getAllMalls();
            return malls;
        }

        public async Task<bool> SaveMall(Mall mall)
        {
            var resp = await _repo.CreateMall(mall);
            if (resp == 1)
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
