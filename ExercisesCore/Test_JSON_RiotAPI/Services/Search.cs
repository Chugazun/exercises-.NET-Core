using System.Net.Http;

namespace ExercisesCore.Test_JSON_RiotAPI.Services
{
    class Search
    {
        private static readonly HttpClient client = new HttpClient();
        public static string GetSummonerInfoByName(string name)
        {
            string url = $"https://br1.api.riotgames.com/lol/summoner/v4/summoners/by-name/{name}?api_key=RGAPI-7831c723-68d4-43ff-8d0e-1fd89061ffb9";

            return GetUrlContent(url);
        }

        public static string GetChampionPointsById(string summonerId, long championId)
        {
            string url = $"https://br1.api.riotgames.com/lol/champion-mastery/v4/champion-masteries/by-summoner/{summonerId}/by-champion/{championId.ToString()}?api_key=RGAPI-bda7b662-d544-42f1-8ae7-dd274e7c9d3f";

            return GetUrlContent(url);
        }

        public static string GetChampionMasteryList(string summonerId)
        {
            string url = $"https://br1.api.riotgames.com/lol/champion-mastery/v4/champion-masteries/by-summoner/{summonerId}?api_key=RGAPI-7831c723-68d4-43ff-8d0e-1fd89061ffb9";

            return GetUrlContent(url);
        }

        private static string GetUrlContent(string url)
        {
            string result = client.GetStringAsync(url).Result;

            return result;
        }
    }
}
