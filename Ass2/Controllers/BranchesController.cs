using Ass2.Data;
using Ass2.Models;
using Ass2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ass2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchesController : ControllerBase
    {
        private readonly IBranchRepository _bookRepo;

        public BranchesController(IBranchRepository repo) { 
            _bookRepo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBranches()
        {
            try
            {
                return Ok(await _bookRepo.GetAllBranchesAsync());
            }catch (Exception ex) { 
            return BadRequest("Can not get all branches");
            }

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBranchByID(int id)
        {

                var branch =await _bookRepo.GetBranchesAsync(id);
                return branch == null ? NotFound() : Ok(branch);
        }
        [HttpPost]
        public async Task<IActionResult> AddNewBook(BranchModel model)
        {
            try
            {
                var newBranchId = await _bookRepo.AddBranchesAsync(model);
                var branch = await _bookRepo.GetBranchesAsync(newBranchId);
                return branch == null ? NotFound() : Ok(branch);
            }catch (Exception ex)
            {
                return BadRequest("Can not add new branch");
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, BranchModel model)
        {
            await _bookRepo.UpdateBranchAsync(id, model);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook([FromRoute]int id)
        {
            await _bookRepo.DeleteBranchesAsync(id);
            return Ok();
        }

    }
}
