using _02___Factory_Method.Auto.Abstract_Factory;
using _02___Factory_Method.Simple_Factory;
using System;

namespace _02___Factory_Method.Auto.Concrete_Factory
{
    public class BMWFactory : IAutoFactory
    {
        public IAuto CreateAuto()
        {
            var bmwM3 = new BMW();

            return bmwM3;
        }
    }
}
