using Microsoft.ServiceFabric.Services.Client;
using Microsoft.ServiceFabric.Services.Remoting.Client;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Client
    {
        private ITestService fabricClient;
        private int id;

        public Client(int _id)
        {
            fabricClient = ServiceProxy.Create<ITestService>(new Uri("fabric:/FabricService/Service"), new ServicePartitionKey(_id));
            id = _id;
        }

        public async Task<string> GetFromService()
        {
            var message = await fabricClient.GetCount();
            return message;
        }

        public async Task<string> SetToService(long value)
        {
            await fabricClient.SetCount(value);
            return String.Format("id: {0} has been set to {1}", id, value);
        }
    }
}
