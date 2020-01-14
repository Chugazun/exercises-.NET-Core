using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Test_Deck_LINQ.Entities
{
    class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Card> Hand { get; set; } = new List<Card>();
        public int MaxHandSize { get; set; }

        public Player(int iD, string name)
        {
            ID = iD;
            Name = name;
            MaxHandSize = 5;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            Hand.ForEach(c => {
                sb.Append(c.Name);
                sb.Append(" of ");
                sb.AppendLine(c.Suit.ToString());
            });
            return sb.ToString();
        }
    }
}
