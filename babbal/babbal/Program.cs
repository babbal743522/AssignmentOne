using System;

namespace C0743522
{
    class Program
    {
   static void Main(string[] args)
        {
            int num1;
            int num2;
            int temp;
            Console.Write("Enter the First Number");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the Second Number : ");
            num2 = int.Parse(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;
            
            Console.Write("After Swapping ,the First Number : "+num1);
            Console.Write("After Swapping, the Second Number : "+num2);
            Console.Read();
        }
    }
}