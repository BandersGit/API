using System;
using RestSharp;
using Newtonsoft.Json;

namespace API
{
    class Program
    {
        static void Main(string[] args)
        {
            string pokeChoice = "";

            System.Console.WriteLine("Write any pokemon to see their stats!");

            pokeChoice = Console.ReadLine().ToLower();

            RestClient client = new RestClient("https://pokeapi.co/api/v2/");

            RestRequest request = new RestRequest("pokemon/" + pokeChoice);

            IRestResponse response = client.Get(request);

            Console.WriteLine(response.StatusCode);
            System.Console.WriteLine();

            Pokemon poke = JsonConvert.DeserializeObject<Pokemon>(response.Content);

            Console.WriteLine(poke.name.ToUpper());
            System.Console.WriteLine("Weight " + poke.weight);
            System.Console.WriteLine("XP " + poke.base_experience);

            Console.ReadLine();
        }
    }
}
