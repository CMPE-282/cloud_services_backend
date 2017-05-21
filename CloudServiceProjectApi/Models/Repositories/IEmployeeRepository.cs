using System.Collections.Generic;

namespace CloudServiceProjectApi.Models.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<employee> GetAll(int page = 1, int count = 250);
        employee GetByEmail(string emailAddress);
        employee GetById(int employeeNumber);
    }
}