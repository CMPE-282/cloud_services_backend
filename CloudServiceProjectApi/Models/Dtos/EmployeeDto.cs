using AutoMapper;
using System.Collections.Generic;

namespace CloudServiceProjectApi.Models.Dtos
{
    public class EmployeeDto
    {
        public int employeeNumber { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string extension { get; set; }
        public string email { get; set; }
        public string officeCode { get; set; }
        public int? reportsTo { get; set; }
        public string jobTitle { get; set; }
        public bool isManager { get; set; }
    }

    public static class EmployeeDtoExtensions
    {
        public static EmployeeDto ToDto(this employee entity) => Mapper.Map<EmployeeDto>(entity);

        public static IEnumerable<EmployeeDto> ToDtoList(this IEnumerable<employee> entities) => Mapper.Map<List<EmployeeDto>>(entities);
    }
}