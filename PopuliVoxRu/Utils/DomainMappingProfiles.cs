using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using PopuliVoxRu.Domain.Core.Models.Identity;
using PopuliVoxRu.Domain.Core.Models.Shared;

namespace PopuliVoxRu.Utils
{
    public class DomainMappingProfiles : Profile
    {
        public DomainMappingProfiles()
        {
            // User identity:
            CreateMap<UserRegisterModel, UserRegisterModel>()
                .ReverseMap();


            // Common:
            CreateMap<ListItemModel, SelectListItem>()
                .ForMember(dest => dest.Value, src => src.MapFrom(x => x.Id))
                .ReverseMap();
        }
    }
}
