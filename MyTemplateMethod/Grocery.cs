using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTemplateMethod
{
    public class Grocery : AbstractProduct
    {
        protected override void Display()
        {
            Console.WriteLine("Displaying Grocery");
        }
    }
}
