using System;

namespace MyTemplateMethod
{
    public class Electronic : AbstractProduct
    {
        protected override void Display()
        {
            Console.WriteLine("Displaying electronic");
        }
    }
}
