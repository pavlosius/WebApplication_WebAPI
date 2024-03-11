using AutoMapper;
using HomeApi.Contracts.Models.Home;
using Microsoft.AspNetCore.Identity.Data;
using WebApplication_WebAPI.Configuration;

namespace HomeAPI
{
    /// <summary>
    /// Настройки маппинга всех сущностей приложения
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>
        /// В конструкторе настроим соответствие сущностей при маппинге
        /// </summary>
        public MappingProfile()
        {
            CreateMap<Address, AddressInfo>();
            CreateMap<HomeOptions, HomeApi.Contracts.Models.Home.InfoResponse>()
                .ForMember(m => m.AddressInfo,
                    opt => opt.MapFrom(src => src.Address));
        }
    }
}
