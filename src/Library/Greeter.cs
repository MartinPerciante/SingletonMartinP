using System;

namespace Program
{
    public class Greeter : ISingleton<Greeter>
    {
        public void SayHiToTheWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}