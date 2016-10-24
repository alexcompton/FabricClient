using Microsoft.ServiceFabric.Services.Remoting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface ITestService : IService
    {
        Task<string> GetCount();

        Task SetCount(long count);
    }
}
