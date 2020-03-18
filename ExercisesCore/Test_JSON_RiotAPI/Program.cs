using ExercisesCore.Test_JSON_RiotAPI.Entities;
using ExercisesCore.Test_JSON_RiotAPI.Services;
using System;

namespace ExercisesCore.Test_JSON_RiotAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.Write("Enter the Summoner Name: ");
                string summonerName = Console.ReadLine();
                SummonerService summonerService = new SummonerService(summonerName);
                Summoner summoner = summonerService.GetSummonerInfo();

                summoner.ChampionMasteryList = summonerService.GetTopMasteryByPoints();

                Console.WriteLine("\n" + summoner.ToString());
                Console.Write("Select ( 1 - Search again / 2 - Close Application ): ");
                
            } while (int.Parse(Console.ReadLine()) == 1);
        }
    }
}
