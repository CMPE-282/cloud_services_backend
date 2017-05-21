using System.Collections.Generic;

namespace CloudServiceProjectApi.Models.Repositories
{
    public interface IOfficeRepository
    {
        office GetByOfficeCode(string officeCode);
        IEnumerable<office> GetAll();
    }
}