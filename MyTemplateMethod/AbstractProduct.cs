using System;

namespace MyTemplateMethod
{
    public abstract class AbstractProduct
    {
        protected abstract void Display();


        private void Initialize()
        {
            Console.WriteLine("Initializing");
        }

        private void End()
        {
            Console.WriteLine("End");
        }


        public void TemplateMethod()
        {
            Initialize();
            Display();
            End();
        }

    }
}
