using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.JuiceTypes
{
    internal class PearJuice : Fruit
    {
        public PearJuice(int amount, int price) : base(amount, price)
        {
            Console.WriteLine("IDK pearjuice");
        }
    }
}
