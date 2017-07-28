using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: mehul khosla
 * Date: July 27, 2017
 * Description: This is the Hand class
 * It inherits from the CardList class
 * Version: 0.5 - Added public method HighestCards
 */
namespace lab_highestCard
{
    
    
        public class Hand : CardList
        {
            // PRIVATE INSTANCE VARIABLES

            // PUBLIC PROPERTIES

            // CONSTRUCTORS

            // PRIVATE METHODS

            /// <summary>
            /// This method initializes class variables and other objects
            /// </summary>
            protected override void _initialize()
            {
                // This method is currently empty
            }

            // PUBLIC METHODS

            /// <summary>
            /// This method overrides the built-in ToString method
            /// </summary>
            public override string ToString()
            {
                string outputString = "";
                outputString += "The Hand contains:\n";
                outputString += "==================\n";

                foreach (Card card in this)
                {
                    outputString += "The " + card.Face + " of " + card.Suit + "\n";
                }

                return outputString;
            }
        public void HighestCards(Hand h)
        {
            var sortCard = from v in h
                           orderby v.Face descending
                           select v;
            int biggestFace = 0;
            int count = 0;
            Console.WriteLine("THE HIGHEST CARD IN THE HAND IS:");
            foreach (Card item in sortCard)
            {
                if (count == 0)
                {
                    biggestFace = (int)item.Face;
                }
                else if ((int)item.Face < biggestFace)
                {
                    break;
                }
                Console.WriteLine("" + item.Face + " of " + item.Suit);
                Console.WriteLine("\n");
                count++;

            }
        }
    }
    }
