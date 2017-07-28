using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name:mehul khosla
 * Date: July 27, 2017
 * Description:  Lesson 11
 * Version: 0.5 - creates a new Hand object and assigns it to hand
 */
namespace lab_highestCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Hand hand = new Hand(); // new empty Hand container

            Deck deck = new Deck();
            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine(deck.ToString());
            Console.WriteLine();

            /*
            hand.Add(deck.Deal1()); // deal one card from the top of the deck
            Console.WriteLine(hand.ToString());
            Console.WriteLine();
            hand.Add(deck.Deal1()); // deal one card from the top of the deck
            Console.WriteLine(hand.ToString());
            */

            // hand = deck.Deal5(); // creates a new Hand object and assigns it to hand
            hand = deck.Deal5();

            hand.HighestCards(hand);

        }
    }
}
