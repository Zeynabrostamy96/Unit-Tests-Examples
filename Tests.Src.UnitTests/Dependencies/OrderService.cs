using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Src.UnitTests.Dependencies
{
    public class ApiClient:IApiClient
    {
        public string GetKay(string user) => "access_token";
    }

    public interface IApiClient
    {
         string GetKay(string user);
    }

    public class OrderService
    {
        private readonly IApiClient _client;
        public OrderService(IApiClient client)
        {
            _client = client;
        }
        public bool SendDate(string orderDate) 
        {
            try 
            {
                _client.GetKay(orderDate);
               return true;
            }
            catch(Exception ex)
            { 
                //log
                return false;
            }
        }
    }
}
