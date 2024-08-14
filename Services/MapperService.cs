using AutoMapper;
using Data.Entity;
using Dto;

namespace Services
{
    public class MapperService
    {
        private readonly IMapper _mapper;

        public MapperService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public ProductDto ConvertEntityToDto(Product product)
        {
            return MapEntityToDto<Product, ProductDto>(product);
        }

        public Product ConvertDtoToEntity(ProductDto productDto)
        {
            return MapDtoToEntity<ProductDto, Product>(productDto);
        }


        public TDto MapEntityToDto<TEntity, TDto>(TEntity entity)
        where TEntity : class
        where TDto : class
        {
            return _mapper.Map<TDto>(entity);
        }

        public TEntity MapDtoToEntity<TDto, TEntity>(TDto dto)
            where TDto : class
            where TEntity : class
        {
            return _mapper.Map<TEntity>(dto);
        }
        public List<TEntity> MapDtoListToEntityList<TDto, TEntity>(List<TDto> dtoList)
        where TDto : class
        where TEntity : class
        {
            return _mapper.Map<List<TEntity>>(dtoList);
        }
        public List<TDto> MapEntityListToDtoList<TEntity, TDto>(List<TEntity> entityList)
        where TEntity : class
        where TDto : class
        {
            return _mapper.Map<List<TDto>>(entityList);
        }

    }
}
