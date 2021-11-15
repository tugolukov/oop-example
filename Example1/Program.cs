using System;

namespace Example1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var figure = new Square("first", 2, 3);

            var area = figure.GetArea();
            
            Console.WriteLine(figure.ToString());
        }
    }
}
