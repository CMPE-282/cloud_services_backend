using CloudServiceProjectApi.Models.Dtos;
using CloudServiceProjectApi.Models.Repositories;
using System.Collections.Generic;
using System.Web.Http;

namespace CloudServiceProjectApi.Controllers
{
    public class OrdersController : ApiController
    {
        private readonly IOrderRepository orderRepository;

        public OrdersController()
        {
            orderRepository = new OrderRepository();
        }

        public IEnumerable<OrderDto> Get(int customerNumber) => orderRepository.GetAllByCustomerNumber(customerNumber).ToDtoList();

        public IEnumerable<OrderDto> Get(int page = 1, int count = 250) => orderRepository.GetAll(page, count).ToDtoList();
    }
}
