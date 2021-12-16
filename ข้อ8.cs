using System;

namespace Final_test_programming._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number : ");
            int n  = int.Parse(Console.ReadLine());
            char[] number = new char[n];

            Console.WriteLine("Input char : ");
            for(int i = 0;i < n; i++)
            {
                Console.Write("{0}.", i + 1);
                number[i] = char.Parse(Console.ReadLine());
            }
            int minIndex;
            for (int i = 0; i < n; i++)
            {
                minIndex = i;
                for (int j = i; j < n; j++)
                {
                    minIndex = j;
                }
                Swap(ref number, i, minIndex);
            }
            Console.Write("Summation : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0},", number[i]);
            }
        }
        static void Swap(ref char[] number, int index1, int index2)
        {
            char tmp = number[index1];
            number[index1] = number[index2];
            number[index2] = tmp;
        }
    }
}
