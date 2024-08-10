
using System;
using System.IO;
namespace _12_The_C__threading_model._System.IO_space
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//Console.WriteLine("#1");
			//Console.Write("Enter the file path: ");
			//string filePath = Console.ReadLine();
			//if (File.Exists(filePath))
			//{
			//    string fileContent = File.ReadAllText(filePath);
			//    Console.WriteLine("File content:");
			//    Console.WriteLine(fileContent);
			//}
			//else
			//{
			//    Console.WriteLine("File not found.");
			//}

			//Console.WriteLine("#2");
			//Console.Write("Enter the number of elements: ");
			//int n = Convert.ToInt32(Console.ReadLine());
			//int[] array = new int[n];
			//for (int i = 0; i < n; i++)
			//{
			//    Console.Write($"Enter element {i + 1}: ");
			//    array[i] = Convert.ToInt32(Console.ReadLine());
			//}
			//Console.Write("Enter the file path: ");
			//string filePath = Console.ReadLine();
			//using (StreamWriter writer = new StreamWriter(filePath))
			//{
			//    foreach (int element in array)
			//    {
			//        writer.WriteLine(element);
			//    }
			//}
			//Console.WriteLine("Array saved to file.");

			//Console.WriteLine("#3);
			//Console.Write("Enter the file path: ");
			//string filePath = Console.ReadLine();
			//if (File.Exists(filePath))
			//{
			//    string[] lines = File.ReadAllLines(filePath);
			//    int[] array = new int[lines.Length];
			//    for (int i = 0; i < lines.Length; i++)
			//    {
			//        array[i] = Convert.ToInt32(lines[i]);
			//    }
			//    Console.WriteLine("Array loaded from file:");
			//    foreach (int element in array)
			//    {
			//        Console.WriteLine(element);
			//    }
			//}
			//else
			//{
			//    Console.WriteLine("File not found.");
			//}

			//Console.WriteLine("#4");
			//Random random = new Random();
			//int[] evenNumbers = new int[10000];
			//int[] oddNumbers = new int[10000];
			//int evenCount = 0;
			//int oddCount = 0;
			//for (int i = 0; i < 10000; i++)
			//{
			//    int number = random.Next(0, 10000);
			//    if (number % 2 == 0)
			//    {
			//        evenNumbers[evenCount++] = number;
			//    }
			//    else
			//    {
			//        oddNumbers[oddCount++] = number;
			//    }
			//}
			//using (StreamWriter evenWriter = new StreamWriter("even_numbers.txt"))
			//{
			//    for (int i = 0; i < evenCount; i++)
			//    {
			//        evenWriter.WriteLine(evenNumbers[i]);
			//    }
			//}
			//using (StreamWriter oddWriter = new StreamWriter("odd_numbers.txt"))
			//{
			//    for (int i = 0; i < oddCount; i++)
			//    {
			//        oddWriter.WriteLine(oddNumbers[i]);
			//    }
			//}
			//Console.WriteLine("Statistics:");
			//Console.WriteLine($"Even numbers: {evenCount}");
			//Console.WriteLine($"Odd numbers: {oddCount}");
			Console.WriteLine("#6");
			Console.Write("Enter the file path: ");
			string filePath = Console.ReadLine();
			if (File.Exists(filePath))
			{
				FileStream fileStream = new FileStream(filePath, FileMode.Open);
				StreamReader reader = new StreamReader(fileStream);
				string fileContent = reader.ReadToEnd();
				reader.Close();
				fileStream.Close();
				int sentenceCount = 0;
				int upperCaseCount = 0;
				int lowerCaseCount = 0;
				int vowelCount = 0;
				int consonantCount = 0;
				int digitCount = 0;
				string[] sentences = fileContent.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
				sentenceCount = sentences.Length;
				foreach (char c in fileContent)
				{
					if (char.IsUpper(c))
					{
						upperCaseCount++;
					}
					else if (char.IsLower(c))
					{
						lowerCaseCount++;
					}
					else if ("aeiou".Contains(char.ToLower(c)))
					{
						vowelCount++;
					}
					else if (char.IsLetter(c))
					{
						consonantCount++;
					}
					else if (char.IsDigit(c))
					{
						digitCount++;
					}
				}
				Console.WriteLine("Statistics:");
				Console.WriteLine($"Sentences: {sentenceCount}");
				Console.WriteLine($"Upper case letters: {upperCaseCount}");
				Console.WriteLine($"Lower case letters: {lowerCaseCount}");
				Console.WriteLine($"Vowels: {vowelCount}");
				Console.WriteLine($"Consonants: {consonantCount}");
				Console.WriteLine($"Digits: {digitCount}");
			}
			else
			{
				Console.WriteLine("File not found.");
			}
		}
	}
}
