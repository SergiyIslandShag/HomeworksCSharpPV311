using System;
using System.Collections.Generic;

namespace _09_Delegates
{
	class ArrayOperations
	{
		delegate int CalculationDelegate(int[] array);
		delegate void ModificationDelegate(int[] array);

		static int CountNegatives(int[] array)
		{
			int count = 0;
			foreach (int num in array)
			{
				if (num < 0)
				{
					count++;
				}
			}
			return count;
		}

		static int CalculateSum(int[] array)
		{
			int sum = 0;
			foreach (int num in array)
			{
				sum += num;
			}
			return sum;
		}

		static int CountPrimes(int[] array)
		{
			int count = 0;
			foreach (int num in array)
			{
				if (IsPrime(num))
				{
					count++;
				}
			}
			return count;
		}

		static void ReplaceNegativesWithZero(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] < 0)
				{
					array[i] = 0;
				}
			}
		}

		static void SortArray(int[] array)
		{
			Array.Sort(array);
		}
		static int CompareByParity(int a, int b)
		{
			return (a % 2).CompareTo(b % 2);
		}

		static bool IsPrime(int number)
		{
			if (number <= 1) return false;
			for (int i = 2; i * i <= number; i++)
			{
				if (number % i == 0) return false;
			}
			return true;
		}

		static void MoveEvensToFront(int[] array)
		{
			Array.Sort(array, CompareByParity);
		}

		static int GetValidInput(int min, int max)
		{
			int choice;
			do
			{
				Console.Write("Your choice: ");
			} 
			while (!int.TryParse(Console.ReadLine(), out choice) || choice < min || choice > max);
			return choice;
		}

		class Program
		{
			static void Main()
			{
				int[] numbers = { 5, -3, 2, 11, -8, 7, 1, -21 };

				CalculationDelegate[] calculations = new CalculationDelegate[]
				{
					CountNegatives,
					CalculateSum,
					CountPrimes
				};

				ModificationDelegate[] modifications = new ModificationDelegate[]
				{
					ReplaceNegativesWithZero,
					SortArray,
					MoveEvensToFront
				};

				while (true)
				{
					Console.WriteLine("Choose the type of operation:");
					Console.WriteLine("1. Calculation");
					Console.WriteLine("2. Array modification");
					Console.WriteLine("3. Exit");

					int choice = GetValidInput(1, 3);

					if (choice == 3)
					{
						break;
					}

					if (choice == 1)
					{
						Console.WriteLine("Choose a calculation operation:");
						Console.WriteLine("1. Number of negative elements");
						Console.WriteLine("2. Sum of all elements");
						Console.WriteLine("3. Number of prime numbers");

						int calculationChoice = GetValidInput(1, 3);
						int result = calculations[calculationChoice - 1](numbers);
						Console.WriteLine($"Result: {result}");
					}
					else if (choice == 2)
					{
						Console.WriteLine("Choose an array modification operation:");
						Console.WriteLine("1. Replace negatives with 0");
						Console.WriteLine("2. Sort the array");
						Console.WriteLine("3. Move evens to the front");

						int modificationChoice = GetValidInput(1, 3);
						modifications[modificationChoice - 1](numbers);
						Console.WriteLine("Array modified:");
						Console.WriteLine(string.Join(", ", numbers));
					}
				}
			}
		}
	}
}
