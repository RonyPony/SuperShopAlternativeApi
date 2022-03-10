using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperShop.Core.Domains;
using SuperShop.Core.Interfaces;

namespace superShopAlternativeImplementation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MallController : ControllerBase
    {
        private readonly IMallService _mallService;
        

        public MallController(IMallService serv)
        {
            _mallService = serv;
        }

        // GET: MallController/Create
        [HttpPost(Name ="createMall")]
        public async Task<IActionResult> Create(Mall mall)
        {
            try
            {
                if (mall==null)
                {
                    throw new ArgumentNullException(nameof(mall));
                }
                var x = await _mallService.SaveMall(mall);
                return Ok(x);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete(Name ="Delete")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            else
            {
                var response = await _mallService.DeleteMall(id);
                return Ok(response);
            }
        }

        [HttpGet(Name ="GetAllMalls")]
        public async Task<IEnumerable<Mall>> GetMalls()
        {
            try {
                var response = await _mallService.GetAllMalls();
                return response.ToList();
            }catch (Exception) {
                return null;

            }
        }

    }
}
