using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Threading.Tasks;
using PokeAPI;

namespace CodeLouisvilleCSharp_2018
{
    class Program
    {
        static async void GetData()
        {
        string API = "https://pokeapi.co/api/v2/pokedex/2/";
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage res = await client.GetAsync(API))
            using (HttpContent content = res.Content)
            {
                string data = await content.ReadAsStringAsync();
                if (data != null)
                {
                    Console.WriteLine(data);
                }
            }
        }
        static void Main(string[] args)
        {
            GetData();
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}