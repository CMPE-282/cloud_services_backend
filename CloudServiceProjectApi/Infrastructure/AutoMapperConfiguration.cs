using AutoMapper;
using CloudServiceProjectApi.Models;
using CloudServiceProjectApi.Models.Dtos;

namespace CloudServiceProjectApi.Infrastructure
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(c =>
            {
                c.CreateMap<employee, EmployeeDto>();
                c.CreateMap<customer, CustomerDto>();
                c.CreateMap<order, OrderDto>();
                c.CreateMap<office, OfficeDto>();
                c.CreateMap<orderdetail, OrderDetailDto>()
                    .ForMember(dto => dto.productLine, opts => opts.MapFrom(entity => entity.product.productLine));
                c.CreateMap<payment, PaymentDto>();
                c.CreateMap<product, ProductDto>();
            });
        }
    }
}