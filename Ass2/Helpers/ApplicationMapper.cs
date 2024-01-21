using Ass2.Data;
using Ass2.Models;
using AutoMapper;

namespace Ass2.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper() {
            CreateMap<Branch,BranchModel >().ReverseMap();
        }
    }
}
