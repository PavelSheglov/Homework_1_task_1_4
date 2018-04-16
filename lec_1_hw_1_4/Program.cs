using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec_1_hw_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int N;
                do
                {
                    Console.Write("Введите число элементов (для ввода):");
                    N = Convert.ToInt32(Console.ReadLine());
                } while (N <= 0);
                short[] arr = new short[N];
                Console.WriteLine("Введите последовательность целых чисел (от {0} до {1})", short.MinValue, short.MaxValue);
                for (int j = 0; j < N; j++)
                {
                    long temp;
                    do
                    {
                        Console.Write("Введите {0}-е число:", j + 1);
                        temp = Convert.ToInt64(Console.ReadLine());
                    } while (temp < short.MinValue || temp > short.MaxValue);
                    arr[j] = Convert.ToInt16(temp.ToString());
                }
                int sum = 0;
                short min = short.MaxValue;
                short max = short.MinValue;
                int cnt = 0;
                double prod = 1;
                int cntodd = 0;
                foreach (short i in arr)
                {
                    sum += i;
                    if (i > max) max = i;
                    if (i < min) min = i;
                    if (i % 2 == 0) cnt++;
                    else { prod *= i; cntodd++; }
                }
                Console.WriteLine("Сумма чисел={0}, максимум={1}, минимум={2}", sum, max, min);
                Console.WriteLine($"Количество четных чисел={cnt}");
                Console.WriteLine("Произведение нечетных чисел={0:e}", cntodd > 0 ? prod : 0);
            }
            catch(FormatException)
            {
                Console.WriteLine("Ошибки при вводе чисел!!!");
            }
        }
    }
}
