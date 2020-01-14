using ExercisesCore.Test_Deck_LINQ.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesCore.Test_Deck_LINQ.Entities
{
    class Card
    {
        public string Name { get; set; }
        public int CardValue { get; set; }
        public Suit Suit { get; set; }

        public Card(string name, Suit suit)
        {
            int aux = int.Parse(name);
            CardValue = aux;
            switch (aux)
            {
                case 1:
                    Name = "A";
                    break;

                case 11:
                    Name = "Jack";
                    break;

                case 12:
                    Name = "Queen";
                    break;

                case 13:
                    Name = "King";
                    break;

                default:
                    Name = name;
                    break;
            }
            Suit = suit;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Name);
            sb.Append(" of ");
            sb.Append(Suit.ToString());

            return sb.ToString();
        }
    }
}
