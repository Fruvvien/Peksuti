using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peksuti
{
    internal abstract class Bakedgood
    {
        private string peksutiNeve;
        private decimal price;
        private int calories;

        protected Bakedgood(string peksutiNeve, decimal price, int calories)
        {
            this.PeksutiNeve = peksutiNeve;
            this.Price = price;
            this.Calories = calories;
        }

        public string PeksutiNeve { get => peksutiNeve; set => peksutiNeve = value; }
        public decimal Price { get => price; set => price = value; }
        public int Calories { get => calories; set => calories = value; }


        public abstract string GetDesciption();
        public abstract decimal IncreasePrice(decimal amount);
        
    }
}
