using AutoMapper;
using System.Collections.Generic;

namespace CloudServiceProjectApi.Models.Dtos
{
    public class OrderDetailDto
    {
        public int orderNumber { get; set; }
        public string productCode { get; set; }
        public int quantityOrdered { get; set; }
        public decimal priceEach { get; set; }
        public short orderLineNumber { get; set; }
        public string productLine { get; set; }
    }

    public static class OrderDetailDtoExtensions
    {
        public static OrderDetailDto ToDto(this orderdetail entity) => Mapper.Map<OrderDetailDto>(entity);

        public static IEnumerable<OrderDetailDto> ToDtoList(this IEnumerable<orderdetail> entities) => Mapper.Map<List<OrderDetailDto>>(entities);
    }
}