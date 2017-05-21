using CloudServiceProjectApi.Infrastructure.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace CloudServiceProjectApi.Models.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public IEnumerable<order> GetAllByCustomerNumber(int customerNumber)
        {
            using (var context = new CloudServiceProjectEntities())
            {
                return context.customers
                    .FirstOrDefault(c => c.customerNumber == customerNumber)
                    .orders
                    .ToList()
                    ?? Enumerable.Empty<order>();
            }
        }

        public IEnumerable<order> GetAll(int page, int count)
        {
            using (var context = new CloudServiceProjectEntities())
            {
                return context.orders
                    .OrderBy(o => o.orderNumber)
                    .GetPage(page, count)
                    .ToList();
            }
        }
    }
}