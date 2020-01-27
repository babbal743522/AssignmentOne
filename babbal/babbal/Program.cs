using System;

namespace C0743522
{
    class Program
    {
  
             public static void Main()
  {
            //A-G
     Console.Write("please enter your name: ");
            String myName = Console.ReadLine();
            Console.Write("you look older than 20 " + myName);
            Console.ReadLine();


//A-H
    int numb1, numb2, numb3;

            Console.Write("Enter the 1st number :");
            numb1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd number :");
            numb2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 3rd number :");
            numb3 = Convert.ToInt32(Console.ReadLine());

            if (numb1 > numb2)
            {
                if (numb1 > numb3)
                {
                    Console.Write("The 1st Number is the greatest among three. \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three. \n\n");
                }
            }
            else if (numb2 > numb3)
                Console.Write("The 2nd Number is the greatest among three \n\n");
            else
                Console.Write("The 3rd Number is the greatest among three \n\n");
 }
}
    }