using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using superShopAlternativeImplementation.CORE.CONTRACTS;
using superShopAlternativeImplementation.CORE.Domains;
using superShopAlternativeImplementation.CORE.Interfaces;

namespace superShopAlternativeImplementation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BranchController : ControllerBase
    {
        private readonly IBranchService _branchService;
        private readonly IBranchRepository _branchRepo;

        public BranchController(IBranchService branchServ,IBranchRepository branchRepository)
        {
            _branchService = branchServ;
            _branchRepo = branchRepository;
        }
        [HttpPost(Name ="create")]
        public async Task<IActionResult> Create(Branch info)
        {
            try
            {
                if (info == null)
                {
                    throw new ArgumentNullException(nameof(info));
                }
                var x = await _branchService.SaveBranchs(info);
                return Ok(x);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet(Name = "getBranches")]
        public async Task<IActionResult> GetBranch()
        {
            try
            {
                IEnumerable<Branch> branches = new List<Branch>();
                branches =  _branchService.GetAllBranchs();
                return Ok(branches);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
