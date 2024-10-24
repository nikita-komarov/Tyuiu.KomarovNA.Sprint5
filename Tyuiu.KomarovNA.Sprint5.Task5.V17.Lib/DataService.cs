using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.KomarovNA.Sprint5.Task5.V17.Lib
{
    public class DataService : ISprint5Task5V17
    {
        public double LoadFromDataFile(string path)
        {
            int[] arr = File.ReadAllText(path).Split().Select(el => int.Parse(el)).ToArray();
            double res = 0;
            bool is_prime = true;
            foreach (int num in arr)
            {
                is_prime = true;
                for (int i = 2; i <= (int) (num / 2); i++)
                {
                    //Console.Write($"num={num}, i={i} {num}%{i}={num%i}\t");
                    if (num % i == 0)
                    {
                        is_prime = false;
                    }
                }
                if (num <= 1) is_prime=false;
                if (num == 2) is_prime=true;
                if (is_prime)
                {
                    Console.WriteLine($"ПРОСТОЕ ЧИСЛО: {num}");
                    res += num;
                }
            }
            return Math.Round(res, 3);
        }
    }
}
