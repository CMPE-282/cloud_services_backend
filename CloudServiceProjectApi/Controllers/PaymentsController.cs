using CloudServiceProjectApi.Models.Dtos;
using CloudServiceProjectApi.Models.Repositories;
using System.Collections.Generic;
using System.Web.Http;

namespace CloudServiceProjectApi.Controllers
{
    public class PaymentsController : ApiController
    {
        private readonly IPaymentRepository paymentRepository;

        public PaymentsController()
        {
            paymentRepository = new PaymentRepository();
        }

        public IEnumerable<PaymentDto> Get(int customerNumber) => paymentRepository.GetAllByCustomerNumber(customerNumber).ToDtoList();

        public IEnumerable<PaymentDto> Get(int page = 1, int count = 250) => paymentRepository.GetAll(page, count).ToDtoList();
    }
}
