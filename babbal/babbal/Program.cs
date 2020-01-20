using System;

namespace C0743522
{
    class Program
    {

      public static void Main()
  {
    int num1, num2, num3;
     
    Console.Write("Enter first number");
    num1 = Convert.ToInt32(Console.ReadLine());
     
    Console.Write("Enter second number ");
    num2 = Convert.ToInt32(Console.ReadLine());
     
   
     
    int result = num1 * num2;
    Console.WriteLine("Output: {0} / {1} = {2}", 
                        num1, num2, result);
  }
}
    }