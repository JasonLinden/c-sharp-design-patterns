using System;

namespace _01___Adapter.PhoneCharger.Target
{
    public class IPhoneX : IPhone
    {
        public void Charge()
        {
            Console.WriteLine("Charging IPhone");
        }
    }
}
