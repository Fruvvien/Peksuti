using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peksuti
{
    internal class Bakery
    {
        private string name;
        private List<Bakedgood> products;

        public Bakery(string name)
        {
            this.Name = name;
            this.products = new List<Bakedgood>();
        }

        public string Name { get => name; set => name = value; }


        public void AddProduct(Bakedgood product)
        {
            this.products.Add(product);
        }

        public void DisplayProducts()
        {
            foreach (var item in this.products)
            {
                Console.WriteLine(item.GetDesciption());
            }
        }


        public void CalculateTotalCalories()
        {
            int calories = 0;
            foreach (var item in this.products)
            {
                calories += item.Calories;
            }

            Console.WriteLine($"Össz kalória: {calories}"); 
        }

        public void CalculateTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (var item in this.products)
            {
                totalPrice += item.Price;
            }

            Console.WriteLine($"Teljes ár: {totalPrice}"); 
        }

        public override string ToString()
        {
            return $"Pékség neve: {this.name}";
        }


    }
}
