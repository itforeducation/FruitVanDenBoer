using Classes;
using Classes.FruitTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.JuiceTypes
{
    internal class AppleJuice : Fruit
    {
        public AppleJuice(int amount, int price) : base(amount, price)
        {
            Console.WriteLine("Apple juice constructor called");
        }
    }
}
