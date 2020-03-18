using ExercisesCore.Test_JSON_RiotAPI.Entities;
using ExercisesCore.Test_JSON_RiotAPI.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace ExercisesCore.Test_JSON_RiotAPI.Services
{
    class SummonerService
    {
        private Summoner _summoner;

        public SummonerService(string summonerName)
        {
            string summonerInfoJson = Search.GetSummonerInfoByName(summonerName);
            _summoner = JsonSerializer.Deserialize<Summoner>(summonerInfoJson, new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });

            string championMasteryJson = Search.GetChampionMasteryList(_summoner.Id);
            _summoner.ChampionMasteryList = JsonSerializer.Deserialize<List<ChampionMastery>>(championMasteryJson, new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        }

        public Summoner GetSummonerInfo()
        {
            return _summoner;
        }

        public List<ChampionMastery> GetTopMasteryByPoints()
        {
            List<ChampionMastery> aux = _summoner.ChampionMasteryList.OrderByDescending(m => m.ChampionPoints)
                                                                     .Take(3)
                                                                     .ToList();

            aux.ForEach(mastery => mastery.ChampionName = IdConverter.ByName(mastery.ChampionId));

            return aux;
        }
    }
}
