using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Timers;
using Newtonsoft.Json;

namespace RESTConsumer
{
    public class RESTConsumer
    { 
        // GET https://jsonplaceholder.typicode.com/todos
        // GET https://jsonplaceholder.typicode.com/todos/3
        // DELETE https://jsonplaceholder.typicode.com/todos/3
        // POST https://jsonplaceholder.typicode.com/todos
        // PUT https://jsonplaceholder.typicode.com/todos/3

        public void Start()
        {
            Stopwatch t = new Stopwatch();
            Console.WriteLine("GETALL https://jsonplaceholder.typicode.com/todos");
            t.Start();
            IList<RESTData> dataL = GetAll("https://jsonplaceholder.typicode.com/todos");
            Console.WriteLine(dataL[0].id + dataL[0].userId + dataL[0].title);
            t.Stop();
            Console.WriteLine($"Time elapsed {t.Elapsed}\n");

            Console.WriteLine("GETONE https://jsonplaceholder.typicode.com/todos/3");
            t.Reset();
            t.Start();
            Console.WriteLine(GetOne("https://jsonplaceholder.typicode.com/todos/3").userId);
            Console.WriteLine($"Time elapsed {t.Elapsed}\n");

            Console.WriteLine("DELETE https://jsonplaceholder.typicode.com/todos/3");
            t.Reset();
            t.Start();
            Console.WriteLine(Delete("https://jsonplaceholder.typicode.com/todos/3"));
            Console.WriteLine($"Time elapsed {t.Elapsed}\n");

            Console.WriteLine("POST https://jsonplaceholder.typicode.com/todos");
            t.Reset();
            t.Start();
            Console.WriteLine(Post(new RESTData(10, 20, "1020"), "https://jsonplaceholder.typicode.com/todos"));
            Console.WriteLine($"Time elapsed {t.Elapsed}\n");

            Console.WriteLine("PUT https://jsonplaceholder.typicode.com/todos/3");
            t.Reset();
            t.Start();
            Console.WriteLine(Put(new RESTData(1, 1, "1020"), "https://jsonplaceholder.typicode.com/todos/3"));
            Console.WriteLine($"Time elapsed {t.Elapsed}\n");
            t.Reset();

            Console.WriteLine("All done!");
        }

        private IList<RESTData> GetAll(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                return JsonConvert.DeserializeObject<IList<RESTData>>(client.GetStringAsync(url).Result);
            }
        }

        private RESTData GetOne(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                return JsonConvert.DeserializeObject<RESTData>(client.GetStringAsync(url).Result);
            }
        }

        private bool Delete(string url)
        {
            using (HttpClient client = new HttpClient())
            { 
                return client.DeleteAsync(url).Result.IsSuccessStatusCode;
            }
        }

        private bool Post(RESTData restData, string url)
        {
            string json = JsonConvert.SerializeObject(restData);
            StringContent content = new StringContent(json);

            using (HttpClient client = new HttpClient())
            {
                return client.PostAsync(url, content).Result.IsSuccessStatusCode;

            }
        }

        private bool Put(RESTData restData, string url)
        {
            string json = JsonConvert.SerializeObject(restData);
            StringContent content = new StringContent(json);

            using (HttpClient client = new HttpClient())
            {
                return client.PutAsync(url, content).Result.IsSuccessStatusCode;
            }
        }

    }
}