using System;
using System.Collections.Generic;

namespace _03___Composite.Soda.Component
{
    public abstract class SoftDrink
    {
        private Lazy<List<SoftDrink>> _flavours = new Lazy<List<SoftDrink>>();

        public int Calories { get; set; }
        public List<SoftDrink> Flavours => _flavours.Value;

        public SoftDrink(int calories) => Calories = calories;

        /// <summary>
        /// "Flatten" method, returns all available flavors
        /// </summary>
        public void DisplayCalories(int depth)
        {
            Console.WriteLine(depth.ToString() + " " + this.GetType().Name + ": " + this.Calories.ToString() + " calories.");
            foreach (var drink in Flavours)
            {
                drink.DisplayCalories(depth + 1);
            }
        }
    }
}
