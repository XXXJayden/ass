using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ass2.Data
{
    [Table("Branch")]
    public class Branch
    {
        [Key]
        public int BranchId { get; set; }
        [MaxLength(100)]
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
    }
}
