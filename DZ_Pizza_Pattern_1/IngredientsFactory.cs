using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Pizza_Pattern_1
{
    public abstract class IngredientsFactory
    {
        public abstract Base CreateBase();
        public abstract Sause CreateSause();
        public abstract Cheese CreateCheese();
        public abstract List<Addon> CreateAddons();
    }

    class PepperoniP : IngredientsFactory
    {
        public override List<Addon> CreateAddons()
        {
            return new List<Addon>()
            {
                new Pepperoni()
            };
        }

        public override Base CreateBase()
        {
            return new XXL();
        }

        public override Cheese CreateCheese()
        {
            return new Mozarella();
        }

        public override Sause CreateSause()
        {
            return new Tomato();
        }
    }

    class Margarita : IngredientsFactory
    {
        public override List<Addon> CreateAddons()
        {
            return new List<Addon>()
            {
                new Basilicum()
            };
        }

        public override Base CreateBase()
        {
            return new Standart();
        }

        public override Cheese CreateCheese()
        {
            return new Mozarella();
        }

        public override Sause CreateSause()
        {
            return new Tomato();
        }
    }

    class Marinara : IngredientsFactory
    {
        public override List<Addon> CreateAddons()
        {
            return new List<Addon>()
            {
                new Garlic(),
                new ExtraVirginOliveOil()
            };
        }

        public override Base CreateBase()
        {
            return new Standart();
        }

        public override Cheese CreateCheese()
        {
            return new Mozarella();
        }

        public override Sause CreateSause()
        {
            return new Tomato();
        }
    }

    class Supreme : IngredientsFactory
    {
        public override List<Addon> CreateAddons()
        {
            return new List<Addon>()
            {
                new Bacon(),
                new Onion(),
                new BeefMince(),
                new Capsicum(),
                new Mushroom(),
                new Olives()
            };
        }

        public override Base CreateBase()
        {
            return new XXL();
        }

        public override Cheese CreateCheese()
        {
            return new Mozarella();
        }

        public override Sause CreateSause()
        {
            return new Tomato();
        }
    }
}
