using System.Collections.Generic;
using CloudServiceProjectApi.Models.Dtos;

namespace CloudServiceProjectApi.Models.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<product> GetAllByProductLine(string productLine);
        IEnumerable<product> GetAll(int page, int count);
        product GetByProductCode(string productCode);
    }
}