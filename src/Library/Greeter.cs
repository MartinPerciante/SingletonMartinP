using System;

namespace Program
{
    public class Greeter : ISingleton<Greeter>
    {
        private static Greeter instance;

        static Greeter Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Greeter();
                }

                return instance;
            }
        }

        public void SayHiToTheWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}