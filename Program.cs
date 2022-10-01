using System;

namespace Prime_or_Complex_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 21, control = 1;

            if (n <= 1)
                Console.WriteLine("Enter the correct number.");
            else
            {
                for (int i = 2; i < n; i++)
                    if (n % i == 0)
                    {
                        control = 0;
                        break;
                    }

                    if (control == 1)
                        Console.WriteLine("It is the prime number.");
                    else
                        Console.WriteLine("It is the complex number.");           
            }
        }
    }
}
