using System;

class Program
{
	static void Main(string[] args)
	{
		Console.Write("Введите номер билета: ");
		int number = Convert.ToInt32(Console.ReadLine());

		int firstHalfSum = 0;
		int secondHalfSum = 0;

		int digits = 0;
		int tempNumber = number;

		while (tempNumber > 0)
		{
			tempNumber /= 10;
			digits++;
		}

		int halfDigits = digits / 2;

		tempNumber = number;
		int i = 0;

		while (i < halfDigits)
		{
			secondHalfSum += tempNumber % 10;
			tempNumber /= 10;
			i++;
		}

		while (tempNumber > 0)
		{
			firstHalfSum += tempNumber % 10;
			tempNumber /= 10;
		}

		Console.WriteLine("Сумма первой половины: " + firstHalfSum);
		Console.WriteLine("Сумма второй половины: " + secondHalfSum);


		if (secondHalfSum == firstHalfSum)
		{
			Console.WriteLine("Билет удачный");
		}
		else
		{
			Console.WriteLine("Билет неудачный");
		}
	}
}