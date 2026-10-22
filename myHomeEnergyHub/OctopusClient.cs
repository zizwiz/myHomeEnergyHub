using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class OctopusClient
{
    private readonly HttpClient _client;

    public OctopusClient(string apiKey)
    {
        _client = new HttpClient();
        var byteArray = System.Text.Encoding.ASCII.GetBytes(apiKey + ":");
        _client.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
    }

    public async Task<ConsumptionResponse> GetConsumptionAsync(string url)
    {
        var response = await _client.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<ConsumptionResponse>(json);
    }
}

public class ConsumptionResponse
{
    public ConsumptionItem[] results { get; set; }
}

public class ConsumptionItem
{
    public DateTime interval_start { get; set; }
    public DateTime interval_end { get; set; }
    public decimal consumption { get; set; }
}
