using CloudServiceProjectApi.Models.Dtos;
using CloudServiceProjectApi.Models.Repositories;
using System.Collections.Generic;
using System.Web.Http;

namespace CloudServiceProjectApi.Controllers
{
    public class EmployeesController : ApiController
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeesController()
        {
            employeeRepository = new EmployeeRepository();
        }

        public EmployeeDto Get(string email) => employeeRepository.GetByEmail(email)?.ToDto();

        public IEnumerable<EmployeeDto> Get(int page = 1, int count = 250) => employeeRepository.GetAll(page, count).ToDtoList();
    }
}
