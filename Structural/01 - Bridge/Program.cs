using _01___Bridge.Entertainment.Abstraction;
using _01___Bridge.Entertainment.ConcreteImplementor;
using _01___Bridge.Entertainment.RefinedAbstraction;
using _01___Bridge.Restaurant.Abstraction;
using _01___Bridge.Restaurant.ConcreteImplementor;
using _01___Bridge.Restaurant.RefinedAbstraction;
using System;

namespace _02___Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            // With the Bridge Design Pattern you create 2 layers of abstraction
            // In this example I'll have an abstract class representing
            // different types of devices. I also have an abstract class
            // that will represent different types of remote controls

            #region Restaurant
            SendOrder _sendOrder = new SendDairyFreeOrder();

            _sendOrder._restaurant = new DinerOrders();
            _sendOrder.Send();

            _sendOrder._restaurant = new FancyRestaurantOrders();
            _sendOrder.Send();

            _sendOrder = new SendGlutenFreeOrder();

            _sendOrder._restaurant = new DinerOrders();
            _sendOrder.Send();

            _sendOrder._restaurant = new FancyRestaurantOrders();
            _sendOrder.Send();
            #endregion

            #region Entertainment

            // This allows me to use an infinite variety of devices and remotes

            RemoteButton theTV = new TVRemoteMute(new TVDevice(1, 200));

            RemoteButton theTV2 = new TVRemotePause(new TVDevice(1, 200));

            // HOMEWORK --------------

            RemoteButton theDVD = new DVDRemote(new DVDDevice(1, 14));

            // -----------------------

            Console.WriteLine("Test TV with Mute");

            theTV.buttonFivePressed();
            theTV.buttonSixPressed();
            theTV.buttonNinePressed();

            Console.WriteLine("\nTest TV with Pause");

            theTV2.buttonFivePressed();
            theTV2.buttonSixPressed();
            theTV2.buttonNinePressed();
            theTV2.deviceFeedback();

            // HOMEWORK
            Console.WriteLine("\nTest DVD");

            theDVD.buttonFivePressed();
            theDVD.buttonSixPressed();
            theDVD.buttonNinePressed();
            theDVD.buttonNinePressed(); 
            #endregion


            Console.ReadKey();
        }
    }
}
