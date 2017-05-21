using CloudServiceProjectApi.Infrastructure.Extensions;
using System.Collections.Generic;
using System.Linq;
using CloudServiceProjectApi.Models.Dtos;
using System;

namespace CloudServiceProjectApi.Models.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<product> GetAllByProductLine(string productLine)
        {
            using (var context = new CloudServiceProjectEntities())
            {
                return context.productlines
                    .FirstOrDefault(pl => pl.productLine1 == productLine)
                    .products
                    .ToList()
                    ?? Enumerable.Empty<product>();
            }
        }

        public IEnumerable<product> GetAll(int page, int count)
        {
            using (var context = new CloudServiceProjectEntities())
            {
                return context.products
                    .OrderBy(p => p.productCode)
                    .GetPage(page, count)
                    .ToList();
            }
        }

        public product GetByProductCode(string productCode)
        {
            using (var context = new CloudServiceProjectEntities())
            {
                return context.products
                    .FirstOrDefault(p => p.productCode.Equals(productCode, StringComparison.OrdinalIgnoreCase));
            }
        }
    }
}