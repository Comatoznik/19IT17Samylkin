using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main()
		{
			Random array = new Random(); // объявление рандома
			int[] mas = new int[1000]; // объявление массива
			for (int i = 0; i < 1000; i++)
			{
				mas[i] = array.Next(0, 10000); // заполнение массива mas рандомными числами
			}
			int R = mas[0];  // задаем значение R 
			for (int i = 0; i < mas.Length; i++) // перебираем значения массива
			{
				if (mas[i] > R)
				{
					R = mas[i]; // если элемент больше R, присваем R значение этого элемента
				}
			}
			if ((R % 14 == 0) && (R == ((mas[new Random().Next(0, mas.Length)]) * (mas[new Random().Next(0, mas.Length)])))) /*проверка на условие R кратно 14 и
						равно произведению двух различных элементов*/
			{
				Console.WriteLine("Число R =" + R); // вывод R
			}
			else { Console.WriteLine("-1"); } // если не выполняются условия, выводим -1
			Console.Read();
		}
	}
}
