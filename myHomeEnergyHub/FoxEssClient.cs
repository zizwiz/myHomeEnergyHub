using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class FoxEssClient
{
    private readonly HttpClient _client;

    public FoxEssClient(string apiKey)
    {
        _client = new HttpClient();
        _client.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", apiKey);
    }

    public async Task<T> GetAsync<T>(string url)
    {
        var response = await _client.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<T>(json);
    }

    public async Task<string> GetRawAsync(string url)
    {
        var response = await _client.GetAsync(url);

        string body = await response.Content.ReadAsStringAsync();

        Console.WriteLine("STATUS: " + response.StatusCode);
        Console.WriteLine("BODY: " + body);

        return body;
    }

}