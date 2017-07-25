using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name:LF
 * Date:July 25,2017
 * Description:this is the Deck class which inherits from the collection
 * this calss creates a new list type - Card
 * Version:0.1 - created the Deck class
 */
namespace COMP12_S2017_Lesson11
{
    public class Deck:List<Card>
    {
        //private instance variables

        //public properties
        /// <summary>
        /// this is the main constructor for deck class
        /// </summary>
        //constructors
        public Deck()
        {
            this._initialize();
        }
        //private methods
        /// <summary>
        /// this is the private mehtod for the deck
        /// </summary>
        private void _initialize()
        {
            for (int suit=0; suit<(int)Suit.Spades; suit++)
            {
                for(int face = 1; face<(int)Face.King;face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));
                }
            }          
        }
        //public methods
        /// <summary>
        /// this method override the built-in Tostring method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = "";
            foreach (Card card in this)
            {
                outputString += "The" + card.Face + "of" + card.Suit + "\n";
            }
            return outputString;
        }
    }
}