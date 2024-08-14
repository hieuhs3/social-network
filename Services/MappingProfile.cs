
using AutoMapper;
using Data.Entity;
using Dto;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Cấu hình mapping từ Product sang ProductDto
            CreateMap<Product, ProductDto>();

            // Nếu cần, bạn có thể cấu hình mapping ngược lại
            CreateMap<ProductDto, Product>();
        }
    }
}
