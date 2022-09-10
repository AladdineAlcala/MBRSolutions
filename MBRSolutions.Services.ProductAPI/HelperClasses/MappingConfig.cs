using AutoMapper;
using MBRSolutions.Services.ProductAPI.Model;
using MBRSolutions.Services.ProductAPI.Model._DTO;

namespace MBRSolutions.Web.HelperClasses
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
           return new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDTO, Product>().ReverseMap();
            });
        }
    }
}
