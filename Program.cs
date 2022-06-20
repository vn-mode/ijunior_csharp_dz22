using System;

namespace vn_mode_csharp_dz22
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 30;
            int[] numbers = new int[arraySize];
            int minIntNumber = 1;
            int maxIntNumber = 10;
            Random random = new Random();

            for (int i = 0; i < arraySize; i++)
            {
                numbers[i] = random.Next(minIntNumber, maxIntNumber);
            }

            Console.WriteLine("Исходный массив целых чисел:");

            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n\nВсе локальные максимумы: ");

            if (numbers[0] > numbers[1])
            {
                Console.Write(numbers[0] + " ");
            }

            for (int i = 0; i < arraySize - 2; i++)
            {
                if(numbers[i + 1] > numbers[i] && numbers[i + 1] > numbers[i + 2])
                {
                    Console.Write(numbers[i + 1] + " ");
                }
            }

            if (numbers[arraySize - 1] > numbers[arraySize - 2])
            {
                Console.Write(numbers[arraySize - 1] + " ");
            }

        }
    }
}
