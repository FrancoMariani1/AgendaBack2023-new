using AgendaBack2023.Entities;
using AgendaBack2023.Models.DTO;
using AutoMapper;

namespace AgendaBack2023.Models.Profiles
{
    public class ContactProfile: Profile
    {
        public ContactProfile()
        {
            CreateMap<Contact, ContactDTO>();

            CreateMap<CreateAndUpdateContactDTO, Contact>();

            CreateMap<LocationDTO, Location>();
                
        }

        //private Location MapLocation(CreateAndUpdateContactDTO source)
        //{
        //    return new Location
        //    {
        //        latitude = source.location.latitude,
        //        longitude = source.location.longitude,
        //        description = source.location.description,
        //    };
        //}

    }
    
}
