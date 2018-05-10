using _01___Bridge.Entertainment.Abstraction;
using System;

namespace _01___Bridge.Entertainment.ConcreteImplementor
{
    // Here is an implementation of the EntertainmentDevice
    // abstract class. I'm specifying what makes it different
    // from other devices

    public class DVDDevice : EntertainmentDevice
    {
        public DVDDevice(int newDeviceState, int newMaxSetting)
        {
            deviceState = newDeviceState;

            maxSetting = newMaxSetting;

        }

        public override void ButtonFivePressed()
        {
            Console.WriteLine("DVD Skips to Chapter");

            deviceState--;
        }

        public override void ButtonSixPressed()
        {
            Console.WriteLine("DVD Skips to Next Chapter");

            deviceState++;

        }
    }
}
