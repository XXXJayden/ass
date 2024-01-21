using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ass2.Data
{
    public class BranchContext : IdentityDbContext<ApplicationUser>
    {
        public BranchContext(DbContextOptions<BranchContext> options) : base(options) { 
        
        }
        #region
        public DbSet<Branch>? Branches { get; set;}
        #endregion
    }

}
