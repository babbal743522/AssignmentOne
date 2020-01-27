using System;

namespace C0743522
{
    class Program
    {
  
             public static void Main()
  {  
              Console.WriteLine("enter first number");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b = Int32.Parse(Console.ReadLine());
            if (a == b)
            {


                Console.WriteLine("values are same so they are accepted");
            }

            else
            {


                Console.WriteLine("values are not same");
            }
}
   
    }
}