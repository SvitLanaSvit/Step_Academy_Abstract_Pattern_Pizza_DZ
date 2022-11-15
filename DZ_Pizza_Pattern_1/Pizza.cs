using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Pizza_Pattern_1
{
    public class Pizza
    {
        private Base baseP;
        private Sause sause;
        private Cheese cheese;
        private List<Addon> addons;

        public Pizza(IngredientsFactory factory)
        {
            baseP = factory.CreateBase();
            sause = factory.CreateSause();
            cheese = factory.CreateCheese();
            addons = factory.CreateAddons();
        }

        public double CalculatePrice()
        {
            double sumFromAddons = 0;
            foreach(Addon addon in addons)
            {
                sumFromAddons += addon.Price;
            }

            double sum = baseP.Price + sause.Price + cheese.Price + sumFromAddons;

            return sum;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(Addon addon in addons)
            {
                stringBuilder.Append($"{addon.Name}\n               ");
            }
            return $"Base:          {baseP?.Name}\n" +
                   $"Sause:         {sause.Name}\n" +
                   $"Cheese:        {cheese.Name} \n" +
                   $"Ingridients:\n" +
                   $"               {stringBuilder}";
        }
    }
}
