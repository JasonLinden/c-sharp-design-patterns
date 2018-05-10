using System;

namespace _01___Adapter.PhoneCharger.Target
{
    public class SamsungS8 : IAndroid
    {
        public void Charge()
        {
            Console.WriteLine("Charging Android S8");
        }
    }
}
