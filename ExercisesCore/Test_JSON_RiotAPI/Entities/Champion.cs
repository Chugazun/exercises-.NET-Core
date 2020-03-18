using System.Text;

namespace ExercisesCore.Test_JSON_RiotAPI.Entities
{
    class ChampionMastery
    {
        public long ChampionId { get; set; }
        public string ChampionName { get; set; }
        public int ChampionPoints { get; set; }
        public int ChampionLevel { get; set; }

        public ChampionMastery()
        {

        }

        public ChampionMastery(long championId, int championPoints, int championLevel)
        {
            ChampionId = championId;
            ChampionPoints = championPoints;
            ChampionLevel = championLevel;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name: " + ChampionName);
            sb.AppendLine("Mastery Points: " + ChampionPoints);
            sb.Append("Mastery Level: " + ChampionLevel);
            return sb.ToString();
        }
    }
}
