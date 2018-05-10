using _01___Adapter.Speed.Target;

namespace _01___Adapter.Speed.Adapter
{
    class SpeedAdapter
    {
        ILocomotion _newLocomotion;

        public SpeedAdapter(ILocomotion newLocomotion)
        {
            _newLocomotion = newLocomotion;
        }

        public double Speed()
        {
            return ConvertMPHtoKMPH(_newLocomotion.Speed());
        }

        private double ConvertMPHtoKMPH(double mph)
        {
            return mph * 1.60934;
        }
    }
}
