using ExercisesCore.Test_Deck_LINQ.Entities;
using ExercisesCore.Test_Deck_LINQ.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesCore.Test_Deck_LINQ.Services
{
    class DeckManagement
    {
        private Deck _deck;

        public DeckManagement(Deck deck)
        {
            _deck = deck;
        }

        public List<Card> GetSuits(string suit)
        {
            return _deck.Cards.Where(c => c.Suit == Enum.Parse<Suit>(suit)).ToList();
        }
    }
}
