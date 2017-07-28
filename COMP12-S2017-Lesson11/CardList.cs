using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name:LF
 * Date:July 27,2017
 * Description:This is the abstract superclass CardList.
 * It inherits from the build-in List generic collection and consumes the Card class
 * Version:0.1 - Created the CardList class
 */
namespace COMP12_S2017_Lesson11
{
    public abstract class CardList: List<Card>
    {
        //private instance variables

        //public properties

        //constructors
        public CardList()
        {
            this._initialize();
        }
        //private methods
        protected abstract void _initialize();
        //publice methods
    }
}