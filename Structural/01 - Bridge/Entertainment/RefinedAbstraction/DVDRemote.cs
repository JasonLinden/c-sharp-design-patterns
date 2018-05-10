using _01___Bridge.Entertainment.Abstraction;
using System;

namespace _01___Bridge.Entertainment.RefinedAbstraction
{
    class DVDRemote : RemoteButton
    {
        private bool play = true;

        public DVDRemote(EntertainmentDevice newDevice) : base(newDevice)
        {
        }

        public override void buttonNinePressed()
        {
            play = !play;

            Console.WriteLine("DVD is Playing: " + play);
        }
    }
}
