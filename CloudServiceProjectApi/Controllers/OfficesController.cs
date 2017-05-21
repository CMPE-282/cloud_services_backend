using CloudServiceProjectApi.Models.Dtos;
using CloudServiceProjectApi.Models.Repositories;
using System.Collections.Generic;
using System.Web.Http;

namespace CloudServiceProjectApi.Controllers
{
    public class OfficesController : ApiController
    {
        private readonly IOfficeRepository officeRepository;

        public OfficesController()
        {
            officeRepository = new OfficeRepository();
        }

        public OfficeDto Get(string officeCode) => officeRepository.GetByOfficeCode(officeCode)?.ToDto();

        public IEnumerable<OfficeDto> Get() => officeRepository.GetAll().ToDtoList();
    }
}
