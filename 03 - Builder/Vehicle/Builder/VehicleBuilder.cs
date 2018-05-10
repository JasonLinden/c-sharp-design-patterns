using _03___Builder.Vehicle.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Builder.Vehicle.Builder
{
    public abstract class VehicleBuilder
    {
        protected VehicleProduct vehicle;

        public VehicleProduct Vehicle { get => vehicle; }

        // Abstract build methods
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
