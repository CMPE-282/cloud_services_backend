using System.Collections.Generic;

namespace CloudServiceProjectApi.Models.Repositories
{
    public interface IPaymentRepository
    {
        IEnumerable<payment> GetAllByCustomerNumber(int customerNumber);
        IEnumerable<payment> GetAll(int page, int count);
    }
}