using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace CodeInterview_Automation
{
    internal class REST_API_Test
    {
        public string baseURL_products = "https://fakestoreapi.com/products";
        public string baseURL_products2 = "https://fakestoreapi.com/users";

        public void TestResources()
        {
            //Setup
            var client_products = new RestClient(baseURL_products);
            var client_products2 = new RestClient(baseURL_products2);
            var request = new RestRequest();

            // Create resource
            var body = new post { userId = 1, name = "Benjamin", title = "Testing" };

            // Add body
            request.AddJsonBody(body);

            var response = client_products.GetAsync(request).Result;
            var response2 = client_products2.GetAsync(request).Result;

            Console.WriteLine(response.StatusCode.ToString() + "  " + response.Content.ToString());
            Console.WriteLine(response2.StatusCode.ToString() + "  " + response2.Content.ToString());
        }
    }
}
