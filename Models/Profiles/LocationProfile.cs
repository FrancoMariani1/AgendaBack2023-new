using AgendaBack2023.Entities;
using AgendaBack2023.Models.DTO;
using AutoMapper;

namespace AgendaBack2023.Models.Profiles
{
    public class LocationProfile: Profile
    {
        public LocationProfile()
        {
            CreateMap<Location, LocationDTO>();
            CreateMap<CreateAndUpdateLocationDTO, Location>();
                //.ForMember(dest => dest.id, opt => opt.Ignore());
        }
    }
}
