using System;

namespace C0743522
{
    class Program
    {
  
             public static void Main()
  { double c;
            double d;

            Console.WriteLine("enter the first number");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int b = Int32.Parse(Console.ReadLine());
            if (a == b)
            {

                c = a + b + a;
                Console.WriteLine("values were same so your answer is " + c);
            }

            else
            {

                d = a + b;
                Console.WriteLine("your answer is " + d);
        
            }}
}
    }