using System;
using System.Collections;
using System.Collections.Generic;
namespace _05_Class___struct
{
	class Calculator
	{
		public double Add(double a, double b)
		{
			return a + b;
		}

		public double Sub(double a, double b)
		{
			return a - b;
		}

		public double Mul(double a, double b)
		{
			return a * b;
		}

		public double Div(double a, double b)
		{
			if (b == 0)
			{
				throw new DivideByZeroException("Division by zero is not allowed.");
			}
			return a / b;
		}
	}
	class Worker
	{
		private string fullName;
		private int age;
		private decimal salary;
		private DateTime hireDate;

		public string FullName
		{
			get { return fullName; }
			set
			{
				if (string.IsNullOrWhiteSpace(value))
					throw new ArgumentException("Surname and initials cannot be empty or contain only spaces.");
				fullName = value;
			}
		}

		public int Age
		{
			get { return age; }
			set
			{
				if (value <= 0 || value > 120)
					throw new ArgumentOutOfRangeException("Age must be between 1 and 120.");
				age = value;
			}
		}

		public decimal Salary
		{
			get { return salary; }
			set
			{
				if (value < 0)
					throw new ArgumentException("Salary cannot be negative.");
				salary = value;
			}
		}

		public DateTime HireDate
		{
			get { return hireDate; }
			set { hireDate = value; }
		}

		public Worker(string fullName, int age, decimal salary, DateTime hireDate)
		{
			FullName = fullName;
			Age = age;
			Salary = salary;
			HireDate = hireDate;
		}

		public override string ToString()
		{
			return $"{FullName}, Age: {Age}, Salary: {Salary:C}, Hired on: {HireDate:d}";
		}

		public int CalculateYearsOfWork()
		{
			DateTime currentDate = DateTime.Today;
			int years = currentDate.Year - HireDate.Year;
			if (HireDate > currentDate.AddYears(-years))
				years--;
			return years;
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			ArrayList workers = new ArrayList();

			try
			{
				for (int i = 0; i < 5; i++)
				{
					Console.WriteLine($"Enter data for employee #{i + 1}:");

					Console.Write("Surname and initials: ");
					string fullName = Console.ReadLine();

					Console.Write("Age: ");
					int age = int.Parse(Console.ReadLine());

					Console.Write("Salary: ");
					decimal salary = decimal.Parse(Console.ReadLine());

					Console.Write("Hiring date (in dd/mm/yyyy format): ");
					DateTime hireDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

					workers.Add(new Worker(fullName, age, salary, hireDate));
				}

				Console.WriteLine("Enter the maximum length of service to search for an employee:");
				int maxYearsOfWork = int.Parse(Console.ReadLine());

				Console.WriteLine($"List of employees with more than {maxYearsOfWork} years:");
				foreach (Worker worker in workers)
				{
					int yearsOfWork = worker.CalculateYearsOfWork();
					if (yearsOfWork > maxYearsOfWork)
					{
						Console.WriteLine($"{worker.FullName}, Work experience: {yearsOfWork} years");
					}
				}
			}
			catch (FormatException e)
			{
				Console.WriteLine($"Input format error: {e.Message}");
			}
			catch (ArgumentException e)
			{
				Console.WriteLine($"Error: {e.Message}");
			}
			catch (Exception e)
			{
				Console.WriteLine($"Error: {e.Message}");
			}




			Calculator calculator = new Calculator();

			try
			{
				Console.WriteLine("Enter the first number:");
				double num1 = double.Parse(Console.ReadLine());

				Console.WriteLine("Enter the second number:");
				double num2 = double.Parse(Console.ReadLine());

				Console.WriteLine("Choose an operation (+, -, *, /):");
				string operation = Console.ReadLine();

				double result = 0;

				switch (operation)
				{
					case "+":
						result = calculator.Add(num1, num2);
						break;
					case "-":
						result = calculator.Sub(num1, num2);
						break;
					case "*":
						result = calculator.Mul(num1, num2);
						break;
					case "/":
						result = calculator.Div(num1, num2);
						break;
					default:
						throw new InvalidOperationException("Invalid operation. Please choose one of +, -, *, /.");
				}

				Console.WriteLine($"The result of {num1} {operation} {num2} is {result}");
			}
			catch (FormatException e)
			{
				Console.WriteLine($"Input error: {e.Message}");
			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine($"Error: {e.Message}");
			}
			catch (InvalidOperationException e)
			{
				Console.WriteLine($"Error: {e.Message}");
			}
			catch (Exception e)
			{
				Console.WriteLine($"An unexpected error occurred: {e.Message}");
			}
		}
	}
}
