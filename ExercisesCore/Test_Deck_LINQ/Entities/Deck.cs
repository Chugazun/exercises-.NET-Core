using ExercisesCore.Test_Deck_LINQ.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Test_Deck_LINQ.Entities
{
    class Deck
    {
        public List<Card> Cards { get; set; } = new List<Card>();        

        public Deck()
        {
            for (int i = 1; i < 14; i++)
            {
                for (int suit = 0; suit < 4; suit++)
                {
                    Cards.Add(new Card(i.ToString(), (Suit)suit));
                }
            }
        }

        public int CardsLeft()
        {
            return Cards.Count;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            Cards.ForEach(c => {
                sb.Append(c.Name);
                sb.Append(" of ");
                sb.AppendLine(c.Suit.ToString());
            });
            return sb.ToString();
        }
    }
}
