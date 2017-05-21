using AutoMapper;
using System.Collections.Generic;

namespace CloudServiceProjectApi.Models.Dtos
{
    public class CustomerDto
    {
        public int customerNumber { get; set; }
        public string customerName { get; set; }
        public string contactLastName { get; set; }
        public string contactFirstName { get; set; }
        public string phone { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }
        public int? salesRepEmployeeNumber { get; set; }
        public decimal? creditLimit { get; set; }
    }

    public static class CustomerDtoExtensions
    {
        public static IEnumerable<CustomerDto> ToDtoList(this IEnumerable<customer> entities) => Mapper.Map<List<CustomerDto>>(entities);

        public static CustomerDto ToDto(this customer entity) => Mapper.Map<CustomerDto>(entity);
    }
}