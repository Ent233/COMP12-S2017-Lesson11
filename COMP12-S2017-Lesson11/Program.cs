using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name:LF
 * Date:July 25,2017
 * Description:Enumeration for suits
 * Version:0.1 - created the suit Enum
 */
namespace COMP12_S2017_Lesson11
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

            
            hand.Add(deck.Deal1()); // deal one card from the top of the deck
            Console.WriteLine(hand.ToString());
            Console.WriteLine();
            hand.Add(deck.Deal1()); // deal one card from the top of the deck
            Console.WriteLine(hand.ToString());
            

            // hand = deck.Deal5(); // creates a new Hand object and assigns it to hand

        }
    }
}
;