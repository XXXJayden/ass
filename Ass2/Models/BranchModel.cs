using System.ComponentModel.DataAnnotations;
using static Ass2.Models.Enums;

namespace Ass2.Models
{
    public class BranchModel
    {
        public int BranchId { get; set; }
        [MaxLength(100)]
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public Status State { get; set; }
        public string? ZipCode { get; set; }

    }
}
