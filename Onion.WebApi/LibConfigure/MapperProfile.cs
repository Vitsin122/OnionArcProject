using AutoMapper;
using OnionArcProject.Domain.Models;
using OnionArcProject.Domain.ModelsDTO;

namespace Onion.WebApi.LibConfigure
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Gpu, GpuModelDTO>();
            CreateMap<Vender, VenderModelDTO>();
        }
    }
}
