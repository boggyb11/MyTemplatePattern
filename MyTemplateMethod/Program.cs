using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            AbstractProduct abstractProduct = new Grocery();
            abstractProduct.TemplateMethod();

            AbstractProduct abstractProduct2 = new Electronic();
            abstractProduct2.TemplateMethod();

            Console.ReadLine();
        }
    }
}
