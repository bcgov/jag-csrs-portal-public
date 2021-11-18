using AutoMapper;
using Csrs.Api.Models.Dynamics;

namespace Csrs.Api.Models.Mapping
{
    public class PortalAccountProfile : Profile
    {
        public PortalAccountProfile()
        {
            CreateMap<PortalAccount, Party>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.PartyGuid))
                .ForMember(dest => dest.IdentityOtherDetails, opt => opt.MapFrom(src => src.Identity))
                ;

            CreateMap<Party, PortalAccount>()
                .ForMember(dest => dest.PartyGuid, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Identity, opt => opt.MapFrom(src => src.IdentityOtherDetails))
                ;
        }
    }
}
