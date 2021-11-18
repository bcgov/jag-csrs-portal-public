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
                .ForMember(dest => dest.BCeID_Guid, opt => opt.MapFrom(src => src.BCeIDGuid.ToString()))
                .ForMember(dest => dest.Street1, opt => opt.MapFrom(src => src.AddressStreet1))
                .ForMember(dest => dest.Street2, opt => opt.MapFrom(src => src.AddressStreet2))
                .ForMember(dest => dest.AreaPostalCode, opt => opt.MapFrom(src => src.PostalCode))
                .ForMember(dest => dest.IdentityOtherDetails, opt => opt.MapFrom(src => src.Identity))
                ;

            CreateMap<Party, PortalAccount>()
                .ForMember(dest => dest.PartyGuid, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.BCeIDGuid, opt => opt.MapFrom(src => src.BCeID_Guid))
                .ForMember(dest => dest.AddressStreet1, opt => opt.MapFrom(src => src.Street1))
                .ForMember(dest => dest.AddressStreet2, opt => opt.MapFrom(src => src.Street2))
                .ForMember(dest => dest.PostalCode, opt => opt.MapFrom(src => src.AreaPostalCode))
                .ForMember(dest => dest.Identity, opt => opt.MapFrom(src => src.IdentityOtherDetails))
                ;
        }
    }
}
