using AutoMapper;
using System.Collections.Generic;

namespace CloudServiceProjectApi.Models.Dtos
{
    public class ProductDto
    {
        public string productCode { get; set; }
        public string productName { get; set; }
        public string productLine { get; set; }
        public string productScale { get; set; }
        public string productVendor { get; set; }
        public string productDescription { get; set; }
        public short quantityInStock { get; set; }
        public decimal buyPrice { get; set; }
        public decimal MSRP { get; set; }
    }

    public static class ProductDtoExtensions
    {
        public static ProductDto ToDto(this product entity) => Mapper.Map<ProductDto>(entity);

        public static IEnumerable<ProductDto> ToDtoList(this IEnumerable<product> entities) => Mapper.Map<List<ProductDto>>(entities);
    }
}