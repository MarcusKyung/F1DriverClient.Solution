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
  }
}