using _02___Factory_Method.Auto.Abstract_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02___Factory_Method.Simple_Factory;

namespace _02___Factory_Method.Auto.Concrete_Factory
{
    public class AudiFactory : IAutoFactory
    {
        public IAuto CreateAuto()
        {
            throw new NotImplementedException();
        }
    }
}
