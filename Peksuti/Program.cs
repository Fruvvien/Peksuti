using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peksuti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bakery bakery = new Bakery("Jó pékség");
            Croissant croissant = new Croissant(20, "Croissant", 150, 300 );
            Muffin muffin = new Muffin("Csokis", "Muffin", 200, 350);
            Bagel bagel = new Bagel("Szezámmag", "Bagel", 180, 250);


            bakery.AddProduct(croissant);
            bakery.AddProduct(muffin);
            bakery.AddProduct(bagel);

            Console.WriteLine(bakery);
            bakery.DisplayProducts();
            bakery.CalculateTotalPrice();
            bakery.CalculateTotalCalories();



            Console.WriteLine("---------------------------------------------------------------");

            croissant.IncreasePrice(50);
            muffin.IncreasePrice(200);
            bagel.IncreasePrice(30);



            Console.WriteLine(bakery);
            bakery.DisplayProducts();
            bakery.CalculateTotalPrice();
            bakery.CalculateTotalCalories();
        }
    }
}
