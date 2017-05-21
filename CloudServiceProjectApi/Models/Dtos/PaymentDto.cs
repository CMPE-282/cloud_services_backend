using AutoMapper;
using System;
using System.Collections.Generic;

namespace CloudServiceProjectApi.Models.Dtos
{
    public class PaymentDto
    {
        public int customerNumber { get; set; }
        public string checkNumber { get; set; }
        public DateTime paymentDate { get; set; }
        public decimal amount { get; set; }
    }

    public static class PaymentDtoExtensions
    {
        public static PaymentDto ToDto(this payment entity) => Mapper.Map<PaymentDto>(entity);

        public static IEnumerable<PaymentDto> ToDtoList(this IEnumerable<payment> entities) => Mapper.Map<List<PaymentDto>>(entities);
    }
}