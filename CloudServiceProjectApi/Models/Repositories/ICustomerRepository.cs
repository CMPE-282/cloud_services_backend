using System.Collections.Generic;

namespace CloudServiceProjectApi.Models.Repositories
{
    public interface ICustomerRepository
    {
        IEnumerable<customer> GetAllBySalesRepresentativeEmployeeNumber(int salesRepresentativeEmployeeNumber);
        IEnumerable<customer> GetAll(int page = 1, int count = 250);
    }
}