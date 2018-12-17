using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebAppScrutor.Repositories
{
    public interface ICustomerRepository
    {
        string GetCustomerEmail(Guid id);
    }
}
