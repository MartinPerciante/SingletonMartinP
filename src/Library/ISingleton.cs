using System;

namespace Program
{
    public interface ISingleton<T> where T : new()
    {
        void SayHiToTheWorld();
        static ISingleton<T> Instance;
    }
}