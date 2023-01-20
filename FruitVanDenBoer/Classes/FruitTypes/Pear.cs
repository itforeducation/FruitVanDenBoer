using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.FruitTypes
{
    internal class Pear : Fruit 
    {
        public Pear(int amount, int price) : base(amount, price)
        {
            Console.WriteLine("Pear Got Called!");
        }

    }
}
