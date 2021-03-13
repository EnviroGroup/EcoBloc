using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using EcoBlocApp_test.Models;
using static EcoBlocApp_test.Models.News;

namespace EcoBlocApp_test.Services
{
    public class GetNews
    {
        public async Task<List<Article>> GetNewsArticles()
        {
            string body;
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://newscatcher.p.rapidapi.com/v1/search?q=Environement&lang=en&sort_by=relevancy&country=ZA&page=1&media=True"),
                Headers =
                        {
                            { "x-rapidapi-key", "b5eb8cc70emsh5e50bb2fba37fbep10a6eajsnade2441e370a" },
                            { "x-rapidapi-host", "newscatcher.p.rapidapi.com" },
                        },
            };
           
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                body = await response.Content.ReadAsStringAsync();

            }

            var news = JsonConvert.DeserializeObject<Root>(body);

            return news.articles;

        }

    }
}
