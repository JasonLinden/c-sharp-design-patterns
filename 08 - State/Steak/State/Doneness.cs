using _08___State.Steak.Context;

namespace _08___State.Steak.State
{
    /// <summary>
    /// The State abstract class
    /// </summary>
    public abstract class Doneness
    {
        protected SteakContext steak;
        protected double currentTemp;
        protected double lowerTemp;
        protected double upperTemp;
        protected bool canEat;

        public SteakContext Steak
        {
            get { return steak; }
            set { steak = value; }
        }

        public double CurrentTemp
        {
            get { return currentTemp; }
            set { currentTemp = value; }
        }

        public abstract void AddTemp(double temp);
        public abstract void RemoveTemp(double temp);
        public abstract void DonenessCheck();
    }
}
