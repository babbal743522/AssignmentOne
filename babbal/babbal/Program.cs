using System;

namespace C0743522
{
    class Program
    {
  
             public static void Main()
  {  
              

                 // for loop
            int A, sum = 0;
            Console.Write("The sum of first 10 natural number are :\n");
            for (A = 1; A <= 10; A++)
            {
                sum = sum + A;
                Console.Write("{0} ", A);
            }
            Console.Write("\nThe Sum is : {0}\n", sum);
            }
}
   
    }
}