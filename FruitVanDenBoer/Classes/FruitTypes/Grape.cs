using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.FruitTypes
{
    internal class Grape : Fruit
    {
        public Grape(int amount, int price) : base(amount, price)
        {
            Console.WriteLine("Grape constructor called");
        }
    }
}
