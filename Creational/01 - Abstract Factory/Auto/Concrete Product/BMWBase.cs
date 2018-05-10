using _01___Abstract_Factory.Auto.Abstract_Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Abstract_Factory.Auto.Concrete_Product
{
    public class BMWBase : IAutomobile
    {
        public string Name { get; set; }

        public void TurnOff()
        {
            throw new NotImplementedException();
        }

        public void TurnOn()
        {
            throw new NotImplementedException();
        }
    }
}
