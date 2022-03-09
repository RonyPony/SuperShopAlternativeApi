using superShopAlternativeImplementation.CORE.Domains;

namespace superShopAlternativeImplementation.CORE.Interfaces
{
    public interface IBranchService
    {
        
        /// <summary>
        /// Retrives all branch data.
        /// </summary>
        /// <returns>list of branchs</returns>
        public IEnumerable<Branch> GetAllBranchs();

        /// <summary>
        /// Retrives all branch data.
        /// </summary>
        /// <returns>list of branchs</returns>
        public Task<bool> SaveBranchs(Branch branch);

        /// <summary>
        /// Retrieves all branch by account id.
        /// </summary>
        /// <param name="accountId">Account's id</param>
        /// <returns></returns>
        public Task<IEnumerable<Branch>> GetBranchesById(string accountId);

        /// <summary>
        /// Retrieves branch assign to account
        /// </summary>
        /// <param name="accountId">Account's id</param>
        /// <returns></returns>
        public Task<Branch> GetBranchFromMall(string mallId);

        /// <summary>
        /// Retrieves a especific branch data by id
        /// </summary>
        /// <param name="id">Branch's id</param>
        /// <returns>a branch</returns>
        public Task<Branch> GetBranchById(int id);

        /// <summary>
        /// Retrieves a count of branch data stored
        /// </summary>
        /// <returns>the count number</returns>
        public Task<int> BranchCount();

    }
}
