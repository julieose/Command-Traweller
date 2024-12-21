using System;
namespace ConsoleApp
{
    public class SumCalculator
    {
        public int CalculateSum(int start, int end)
        {
            if (start > end)
            {
                throw new ArgumentException("Start cannot be greater than end.");
            }

            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 1;
            int b = 10;
           
            SumCalculator sumCalculator = new SumCalculator();
            Console.WriteLine($"Сумма чисел от {a} до {b} = { sumCalculator.CalculateSum(a, b)}");
        }
    }
}
