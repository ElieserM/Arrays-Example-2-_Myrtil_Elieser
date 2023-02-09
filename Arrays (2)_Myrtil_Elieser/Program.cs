/*
 * Author: Elieser Myrtil
 * Date:02/08/2023
 * This program is used to present an array based on input from users
*/

using System;

namespace Arrays__2__Myrtil_Elieser

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 5 and 20: ");

            int input = int.Parse(Console.ReadLine());

            if (input >=5 && input <= 20)
            {
                int[] even = new int[input];
                int[] odd = new int[input];
                int[] fibonacci = new int[input];

                //Initiates the fibonacci sequence
                fibonacci[0] = 0;
                fibonacci[1] = 1;

                for (int i = 0; i < input; i++)
                {
                    even[i] = 2 * i;
                    odd[i] = 2 * i + 1;

                    if (i >= 2)
                    {
                        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                    }
                }
                // Displays just the integers of the fibonacci sequence.
                /*
                Console.WriteLine("");
                Console.WriteLine("Fibonacci");
                foreach (int number in fibonacci)
                {
                    Console.WriteLine(number);
                }
                */

                for (int i = 0; i < input; i++)
                {
                    Console.WriteLine("Fibonacci(" + i + ") = " + fibonacci[i]);
                }

            }
        }
    }
}