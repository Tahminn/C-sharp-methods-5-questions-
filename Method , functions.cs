using System;

namespace Methods__functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Divisible(33);


            int n = 6, m = 15;

            int Odds = countOdd(n, m);
            Console.WriteLine("Count of odd numbers is " + Odds);
            int Sum = OddSum(n, m);
            Console.WriteLine("Sum of odd number is" + "from n to m is " + OddSum(n, m));
            SimpComp(17);
            int[] array = { 3, 5, 6, 7, 9, 12, 14 };
            SumEven(array);
        }
        //Divisible by 3 and 7
        static void Divisible(int n)
        {
            if (n % 3 == 0 && n % 7 == 0)
            {
                Console.WriteLine("Divisible by 3 and 7");
            }

            else
            {
                Console.WriteLine("Undivisible by 3 and 7");
            }
        }

        //Count of odd numbers
        static int countOdd(int n, int m)
        {
            int i = (m - n) / 2;

            if (m % 2 != 0 || n % 2 != 0)
                i++;

            return i;
        }
        //Sum of odd numbers
        static int OddSum(int n, int m)
        {
            int sum = 0;
            if (n < 1 || m < 1)
            {
                Console.WriteLine("Enter the correct number");
            }

            else
            {
                for (int i = n + 1; i < m - 1; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += i;
                    }

                }
            }
            return sum;

        }
        //simple or complex number
        static void SimpComp(int n)
        {
            int count = 0;
            if (n <= 1)
            {
                Console.WriteLine("Enter correct number");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        count++;
                    }
                }
                if (count > 2)
                {
                    Console.WriteLine("Complex");
                }
                else
                {
                    Console.WriteLine("Simple");
                }
            }

        }     // Sum of even numbers in array
        static void SumEven(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
               
            }
            Console.WriteLine(sum);
        }
    }
        
}

    



























