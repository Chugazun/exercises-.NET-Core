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

        public void ShuffleDeck()
        {
            Random rand = new Random();
            bool check = false;
            for (int i = 0; i < _deck.CardsLeft(); i++)
            {
                Card origin = DrawCard(i);
                if(rand.Next(0, 2) == 0)
                {
                    int targetPos = rand.Next(0, _deck.CardsLeft() - 1);
                    Card target = DrawCard(targetPos);                    
                    _deck.Cards.Insert(targetPos, origin);
                    _deck.Cards.Insert(i, target);                    
                } else
                {
                    _deck.Cards.Insert(i, origin);
                }
                if (i == _deck.CardsLeft() - 1 && !check)
                {
                    i = 0;
                    check = true;
                }                
            }
            check = false;
        }

        public Card DrawCard()
        {
            Card aux = _deck.Cards.First();
            _deck.Cards.RemoveAt(0);
            return aux;
        }
        public Card DrawCard(int pos)
        {
            Card aux = _deck.Cards[pos];
            _deck.Cards.RemoveAt(pos);
            return aux;
        }

        public Card GetCard(int pos)
        {
            return _deck.Cards[pos];
        }

        public void DealCards(Player player)
        {
            for (int i = 0; i < player.MaxHandSize; i++)
            {
                player.Hand.Add(DrawCard());
            }
        }
    }
}
