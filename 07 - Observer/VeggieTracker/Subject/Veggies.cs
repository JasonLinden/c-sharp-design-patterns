﻿using _07___Observer.VeggieTracker.Observer;
using System;
using System.Collections.Generic;

namespace _07___Observer.VeggieTracker.Subject
{
    public abstract class Veggies
    {
        private double _pricePerPound;
        // ** Keep a record of observers
        private List<IRestaurant> _restaurants = new List<IRestaurant>();

        public Veggies(double pricePerPound)
        {
            _pricePerPound = pricePerPound;
        }

        public void Attach(IRestaurant restaurant)
        {
            _restaurants.Add(restaurant);
        }

        public void Detach(IRestaurant restaurant)
        {
            _restaurants.Remove(restaurant);
        }

        public void Notify()
        {
            foreach (IRestaurant restaurant in _restaurants)
            {
                restaurant.Update(this);
            }

            Console.WriteLine("");
        }

        public double PricePerPound
        {
            get { return _pricePerPound; }
            set
            {
                if (_pricePerPound != value)
                {
                    _pricePerPound = value;
                    Notify(); //Automatically notify our observers of price changes
                }
            }
        }
    }
}