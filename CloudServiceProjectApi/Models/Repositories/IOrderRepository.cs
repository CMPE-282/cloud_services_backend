using System.Collections.Generic;

namespace CloudServiceProjectApi.Models.Repositories
{
    public interface IOrderRepository
    {
        IEnumerable<order> GetAllByCustomerNumber(int customerNumber);
        IEnumerable<order> GetAll(int page, int count);
    }
}