using System;

class PriceChangeAlert
{
    static void Main()
    {
        FibunacchiNum(long.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
    }

    private static void FibunacchiNum(long times, int range)
    {
        long[] number = new long[times];
        number[number.Length - 1] = 1;
        FibunacchiNumMath(number, range, times);
    }
    static void FibunacchiNumMath(long[] number, int range, long n)
    {

        for (int i = 0; i < n; i++)
        {
            long sum = 0;
            for (int j = number.Length - range; j < number.Length; j++)
            {
                sum += number[j];

            }
            if (i!=n-1)
            {
                for (int k = 1; k < number.Length; k++)
                {
                    number[k - 1] = number[k];
                }
                number[number.Length - 1] = sum;
            }
        }

            foreach (long item in number)
            {
                Console.WriteLine(item +" ");
            }
    }
}