﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Tom Tsiliopoulos
 * Date: July 27, 2017
 * Description: This is the abstract superclass CardList.
 * It inherits from the build-in List generic collection and consumes the Card class
 * Version: 0.1 - Created the CardList class
 */
namespace lab_highestCard
{
    public abstract class CardList : List<Card>
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTORS
        public CardList()
        {
            this._initialize();
        }

        // PRIVATE METHODS
        protected abstract void _initialize();

        // PUBLIC METHODS
    }
}