using System.Collections.Generic;

namespace CloudServiceProjectApi.Models.Repositories
{
    public interface IOrderDetailRepository
    {
        IEnumerable<orderdetail> GetAllByOrderNumber(int orderNumber);
        IEnumerable<orderdetail> GetAll(int page, int count);
    }
}