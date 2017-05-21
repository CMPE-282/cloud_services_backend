using CloudServiceProjectApi.Models.Dtos;
using CloudServiceProjectApi.Models.Repositories;
using System.Collections.Generic;
using System.Web.Http;

namespace CloudServiceProjectApi.Controllers
{
    public class OrderDetailsController : ApiController
    {
        private readonly IOrderDetailRepository orderDetailRepository;

        public OrderDetailsController()
        {
            orderDetailRepository = new OrderDetailRepository();
        }

        public IEnumerable<OrderDetailDto> Get(int orderNumber) => orderDetailRepository.GetAllByOrderNumber(orderNumber).ToDtoList();

        public IEnumerable<OrderDetailDto> Get(int page = 1, int count = 250) => orderDetailRepository.GetAll(page, count).ToDtoList();
    }
}
