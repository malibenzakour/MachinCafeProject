using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MachineCafeProject.ViewModel;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace MachineCafeProject.Service
{
    public class ServiceMachine
    {
        private static readonly HttpClient client;
        static ServiceMachine()
        {
            client = new HttpClient();
        }


        public async Task<List<Article>> GetItems(string cat)
        {
            Uri uri = new Uri(string.Format("http://10.0.2.2:53112/Articles/{0}",cat));

            var httpResponse = AsyncToSync.ConvertToSync(() => client.GetAsync(uri));

            var contentStream = await httpResponse.Content.ReadAsStreamAsync();

            var streamReader = new StreamReader(contentStream);
            var jsonReader = new JsonTextReader(streamReader);

            JsonSerializer serializer = new JsonSerializer();

            try
            {
                return serializer.Deserialize<List<Article>>(jsonReader);
            }
            catch (JsonReaderException)
            {
                Console.WriteLine("Invalid JSON.");
            }

            return null;
        }

        public  async Task<string> AddItem(int id)
        {
            Uri uri = new Uri(string.Format("http://10.0.2.2:53112/Historique"));
            var historique = new Historique() { IdArticle = id, DateAchat = DateTime.Now };
            var json = JsonConvert.SerializeObject(historique);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(uri, data);

            string result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
            

            return "ok";
        }


        
    }
}
