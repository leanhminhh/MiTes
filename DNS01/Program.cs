using BookMan.Controller;
using BookMan.Framework;

namespace DNS01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== Book management ==");
            while (true)
            {
                Console.WriteLine(">>> ");
                var route = Console.ReadLine();
                Router.Forward(route);
            }
        }
    }
}
