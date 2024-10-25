using System;

class Program
{
    static void Main(string[] args)
    {
        int i, j, k = 1;

        for (i = 1; i <= 15; i++)
        {
            for (j = 1; j <= i; j++)
            {
                Console.Write(k + " ");
                k = k + 1;
            }
            Console.Write("\n");
        }
        Console.ReadLine();
    }
}



using System;

namespace Practical1_C
{
    public class Choice
    {
        public void Fibonacci()
        {
            Console.WriteLine("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int n1 = 0, n2 = 1, n3;

            for (int i = 0; i < n; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }

        public void isPrime()
        {
            Console.WriteLine("Enter the number for checking is prime or not");
            int num = Convert.ToInt32(Console.ReadLine());
            int flag = 0;

            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0) // Corrected the condition to check divisibility by i
                {
                    Console.WriteLine("Is not prime number");
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                Console.WriteLine("is prime number");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Choice c1 = new Choice();
            bool iscontinue = true;

            while (iscontinue)
            {
                Console.WriteLine("Enter choice to 1:generate fibonacci and 2: check number prime");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    c1.Fibonacci();
                }
                else if (choice == 2)
                {
                    c1.isPrime();
                }
                else
                {
                    Console.WriteLine("please choice valid"); // Corrected the spelling of "valid"
                }

                Console.WriteLine("\nDo you want to continue.....[Y/N]");
                String userResponse = Console.ReadLine();

                if (userResponse != "y" && userResponse != "Y") // Corrected the condition to check for "y" or "Y"
                {
                    iscontinue = false;
                }
            }
            Console.WriteLine("Program existed ....");
        }
    }
}
