using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class HttpService
    {
        private static readonly HttpClient _httpClient = new HttpClient();

       
        public async Task<string> GetContentAsync(string url)
        {
            try
            {
                
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                
                response.EnsureSuccessStatusCode();

                
                string content = await response.Content.ReadAsStringAsync();
                return content;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
                return null; 
            }
        }


    }
}
