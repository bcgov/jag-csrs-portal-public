using AutoMapper;
using Csrs.Api.Models.Dynamics;

namespace Csrs.Api.Models.Mapping
{
    public class PortalAccountProfile : Profile
    {
        public PortalAccountProfile()
        {
            CreateMap<PortalAccount, SSG_CsrsParty>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.PartyGuid))
                .ForMember(dest => dest.IdentityOtherDetails, opt => opt.MapFrom(src => src.Identity))
                ;

            CreateMap<SSG_CsrsParty, PortalAccount>()
                .ForMember(dest => dest.PartyGuid, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Identity, opt => opt.MapFrom(src => src.IdentityOtherDetails))
                ;
        }
    }
}
