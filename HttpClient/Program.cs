// See https://aka.ms/new-console-template for more information
using System.Net.Http;
using System.Text.Json;
using System.Text;

   HttpClient _httpClient = new HttpClient();

string url = "https://jsonplaceholder.typicode.com/posts";

var postData = new
{
    title = "foo",
    body = "bar",
    userId = 1
};

string json = JsonSerializer.Serialize(postData);


var content = new StringContent(json, Encoding.UTF8, "application/json");


HttpResponseMessage response = await _httpClient.PostAsync(url, content);


if (response.IsSuccessStatusCode)
{
    
    string responseBody = await response.Content.ReadAsStringAsync();
    Console.WriteLine("Response from server:");
    Console.WriteLine(responseBody);
}
else
{
    Console.WriteLine($"Error: {response.StatusCode}");
}