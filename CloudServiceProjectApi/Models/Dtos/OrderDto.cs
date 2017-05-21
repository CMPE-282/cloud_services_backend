using AutoMapper;
using System;
using System.Collections.Generic;

namespace CloudServiceProjectApi.Models.Dtos
{
    public class OrderDto
    {
        public int orderNumber { get; set; }
        public int customerNumber { get; set; }
        public DateTime? orderDate { get; set; }
        public DateTime? requiredDate { get; set; }
        public DateTime? shippedDate { get; set; }
        public string status { get; set; }
        public string comments { get; set; }
    }

    public static class OrderDtoExtensions
    {
        public static OrderDto ToDto(this order entity) => Mapper.Map<OrderDto>(entity);

        public static IEnumerable<OrderDto> ToDtoList(this IEnumerable<order> entities) => Mapper.Map<List<OrderDto>>(entities);
    }
}