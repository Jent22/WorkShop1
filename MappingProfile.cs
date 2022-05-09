using AutoMapper;
using WebApplication7.Models;

namespace WebApplication7
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ChipsRequest, Chips>()
            .ForMember(d => d.Avalibility, o => o.MapFrom(s => s.Disponibilidad))
            .ForMember(d => d.Brand, o => o.MapFrom(s => s.Marca))
            .ForMember(d => d.HealthV, o => o.MapFrom(s => s.VSalud))
            .ForMember(d => d.Quality, o => o.MapFrom(s => s.Calidad))
            .ForMember(d => d.ExpDate, o => o.MapFrom(s => s.FechaExp));
        }
    }
}
