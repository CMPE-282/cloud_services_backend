using CloudServiceProjectApi.Infrastructure.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CloudServiceProjectApi.Models.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public IEnumerable<employee> GetAll(int page, int count)
        {
            using (var context = new CloudServiceProjectEntities())
            {
                return context.employees
                    .OrderBy(e => e.employeeNumber)
                    .GetPage(page, count)
                    .ToList();
            }
        }

        public employee GetByEmail(string emailAddress)
        {
            if (emailAddress.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(emailAddress));
            }

            using (var context = new CloudServiceProjectEntities())
            {
                return context.employees
                    .FirstOrDefault(e => emailAddress.Equals(e.email, StringComparison.OrdinalIgnoreCase));
            }
        }

        public employee GetById(int employeeNumber)
        {
            using (var context = new CloudServiceProjectEntities())
            {
                return context.employees.FirstOrDefault(e => e.employeeNumber == employeeNumber);
            }
        }
    }
}