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
            int tempCenterNumber, tempLeftNumber, tempRightNumber, firstNumber, lastNumber;
            Random random = new Random();

            for (int i = 0; i < arraySize; i++)
            {
                arrayNumbers[i] = random.Next(minIntNumber, maxIntNumber);
            }

            firstNumber = arrayNumbers[0];
            lastNumber = arrayNumbers[arraySize - 1];

            Console.WriteLine("Исходный массив целых чисел:");

            foreach (var number in arrayNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n\nВсе локальные максимумы: ");

            if (firstNumber > arrayNumbers[1])
            {
                Console.Write(firstNumber + " ");
            }

            for (int i = 0; i < arraySize - 2; i++)
            {
                tempLeftNumber = arrayNumbers[i];
                tempCenterNumber = arrayNumbers[i + 1];
                tempRightNumber = arrayNumbers[i + 2];

                if(tempCenterNumber > tempLeftNumber && tempCenterNumber > tempRightNumber)
                {
                    Console.Write(tempCenterNumber + " ");
                }
            }

            if (lastNumber > arrayNumbers[arraySize - 2])
            {
                Console.Write(lastNumber + " ");
            }
        }
    }
}
