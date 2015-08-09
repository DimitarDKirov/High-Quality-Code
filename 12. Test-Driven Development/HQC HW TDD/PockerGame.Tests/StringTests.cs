using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;


namespace PockerGame.Tests
{
    [TestClass]
    public class StringTests
    {
        [TestMethod]
        public void CardToString_MustReturnCorrectString()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Clubs);
            string expectedResult="A♣";
            string cardString = card.ToString();
            Assert.AreEqual(expectedResult, cardString, "The ToString() method must return " + expectedResult);
        }

        [TestMethod]
        public void HandsToStringMethod_MustReturnCorrectCards()
        {
            Card cardClubsAce = new Card(CardFace.Ace, CardSuit.Clubs);
            Card card2Hert = new Card(CardFace.Two, CardSuit.Hearts);
            Card card10Diamond = new Card(CardFace.Ten, CardSuit.Diamonds);
            Card cardKingSpades = new Card(CardFace.King, CardSuit.Spades);
            Hand hand = new Hand(new List<ICard>() 
            { 
                cardClubsAce,
                card2Hert, 
                card10Diamond, 
                cardKingSpades
            });

            string expected = "A♣ 2♥ 10♦ K♠";
            Assert.AreEqual(expected, hand.ToString(), "The metohd should return string" + expected);
        }
    }
}
