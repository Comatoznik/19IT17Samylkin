using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next();
            for (int i = 0; i < array.Length; i++)

                Console.WriteLine(array[i]);
            Console.WriteLine("Начало сортировки");
            for (int i = 0; i < array.Length; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;

                    }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Отсортированный массив :[{0}]={1}", i, array[i]);
            }
        }
    }
}