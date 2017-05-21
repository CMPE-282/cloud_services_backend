using CloudServiceProjectApi.Infrastructure.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace CloudServiceProjectApi.Models.Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public IEnumerable<orderdetail> GetAllByOrderNumber(int orderNumber)
        {
            using (var context = new CloudServiceProjectEntities())
            {
                return context.orders
                    .FirstOrDefault(o => o.orderNumber == orderNumber)?
                    .orderdetails
                    .ToList()
                    ?? Enumerable.Empty<orderdetail>();
            }
        }

        public IEnumerable<orderdetail> GetAll(int page, int count)
        {
            using (var context = new CloudServiceProjectEntities())
            {
                return context.orderdetails
                    .Include("product")
                    .OrderBy(od => od.orderNumber)
                    .ThenBy(od => od.productCode)
                    .GetPage(page, count)
                    .ToList();
            }
        }
    }
}