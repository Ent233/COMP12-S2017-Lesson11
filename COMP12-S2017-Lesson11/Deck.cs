using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name:LF
 * Date:July 25,2017
 * Description:this is the Deck class which inherits from the collection
 * this calss creates a new list type - Card
 * Version:0.3 - Added public shuffle method
 */
namespace COMP12_S2017_Lesson11
{
    public class Deck:List<Card>
    {
        //private instance variables
        private Random _random;

        //private properties
        private Random Random
        {
            get
            {
                return this._random;
            }
        }
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
        /// this is the private mehtod that load 52 cards
        /// also initializes other class variables
        /// </summary>
        private void _initialize()
        {
            //initialize the random object
            this._random = new Random();
             
            //load the list with cards
            for (int suit=0; suit<=(int)Suit.Spades; suit++)
            {
                for(int face = 1; face<=(int)Face.King;face++)
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
        public void Shuffle()
        {
            int firstCard;
            int secondCard;
            Card tempCard;

            

            for(int i=0; i<this.Count; i++)
            {
                firstCard = this.Random.Next(0, 52);
                secondCard = this.Random.Next(0, 52);
                tempCard = (Card)this[secondCard].Clone();
                this[secondCard].Face = this[firstCard].Face;
                this[secondCard].Suit = this[firstCard].Suit;
                this[firstCard].Face = tempCard.Face;
                this[firstCard].Suit = tempCard.Suit;
            }
            
        }
        
    }
}