namespace _01___Adapter.PhoneCharger.Target
{
    public class IPhoneCharger
    {
        public void Charge(IPhone iphone)
        {
            iphone.Charge();
        }
    }
}
