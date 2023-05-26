using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HttpRequest
{
    public class HttpSender
    {
        public async void GetRequest()
        {
            using (HttpClient client = new HttpClient())
            {
                var url = "https://example.com";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Response:");
                Console.WriteLine(responseBody);
            }
        }

        public async void PostRequest()
        {
            using (HttpClient client = new HttpClient())
            {
                var url = "https://example.com";
                HttpResponseMessage response = await client.PostAsync(url, new StringContent("example"));
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Response:");
                Console.WriteLine(responseBody);
            }
        }

        public async void PutRequest()
        {
            using (HttpClient client = new HttpClient())
            {
                var url = "https://example.com";
                HttpResponseMessage response = await client.PutAsync(url, new StringContent("example"));
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Response:");
                Console.WriteLine(responseBody);
            }
        }

        public async void DeleteRequest()
        {
            using (HttpClient client = new HttpClient())
            {
                var url = "https://example.com";
                HttpResponseMessage response = await client.DeleteAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Response:");
                Console.WriteLine(responseBody);
            }
        }
    }
}
