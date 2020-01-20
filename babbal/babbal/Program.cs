using System;

namespace C0743522
{
    class Program
    {
       

           public static void Main()
  {
    int num1, num2;
     
    Console.Write("Enter the first number");
    num1 = Convert.ToInt32(Console.ReadLine());
     
    Console.Write("Enter the second number");
    num2 = Convert.ToInt32(Console.ReadLine());
    
     
    int result = num1 * num2 ;
    Console.WriteLine("Output: {0} x {1} = {2}", 
                        num1, num2, result);
  }
}
    }

