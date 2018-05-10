namespace _01___Adapter.PhoneCharger.Target
{
    class AndoidCharger
    {
        public void Charge(IAndroid android)
        {
            android.Charge();
        }
    }
}
