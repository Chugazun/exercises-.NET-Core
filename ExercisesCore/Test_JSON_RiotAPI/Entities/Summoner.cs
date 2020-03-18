using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Test_JSON_RiotAPI.Entities
{
    class Summoner
    {
        public string Name { get; set; }
        public long SummonerLevel { get; set; }
        public string Id { get; set; }
        public List<ChampionMastery> ChampionMasteryList { get; set; }

        public Summoner()
        {

        }

        public Summoner(string name)
        {
            Name = name;
            ChampionMasteryList = new List<ChampionMastery>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Summoner Name: " + Name);
            sb.AppendLine("Summoner Level: " + SummonerLevel);
            sb.AppendLine("\n--------------------------------------");
            sb.AppendLine("Top 3 Champions by Mastery Points");           

            for (int i = 0; i < 3; i++)
            {
                sb.AppendLine("\nChampion #" + (i + 1));
                sb.AppendLine(ChampionMasteryList[i].ToString());
            }
            sb.AppendLine("--------------------------------------");
            return sb.ToString();
        }
    }
}
