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

        public void TestGetResources()
        {
            //Setup
            var client_products = new RestClient(baseURL_products);
            var client_products2 = new RestClient(baseURL_products2);
            var request = new RestRequest();

            var response = client_products.GetAsync(request).Result;
            var response2 = client_products2.GetAsync(request).Result;
            Console.WriteLine("Get Request: " + response.Content.ToString());
        }

        public async void TestPostResources()
        {
            HttpClient client = new HttpClient();
            var values = new Dictionary<string, string>
           {
               {"things1", "hello"},
               {"things2", "world"}
           };

            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync(baseURL_products, content);

            var responseString = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseString);
        }
   
    }
}
