using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name:LF
 * Date:July 25,2017
 * Description:card class to be used in the card shuffling and dealing simulation.
 * Version:0.1 - created the suit Enum
 */
namespace COMP12_S2017_Lesson11
{
    public class Card:ICloneable
    {
        //private instance variables
        private Face _face;
        private Suit _suit;
        //public properties
        public Face Face
        {
            get
            {
                return this._face;
            }
            set
            {
                this._face = value;
            }
        }
        public Suit Suit
        {
            get
            {
                return this._suit;
            }
            set
            {
                this._suit = value;
            }
        }
        //constructors
        /// <summary>
        /// this is the main constructor for the card class
        /// it takes two parameters -face(Face)- suit(Suit)
        /// </summary>
        /// <param name="face"></param>
        /// <param name="suit"></param>
        public Card(Face face, Suit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
        //private method

        //public method
        public object Clone()
        {
            return new Card(this.Face, this.Suit);
        }
    }
}