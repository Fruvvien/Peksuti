using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peksuti
{
    internal class Croissant : Bakedgood
    {
        private int ButterContent;

        public Croissant(int butterContent, string peksutiNeve, decimal price, int calories) : base(peksutiNeve, price, calories)
        {
            ButterContent = butterContent;
        }


        public override string GetDesciption()
        {
            return $"Neve: {this.PeksutiNeve} a vaj mennyiség: {this.ButterContent} g  Ára: {this.Price} Kalória: {this.Calories}";
        }

        public override decimal IncreasePrice(decimal amount)
        {

            return this.Price += amount;
        }
    }
}
