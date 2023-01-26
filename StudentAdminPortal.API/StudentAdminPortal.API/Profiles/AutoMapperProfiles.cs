using AutoMapper;
using StudentAdminPortal.API.DataModels;
using StudentAdminPortal.API.DomainModels;

namespace StudentAdminPortal.API.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModels.Student, DomainModels.Student>();
            CreateMap<DataModels.Gender, DomainModels.Gender>();
            CreateMap<DataModels.Address, DomainModels.Address>();
        }
    }
}
