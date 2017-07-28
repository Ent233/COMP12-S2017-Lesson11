using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: LF
 * Date: July 27, 2017
 * Description: This is the Hand class
 * It inherits from the CardList class
 * Version: 0.2 - Added HighestCards method
 */
namespace COMP12_S2017_Lesson11
{
    public class Hand:CardList
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
            outputString += "================================================\n";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }
        public void HighestCards()
        {
            var max = (from item in this
                       select item.Face).Max() ;
            foreach (var item in this)
            {
                if (item.Face == max)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}