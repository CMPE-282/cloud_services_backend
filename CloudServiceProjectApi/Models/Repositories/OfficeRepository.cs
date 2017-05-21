using CloudServiceProjectApi.Infrastructure.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CloudServiceProjectApi.Models.Repositories
{
    public class OfficeRepository : IOfficeRepository
    {
        public office GetByOfficeCode(string officeCode)
        {
            if (officeCode.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(officeCode));
            }

            using (var context = new CloudServiceProjectEntities())
            {
                return context.offices
                    .FirstOrDefault(o => officeCode.Equals(o.officeCode, StringComparison.OrdinalIgnoreCase));
            }
        }

        public IEnumerable<office> GetAll()
        {
            using (var context = new CloudServiceProjectEntities())
            {
                return context.offices.ToList();
            }
        }
    }
}