using CloudServiceProjectApi.Models.Dtos;
using CloudServiceProjectApi.Models.Repositories;
using System.Collections.Generic;
using System.Web.Http;

namespace CloudServiceProjectApi.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly IProductRepository productRepository;

        public ProductsController()
        {
            productRepository = new ProductRepository();
        }

        public IEnumerable<ProductDto> GetAllByProductLine(string productLine) => productRepository.GetAllByProductLine(productLine).ToDtoList();

        public IEnumerable<ProductDto> Get(int page = 1, int count = 250) => productRepository.GetAll(page, count).ToDtoList();

        public ProductDto GetByProductCode(string productCode) => productRepository.GetByProductCode(productCode).ToDto();
    }
}
