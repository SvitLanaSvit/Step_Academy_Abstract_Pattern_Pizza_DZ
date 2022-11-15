using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Pizza_Pattern_1
{
    public abstract class Sause
    {
        public abstract string Name { get; }
        public abstract double Price { get; }
    }

    class Tomato : Sause
    {
        public override string Name => "Tomato";

        public override double Price => 0.45;
    }

    class Barbecue : Sause
    {
        public override string Name => "Barbecue";

        public override double Price => 0.6;
    }
}
