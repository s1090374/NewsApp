using NewsApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Services
{
    class ApiService
    {

        public async Task<Root> GetNews(string categoryName)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync($"https://gnews.io/api/v4/top-headlines?category=general&lang=en&country={categoryName.ToLower()}&apikey=d5e56396c7628cc8e6accaced8a3ba80");
            return JsonConvert.DeserializeObject<Root>(response);
        }
    }
}
