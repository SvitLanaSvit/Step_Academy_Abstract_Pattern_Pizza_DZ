using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Pizza_Pattern_1
{
    public abstract class Cheese
    {
        public abstract string Name { get; }
        public abstract double Price { get; }
    }

    class Mozarella : Cheese
    {
        public override string Name => "Mozarella";
        public override double Price => 0.5;
    }

    class Parmesan : Cheese
    {
        public override string Name => "Parmezan";

        public override double Price => 0.8;
    }

    class Ricotta : Cheese
    {
        public override string Name => "Ricotta";

        public override double Price => 0.65;
    }
}
