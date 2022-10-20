using System;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>Наименьший элемент в последовательности<<<");
            Console.WriteLine("Введите количество чисел в последовательности:");

            int amt = int.Parse(Console.ReadLine());
            int minValue = int.MaxValue;                                //Минимальным значением становится максимальное число
            int i = 1;

            while (i<=amt)
            {
                Console.WriteLine($"Введите {i}-е число:");
                int N = int.Parse(Console.ReadLine());

                if (i == 1)
                    minValue = N;
                else if (N < minValue)
                    minValue = N;
                else
                    minValue = minValue;
                i++;
            }

            Console.WriteLine($"Минимальное число последовательности: {minValue, 4}");

            Console.ReadKey();

        }
    }
}
