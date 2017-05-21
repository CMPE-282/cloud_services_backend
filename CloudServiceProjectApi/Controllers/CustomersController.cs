using CloudServiceProjectApi.Models.Dtos;
using CloudServiceProjectApi.Models.Repositories;
using System.Collections.Generic;
using System.Web.Http;

namespace CloudServiceProjectApi.Controllers
{
    public class CustomersController : ApiController
    {
        private readonly ICustomerRepository customerRepository;

        public CustomersController()
        {
            customerRepository = new CustomerRepository();
        }

        public IEnumerable<CustomerDto> Get(int salesRepEmployeeNumber) =>
            customerRepository.GetAllBySalesRepresentativeEmployeeNumber(salesRepEmployeeNumber).ToDtoList();

        public IEnumerable<CustomerDto> Get(int page = 1, int count = 250) => customerRepository.GetAll(page, count).ToDtoList();
    }
}
