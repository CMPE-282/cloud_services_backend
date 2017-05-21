using CloudServiceProjectApi.Infrastructure.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CloudServiceProjectApi.Models.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public IEnumerable<customer> GetAllBySalesRepresentativeEmployeeNumber(int salesRepresentativeEmployeeNumber)
        {
            using (var context = new CloudServiceProjectEntities())
            {
                return context.employees
                    .FirstOrDefault(e => e.employeeNumber == salesRepresentativeEmployeeNumber)?
                    .customers
                    .ToList()
                    ?? Enumerable.Empty<customer>();
            }
        }

        public IEnumerable<customer> GetAll(int page, int count)
        {
            using (var context = new CloudServiceProjectEntities())
            {
                return context.customers
                    .OrderBy(c => c.customerNumber)
                    .GetPage(page, count)
                    .ToList();
            }
        }
    }
}