using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Santase.Logic.Cards;

namespace DeckTest
{
    [TestFixture]
    public class DeckTests
    {
        private Deck deck=new Deck();
        
        [TestCase(24)]
        public void CreateDeck_DeckIsCreatedWithCards(int cardsCount)
        {
            Assert.AreEqual(cardsCount, deck.CardsLeft, string.Format("Cards in the deck must be {0}", cardsCount));
        }

        [Test]
        public void Deck_TrumpCardIsValid()
        {
            var trumpCard = deck.GetTrumpCard;
            Assert.IsInstanceOf(typeof(Card), trumpCard, "Trump card must be valid");
        }

        [Test]
        public void Deck_TrumpCardIsChanged()
        {
            Card card = deck.GetNextCard();
            deck.ChangeTrumpCard(card);
            Assert.AreSame(card, deck.GetTrumpCard, "Trump card must the same of the set");
        }
    }
}
