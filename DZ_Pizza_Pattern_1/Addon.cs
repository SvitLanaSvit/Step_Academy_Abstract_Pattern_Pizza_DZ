using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Pizza_Pattern_1
{
    public abstract class Addon
    {
        public abstract string Name { get; }
        public abstract double Price { get; }
    }

    class Mushroom : Addon
    {
        public override string Name => "Mushroom";

        public override double Price => 1.5;
    }

    class Seafood : Addon
    {
        public override string Name => "Seafood";

        public override double Price => 3.5;
    }

    class Salami : Addon
    {
        public override string Name => "Salami";

        public override double Price => 2.5;
    }

    class Pepperoni : Addon
    {
        public override string Name => "Pepperoni";

        public override double Price => 1.25;
    }

    class Basilicum : Addon
    {
        public override string Name => "Basilicum";

        public override double Price => 0.4;
    }

    class Garlic : Addon
    {
        public override string Name => "Garlic";

        public override double Price => 0.45;
    }

    class Oregano : Addon
    {
        public override string Name => "Oregano";

        public override double Price => 0.3;
    }

    class ExtraVirginOliveOil : Addon
    {
        public override string Name => "Extra virgin olive oil";

        public override double Price => 2.0;
    }

    class Bacon : Addon
    {
        public override string Name => "Bacon";

        public override double Price => 2.25;
    }

    class Onion : Addon
    {
        public override string Name => "Onion";

        public override double Price => 0.75;
    }

    class BeefMince : Addon
    {
        public override string Name => "Beef mince";

        public override double Price => 3.35;
    }

    class Capsicum : Addon
    {
        public override string Name => "Capsicum";

        public override double Price => 1.5;
    }

    class Olives : Addon
    {
        public override string Name => "Olives";

        public override double Price => 1.5;
    }
}