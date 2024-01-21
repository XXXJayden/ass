using Ass2.Data;
using Ass2.Models;

namespace Ass2.Repositories
{
    public interface IBranchRepository
    {
        public Task<List<BranchModel>> GetAllBranchesAsync();
        public Task<BranchModel> GetBranchesAsync(int id);
        public Task<int> AddBranchesAsync(BranchModel model);
        public Task UpdateBranchAsync(int id, BranchModel model);
        public Task DeleteBranchesAsync(int id);
    }
}
