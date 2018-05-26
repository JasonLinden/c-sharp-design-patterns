﻿using _08___State.Steak.Context;
using _08___State.Steak.State;

namespace _08___State.Steak.ConcreteState
{
    /// <summary>
    /// A Concrete State class
    /// </summary>
    class WellDone : Doneness //aka Ruined
    {
        public WellDone(Doneness state) : this(state.CurrentTemp, state.Steak)
        {
        }

        public WellDone(double currentTemp, SteakContext steak)
        {
            this.currentTemp = currentTemp;
            this.steak = steak;
            canEat = true;
            Initialize();
        }

        private void Initialize()
        {
            lowerTemp = 170;
            upperTemp = 230;
        }

        public override void AddTemp(double amount)
        {
            currentTemp += amount;
            DonenessCheck();
        }

        public override void RemoveTemp(double amount)
        {
            currentTemp -= amount;
            DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (currentTemp < 0)
            {
                steak.State = new Uncooked(this);
            }
            else if (currentTemp < lowerTemp)
            {
                steak.State = new Medium(this);
            }
        }
    }
}
