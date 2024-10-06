using System;

namespace Pheptoan
{
    public class Program
    {
        static bool IsPerfectNumber(int num)
        {
            if (num < 2) return false;

            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            return sum == num;
        }
        static int Last(int[] array)
        {
            int lastIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (IsPerfectNumber(array[i]))
                {
                    lastIndex = i;
                }
            }
            return lastIndex;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            string[] inputs = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(inputs[i]);
            }
            int result = Last(array);
            Console.Write(result);
        }
    }
}
