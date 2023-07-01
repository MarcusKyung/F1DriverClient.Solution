using System.Threading.Tasks;
using RestSharp;

namespace F1DriverClient.Models
{
  public class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("https://localhost:5001/");
      RestRequest request = new RestRequest($"api/v2/teams", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("https://localhost:5001/");
      RestRequest request = new RestRequest($"api/v2/teams/{id}", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }

    public static async void Post (string newTeam)
    {
      RestClient client = new RestClient("https://localhost:5001/");
      RestRequest request = new RestRequest($"api/v2/teams", Method.Post);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newTeam);
      RestResponse response = await client.ExecuteAsync(request);
    }

    public static async void Put (int id, string newTeam)
    {
      RestClient client = new RestClient("https://localhost:5001/");
      RestRequest request = new RestRequest($"api/v2/teams/{id}", Method.Put);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newTeam);
      await client.ExecuteAsync(request);
    }
  }
}