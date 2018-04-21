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
            int N=InputSizeOfSequence();
            short[] sequence = InputSequence(N);
            CalculateAndShowSequenceParameters(sequence);
        }

        static int InputSizeOfSequence()
        {
            int size = 0;
            Console.Clear();
            do
            {
                try
                {
                    Console.Write("Введите число элементов (для ввода):");
                    size = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка при вводе числа!!!");
                }
            } while (size <= 0);
            return size;
        }
        
        static short[] InputSequence(int size)
        {
            short[] sequence = new short[size];
            Console.Clear();
            Console.WriteLine("Введите последовательность целых чисел (от {0} до {1})", short.MinValue, short.MaxValue);
            for (int j = 0; j < size; j++)
            {
                long temp=long.MinValue;
                do
                {
                    try
                    {
                        Console.Write("Введите {0}-е число:", j + 1);
                        temp = Convert.ToInt64(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка при вводе числа!!!");
                    }
                } while (temp < short.MinValue || temp > short.MaxValue);
                sequence[j] = Convert.ToInt16(temp.ToString());
            }
            return sequence;
        }

        static void CalculateAndShowSequenceParameters(short[] sequence)
        {
            int sumOfValues = 0;
            short minValue = short.MaxValue;
            short maxValue = short.MinValue;
            int countOfEvens = 0;
            double productOfOdds = 1;
            int countOfOdds = 0;
            foreach (short i in sequence)
            {
                sumOfValues += i;
                if (i > maxValue) maxValue = i;
                if (i < minValue) minValue = i;
                if (i % 2 == 0) countOfEvens++;
                else { productOfOdds *= i; countOfOdds++; }
            }
            Console.WriteLine("Сумма чисел={0}, максимум={1}, минимум={2}", sumOfValues, maxValue, minValue);
            Console.WriteLine($"Количество четных чисел={countOfEvens}");
            Console.WriteLine("Произведение нечетных чисел={0:e}", countOfOdds > 0 ? productOfOdds : 0);
        }
    }
}
