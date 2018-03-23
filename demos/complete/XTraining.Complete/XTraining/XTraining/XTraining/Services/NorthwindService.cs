using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace XTraining.Services
{
    public interface INorthwindService
    {
        Task<IList<Models.Customer>> GetCustomersAsync(int? limit = null);
        Task<IList<Models.Product>> GetProductsAsync(int? limit = null);
        Task<IList<Models.Order>> GetOrdersAsync(int? limit = null);
    }

    public class NorthwindService : INorthwindService
    {
        public NorthwindService()
        {
            client = new HttpClient();
        }

        private HttpClient client;
        private static string baseServiceUrl = "192.168.1.104:3000";

        public async Task<IList<Models.Customer>> GetCustomersAsync(int? limit = null)
        {
            string requestUri = CreateRequest("customers", limit);
            var content = await ExecuteRequest(requestUri);
            if (content == null)
                return null;

            List<Models.Customer> data = JsonConvert.DeserializeObject<List<Models.Customer>>(content);
            return data;
        }

        public async Task<IList<Models.Product>> GetProductsAsync(int? limit = null)
        {
            string requestUri = CreateRequest("products", limit);
            var content = await ExecuteRequest(requestUri);
            if (content == null)
                return null;

            List<Models.Product> data = JsonConvert.DeserializeObject<List<Models.Product>>(content);
            return data;
        }

        public async Task<IList<Models.Order>> GetOrdersAsync(int? limit = null)
        {
            string requestUri = CreateRequest("orders", limit);
            var content = await ExecuteRequest(requestUri);
            if (content == null)
                return null;

            List<Models.Order> data = JsonConvert.DeserializeObject<List<Models.Order>>(content);
            return data;
        }

        private string CreateRequest(string resource, int? limit)
        {
            string filter = string.Empty;
            if (limit != null)
                filter = $"?_limit={limit.Value}";
            string requestUrl = $"http://{baseServiceUrl}/{resource}{filter}";
            return requestUrl;
        }

        private async Task<string> ExecuteRequest(string requestUri)
        {
            HttpResponseMessage response = null;
            try
            {
                response = await client.GetAsync(requestUri);
            }
            catch
            {
                return null;
            }

            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadAsStringAsync();
        }
    }
}
