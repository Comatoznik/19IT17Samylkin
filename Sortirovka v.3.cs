using System;

namespace ConsoleApp4
{
    class QuickSorting
    {
        public static void sorting(double[] mass, long first, long last)
        {
            double p = mass[(last - first) / 2 + first];
            double temp;
            long i = first, j = last; // ввод переменных
            while (i <= j)
            {
                while (mass[i] < p && i <= last) ++i;
                while (mass[j] > p && j >= first)--j;
                if (i <= j) // перебор элементов массива
                {
                    temp = mass[i];
                    mass[i] = mass[j];
                    mass[j] = temp;
                    ++i; --j; 
                }
            }
            if (j > first) sorting(mass, first, j);
            if (i < last) sorting(mass, i, last); // непосредственно процесс сортировки
        }
    }
    class test
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ввведите сколько элементов в массиве:");
            int n = int.Parse(Console.ReadLine());
            double[] mass = new double[n];
            var rand = new Random();
            //объявляем массив и заполняем его рандомными числами
            for (var i = 0; i < mass.Length; i++)
                mass[i] = rand.Next(50);
            double max = mass[0];
            
            for (int i = 0; i < mass.Length; i++)
            {
                if (max < mass[i])
                {
                    max = mass[i];
                }
            } // поиск максимального значения в массиве

            Console.WriteLine("Сгенерированный массив:");
            foreach (double x in mass)
            {
                Console.Write(x + " ");
            } // вывод массива на экран
            
            QuickSorting.sorting(mass, 0, mass.Length - 1); // обращаемся к классу QuickSorting, который сортирует массив, затем выводим массив на экран
            Console.WriteLine("\nОтсортированный массив:");
            foreach (double x in mass)
            {
                Console.Write(x + " ");
            }
            
            Console.ReadLine();
        }
    }
}
