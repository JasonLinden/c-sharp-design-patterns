using _01___Bridge.Entertainment.Abstraction;
using System;

namespace _01___Bridge.Entertainment.RefinedAbstraction
{
    // If I decide I want to further extend the remote I can

    public class TVRemoteMute : RemoteButton
    {
        public TVRemoteMute(EntertainmentDevice newDevice) : base(newDevice)
        {
        }

        public override void buttonNinePressed()
        {
            Console.WriteLine("TV was Muted");
        }
    }
}
