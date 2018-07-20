using System;

namespace CG_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length of the rectangle?");
            string length = Console.ReadLine();
            int l = Convert.ToInt32(length);
            Console.WriteLine("What is the width of the rectangle?");
            string width = Console.ReadLine();
            int w = Convert.ToInt32(width);

            int area = l * w;
            Console.WriteLine("The area of your rectangle is" + area);
            Console.ReadLine();

        }
    }
}
