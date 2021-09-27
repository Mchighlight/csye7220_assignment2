using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace mvc.Models
{
    public class RockStarModel
    {
        public string RockStar { get; set; }
 
        public RockStarModel()
        {
            RockStar = GetRockStarAsync().Result;
        }

        public HttpClient CreateRockStarClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/RockStarApi");
            return client;
        }

        public async Task<String> GetRockStarAsync()
        {
            using (var client = CreateRockStarClient())
            {
                HttpResponseMessage response;
                response = client.GetAsync(client.BaseAddress).Result;

                if (response.IsSuccessStatusCode)
                {
                    var rockstar = await response.Content.ReadAsStringAsync();
                    return rockstar;
                }
                else
                {
                    return "??";
                }
            }
        }
    }
}
