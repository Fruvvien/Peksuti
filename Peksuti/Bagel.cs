using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peksuti
{
    internal class Bagel : Bakedgood
    {
        private string Topping;

        public Bagel(string topping, string peksutiNeve, decimal price, int calories) : base(peksutiNeve, price, calories)
        {
            Topping = topping;
        }


        public override string GetDesciption()
        {
            return $"Neve: {this.PeksutiNeve} feltét: {this.Topping}  Ára: {this.Price} Kalória: {this.Calories}";
        }

        public override decimal IncreasePrice(decimal amount)
        {

            return this.Price += amount;
        }

    }
}
