using CloudServiceProjectApi.Infrastructure.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace CloudServiceProjectApi.Models.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        public IEnumerable<payment> GetAllByCustomerNumber(int customerNumber)
        {
            using (var context = new CloudServiceProjectEntities())
            {
                return context.customers
                    .FirstOrDefault(c => c.customerNumber == customerNumber)?
                    .payments
                    .ToList()
                    ?? Enumerable.Empty<payment>();
            }
        }

        public IEnumerable<payment> GetAll(int page, int count)
        {
            using (var context = new CloudServiceProjectEntities())
            {
                return context.payments
                    .OrderBy(p => p.customerNumber)
                    .ThenBy(p => p.checkNumber)
                    .GetPage(page, count)
                    .ToList();
            }
        }
    }
}