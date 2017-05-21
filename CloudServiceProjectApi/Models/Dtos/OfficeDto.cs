using AutoMapper;
using System.Collections.Generic;

namespace CloudServiceProjectApi.Models.Dtos
{
    public class OfficeDto
    {
        public string officeCode { get; set; }
        public string city { get; set; }
        public string phone { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string postalCode { get; set; }
        public string territory { get; set; }
    }

    public static class OfficeDtoExtensions
    {
        public static OfficeDto ToDto(this office entity) => Mapper.Map<OfficeDto>(entity);

        public static IEnumerable<OfficeDto> ToDtoList(this IEnumerable<office> entities) => Mapper.Map<List<OfficeDto>>(entities);
    }
}