using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebAppScrutor.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public string GetCustomerEmail(Guid id)
        {
            return $"{id}@company.com";
        }
    }
}
