using System;

namespace vn_mode_csharp_dz22
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 30;
            int[] arrayNumbers = new int[arraySize];
            int minIntNumber = 1;
            int maxIntNumber = 10;
            Random random = new Random();

            for (int i = 0; i < arraySize; i++)
            {
                arrayNumbers[i] = random.Next(minIntNumber, maxIntNumber);
            }

            Console.WriteLine("Исходный массив целых чисел:");

            foreach (var item in arrayNumbers)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n\nВсе локальные максимумы: ");

            if (arrayNumbers[0] > arrayNumbers[1])
            {
                Console.Write(arrayNumbers[0] + " ");
            }

            for (int i = 0; i < arraySize - 2; i++)
            {
                if(arrayNumbers[i + 1] > arrayNumbers[i] && arrayNumbers[i + 1] > arrayNumbers[i + 2])
                {
                    Console.Write(arrayNumbers[i + 1] + " ");
                }
            }

            if (arrayNumbers[arraySize - 1] > arrayNumbers[arraySize - 2])
            {
                Console.Write(arrayNumbers[arraySize - 1] + " ");
            }

        }
    }
}
