using superShopAlternativeImplementation.CORE.Models;

namespace superShopAlternativeImplementation.CORE.CONTRACTS
{
    public interface IBranchRepository
    {
        /// <summary>
        /// Register a new record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>
        public Task<int> CreateBranch(BranchToRegister branch);

        /// <summary>
        /// Update a specific record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>
        public Task UpdateBranch(BranchToRegister branch);

        /// <summary>
        ///  Remove a specific record of branch data.
        /// </summary>
        /// <param name="branch">Branch's request</param>
        public Task RemoveBranch(string branchId);
    }
}
