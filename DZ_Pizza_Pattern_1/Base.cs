using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Pizza_Pattern_1
{
    public abstract class Base
    {
        public abstract string Name { get; }
        public abstract double Price { get; }
    }

    class Standart : Base
    {
        public override string Name => "Standart";

        public override double Price => 2.45;
    }

    class XXL : Base
    {
        public override string Name => "XXL";

        public override double Price => 4.85;
    }
}
