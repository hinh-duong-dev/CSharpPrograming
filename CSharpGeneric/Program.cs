using System;

namespace CSharpGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = 1;
            int secondInt = 2;
            Swap(ref firstInt, ref secondInt);
            Console.WriteLine("firstInt: " + firstInt);
            Console.WriteLine("secondInt: " + secondInt);

            double firstDouble = 1.5;
            double secondDouble = 2.5;
            Swap(ref firstDouble, ref secondDouble);
            Console.WriteLine("firstDouble: " + firstDouble);
            Console.WriteLine("secondDouble " + secondDouble);

            Console.ReadKey();

        }


        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = b;
            b = a;
            a = temp;
        }
    }

}
