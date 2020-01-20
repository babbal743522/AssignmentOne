using System;

namespace C0743522
{
    class Program
    {
  
             public static void Main()
  {
    int num1, num2, num3;
     
    Console.Write("please enter the first number");
    num1 = Convert.ToInt32(Console.ReadLine());
     
    Console.Write("please enter the second number");
    num2 = Convert.ToInt32(Console.ReadLine());
     
    Console.Write("please enter the third number");
    num3 = Convert.ToInt32(Console.ReadLine());
     
    int resultOfMultiplication = num1 * num2 * num3;
    Console.WriteLine("Output: {0} x {1} x {2} = {3}", 
                        num1, num2, num3, resultOfMultiplication);
  }
}
    }