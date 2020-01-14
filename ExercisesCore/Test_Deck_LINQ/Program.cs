using ExercisesCore.Test_Deck_LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ExercisesCore.Test_Deck_LINQ.Services;

namespace ExercisesCore.Test_Deck_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            DeckManagement DM = new DeckManagement(deck);
            Player player = new Player(0, "Alex");



            DM.ShuffleDeck();
            DM.DealCards(player);
            Console.WriteLine(player);
        }
    }
}
