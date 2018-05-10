using _01___Adapter.PhoneCharger.Target;

namespace _01___Adapter.PhoneCharger.Adapter
{
    class AndroidToIphoneAdapter : IPhone
    {
        private IAndroid _andoidPhone;

        public AndroidToIphoneAdapter(IAndroid andoidPhone)
        {
            andoidPhone = _andoidPhone;
        }

        public void Charge()
        {
            _andoidPhone.Charge();
        }
    }
}
