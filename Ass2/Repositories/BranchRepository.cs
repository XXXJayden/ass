using Ass2.Data;
using Ass2.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Ass2.Repositories
{
    public class BranchRepository : IBranchRepository
    {
        private readonly BranchContext _context;
        private readonly IMapper _mapper;

        public BranchRepository(BranchContext context, IMapper mapper) {
            _context = context;
            _mapper = mapper;
        }
        public async Task<int> AddBranchesAsync(BranchModel model)
        {
            var newBook = _mapper.Map<Branch>(model);
            _context.Branches!.Add(newBook);
            await _context.SaveChangesAsync();

                return newBook.BranchId;
        }

        public async Task DeleteBranchesAsync(int id)
        {
            var deleteBook = _context.Branches!.SingleOrDefault(b => b.BranchId == id);
            if (deleteBook != null)
            {
                deleteBook.State = Enums.Status.Deactive.ToString();
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<BranchModel>> GetAllBranchesAsync()
        {
            var branchs = await _context.Branches!.ToListAsync();
            return _mapper.Map<List<BranchModel>>(branchs);
        }

        public async Task<BranchModel> GetBranchesAsync(int id)
        {
            var branch = await _context.Branches!.FindAsync(id);
            return _mapper.Map<BranchModel>(branch);
        }

        public async Task UpdateBranchAsync(int id, BranchModel model)
        {
            if(id == model.BranchId)
            {
                var updateBook = _mapper.Map<Branch>(model);
                _context.Branches?.Update(updateBook);
                await _context.SaveChangesAsync();
            }
        }
    }
}
