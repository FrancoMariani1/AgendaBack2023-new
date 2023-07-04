using AgendaBack2023.Entities;
using AgendaBack2023.Models.DTO;
using AutoMapper;

namespace AgendaBack2023.Models.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, CreateAndUpdateUserDTO>();
            CreateMap<User, UserDTO>();
            CreateMap<CreateAndUpdateUserDTO, User>();
            CreateMap<UserDTO, User>();
        }
    }
}
