using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.FruitTypes
{
    internal class Apple : Fruit
    {
        public Apple(int amount, int price) : base(amount, price)
        {
            Console.WriteLine("Apple constructor called");
        }
    }
}
