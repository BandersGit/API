using System;
using RestSharp;
using Newtonsoft.Json;

namespace API
{
    class Program
    {
        static void Main(string[] args)
        {
            RestClient client = new RestClient("https://pokeapi.co/api/v2/");

            RestRequest request = new RestRequest("pokemon/charmander");

            IRestResponse response = client.Get(request);

            Console.WriteLine(response.StatusCode);
            System.Console.WriteLine();

            Pokemon charmander = JsonConvert.DeserializeObject<Pokemon>(response.Content);

            Console.WriteLine(charmander.name);
            System.Console.WriteLine(charmander.weight);
            System.Console.WriteLine(charmander.base_experience);

            Console.ReadLine();
        }
    }
}
