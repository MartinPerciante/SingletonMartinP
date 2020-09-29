namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            ISingleton<Greeter>.Instance.SayHiToTheWorld();
        }
    }
}
