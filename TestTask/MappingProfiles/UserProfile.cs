using AutoMapper;
using TestTask.DataBase.Entities;
using TestTask.Models;

namespace TestTask.MappingProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserModel>()
                .ForMember(model => model.NumberOfOrders,
                opt => opt.MapFrom(ent => ent.Orders.Count))
                .ForMember(model => model.Status,
                opt => opt.MapFrom(ent => ent.Status));
        }
    }
}
