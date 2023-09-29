using AutoMapper;
using TestTask.DataBase.Entities;
using TestTask.Models;

namespace TestTask.MappingProfiles
{
    public class OrderProfile :  Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderModel>();
        }
    }
}
