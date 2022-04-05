using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroductionToApi.ConsoleApp.Models;
using Newtonsoft.Json;

namespace IntroductionToApi.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient httpclient = new HttpClient();

            HttpResponseMessage response = httpclient.GetAsync("http://acnhapi.com/v1/villagers/1").Result;

            if (response.IsSuccessStatusCode)
            {
                // var content = response.Content.ReadAsStringAsync().Result;
                // var person = JsonConvert.DeserializeObject<Person>(content);

                Person cyrano = response.Content.ReadAsAsync<Person>().Result;
                Console.WriteLine(cyrano.NameUSen);
                Console.ReadKey();

                // foreach(string vehiclesUrl in luke.Vehicles)
                // {

                // }
            }
        }
    }
}