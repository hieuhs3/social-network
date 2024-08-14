using Data.Entity;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
namespace Services
{
    public class ProductService: IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly MapperService _mappingService;
        public ProductService(IProductRepository productRepository, MapperService mappingService)
        {
            _productRepository = productRepository;
            _mappingService = mappingService;
        }
        public List<ProductDto> GetProducts()
        {
            var output = _productRepository.GetAllAsync().GetAwaiter().GetResult().ToList();

            return _mappingService.MapEntityListToDtoList<Product, ProductDto>(output);
        }

    }
    public interface IProductService
    {
        List<ProductDto> GetProducts();
    }
}
