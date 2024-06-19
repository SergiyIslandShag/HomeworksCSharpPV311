namespace Intro_to_Microsoft_.NET._Типu_даннuх_
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("#1");
			Console.WriteLine("It's easy to win forgiveness for being wrong;");
			Console.WriteLine("being right is what gets you into real trouble.");
			Console.WriteLine("Bjarne Stroustrup");

			Console.WriteLine("#2");

			Console.WriteLine("Enter number 1 : ");
			string num1 = Console.ReadLine();
			int number1 = int.Parse(num1);
			Console.WriteLine("Enter number 2 : ");
			string num2 = Console.ReadLine();
			int number2 = int.Parse(num2);
			Console.WriteLine("Enter number 3 : ");
			string num3 = Console.ReadLine();
			int number3 = int.Parse(num3);
			Console.WriteLine("Enter number 4 : ");
			string num4 = Console.ReadLine();
			int number4 = int.Parse(num4);
			Console.WriteLine("Enter number 5 : ");
			string num5 = Console.ReadLine();
			int number5 = int.Parse(num5);

			int sum = number1 + number2 + number3 + number4 + number5;
			Console.WriteLine("Summa = " + sum);

			if (number1 > number2 && number1 > number3 && number1 > number4 && number1 > number5)
			{
				Console.WriteLine("The most bigger number is: " + number1);
			}
			else if (number2 > number1 && number2 > number3 && number2 > number4 && number2 > number5)
			{
				Console.WriteLine("The most bigger number is: " + number2);
			}
			else if (number3 > number1 && number3 > number2 && number3 > number4 && number3 > number5)
			{
				Console.WriteLine("The most bigger number is: " + number3);
			}
			else if (number4 > number1 && number4 > number2 && number4 > number3 && number4 > number5)
			{
				Console.WriteLine("The most bigger number is: " + number4);
			}
			else if (number5 > number1 && number5 > number2 && number5 > number3 && number5 > number4)
			{
				Console.WriteLine("The most bigger number is: " + number5);
			}

			if (number1 < number2 && number1 < number3 && number1 < number4 && number1 < number5)
			{
				Console.WriteLine("The most least number is: " + number1);
			}
			else if (number2 < number1 && number2 < number3 && number2 < number4 && number2 < number5)
			{
				Console.WriteLine("The most least number is: " + number2);
			}
			else if (number3 < number1 && number3 < number2 && number3 < number4 && number3 < number5)
			{
				Console.WriteLine("The most least number is: " + number3);
			}
			else if (number4 < number1 && number4 < number2 && number4 < number3 && number4 < number5)
			{
				Console.WriteLine("The most least number is: " + number4);
			}
			else if (number5 < number1 && number5 < number2 && number5 < number3 && number5 < number4)
			{
				Console.WriteLine("The most least number is: " + number5);
			}

			int dobytok = number1 * number2 * number3 * number4 * number5;
			Console.WriteLine("Dobytok = " + dobytok);

			Console.WriteLine("#3");

			Console.WriteLine("Enter number : ");
			string num6 = Console.ReadLine();
			int number6 = int.Parse(num6);
			int firstn = number6 / 100000;
			int secondn = number6 / 10000 % 10;
			int thirdn = number6 / 1000 % 10;
			int firthn = number6 / 100 % 10;
			int fifthn = number6 / 10 % 10;
			int sixth = number6 % 10;
			Console.WriteLine(firstn);
			Console.WriteLine(secondn);
			Console.WriteLine(thirdn);
			Console.WriteLine(firthn);
			Console.WriteLine(fifthn);
			Console.WriteLine(sixth);
			Console.WriteLine(sixth.ToString() + fifthn.ToString() + firthn.ToString() + thirdn.ToString() + secondn.ToString() + firstn.ToString());

			Console.WriteLine("#4");
			Console.Write("Enter the lower limit of the range: ");
			int min = int.Parse(Console.ReadLine());

			Console.Write("Enter the upper limit of the range: ");
			int max = int.Parse(Console.ReadLine());

			Console.WriteLine("Fibonacci numbers in the range from {0} to {1}:", min, max);

			int a = 0, b = 1;
			while (a <= max)
			{
				if (a >= min)
				{
					Console.Write("{0} ", a);
				}
				int temp = a;
				a = b;
				b = temp + b;
			}
			Console.WriteLine();

			Console.WriteLine("#5");
			Console.Write("Enter the lower limit of the range: ");
			int A = int.Parse(Console.ReadLine());

			Console.Write("Enter the upper limit of the range: ");
			int B = int.Parse(Console.ReadLine());

			for (int i = A; i <= B; i++)
			{
				for (int j = 0; j < i; j++)
				{
					Console.Write("{0} ", i);
				}
				Console.WriteLine();
			}

			Console.WriteLine("#6");
			Console.WriteLine("не знаю");
		}
	}
}

