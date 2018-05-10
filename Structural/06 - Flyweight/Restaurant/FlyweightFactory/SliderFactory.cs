using _06___Flyweight.Restaurant.ConcreteFlyweight;
using _06___Flyweight.Restaurant.Flyweight;
using System.Collections.Generic;

namespace _06___Flyweight.Restaurant.FlyweightFactory
{
    // The Factory will store a collection of already-created sliders, and any time another slider of the same type 
    // needs to be created, the Factory will use the already-created one rather than creating a brand-new one.

    class SliderFactory
    {
        private Dictionary<char, Slider> _sliders =
            new Dictionary<char, Slider>();

        public Slider GetSlider(char key)
        {
            Slider slider = null;
            if (_sliders.ContainsKey(key)) //If we've already created one of the requested type of slider, just use that.
            {
                slider = _sliders[key];
            }
            else //Otherwise, create a brand new instance of the slider.
            {
                switch (key)
                {
                    case 'B': slider = new BaconMaster(); break;
                    case 'V': slider = new VeggieSlider(); break;
                    case 'Q': slider = new BBQKing(); break;
                }
                _sliders.Add(key, slider);
            }
            return slider;
        }
    }
}
