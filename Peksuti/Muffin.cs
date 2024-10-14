using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peksuti
{
    internal  class Muffin : Bakedgood
    {

        private string flavor;

        public Muffin(string flavor, string peksutiNeve, decimal price, int calories) : base(peksutiNeve, price, calories)
        {
            this.flavor = flavor;
        }

        public override string GetDesciption()
        {
            return $"Neve: {this.PeksutiNeve} az íze: {this.flavor}  Ára: {this.Price} Kalória: {this.Calories}";
        }

        public override decimal IncreasePrice(decimal amount)
        {

            return this.Price += amount * 10/ 100;
        }
    }
}
