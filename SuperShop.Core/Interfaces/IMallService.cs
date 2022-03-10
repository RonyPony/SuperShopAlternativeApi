using SuperShop.Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShop.Core.Interfaces
{
    public interface IMallService
    {
        public Task<IEnumerable<Mall>> GetAllMalls();
        public Task<bool>SaveMall(Mall mall);
        public Task<bool>DeleteMall(string mall);
    }
}
