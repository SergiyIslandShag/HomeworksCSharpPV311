using System;
using System.Collections.Generic;
using System.Text;

namespace _11_Events
{
	public static class StringExtensions
	{
		public static bool IsPalindrome(this string str)
		{
			string cleanStr = str.Replace(" ", "").ToLower();

			for (int i = 0; i < cleanStr.Length / 2; i++)
			{
				if (cleanStr[i] != cleanStr[cleanStr.Length - 1 - i])
					return false;
			}

			return true;
		}

		public static string Encrypt(this string str, int key)
		{
			StringBuilder encrypted = new StringBuilder();

			foreach (char c in str)
			{
				char encryptedChar = (char)(c + key);
				encrypted.Append(encryptedChar);
			}

			return encrypted.ToString();
		}
	}

	public static class ArrayExtensions
	{
		public static Dictionary<T, int> CountOccurrences<T>(this T[] array)
		{
			Dictionary<T, int> occurrences = new Dictionary<T, int>();

			foreach (T element in array)
			{
				if (occurrences.ContainsKey(element))
					occurrences[element]++;
				else
					occurrences[element] = 1;
			}

			return occurrences;
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			string palindromeTest = "A man a plan a canal Panama";
			bool isPalindrome = palindromeTest.IsPalindrome();
			Console.WriteLine($"Is the string \"{palindromeTest}\" a palindrome? {isPalindrome}");

			string original = "Hello";
			string encrypted = original.Encrypt(3);
			Console.WriteLine($"Original: {original}");
			Console.WriteLine($"Encrypted: {encrypted}");

			int[] array = { 1, 2, 2, 3, 3, 3, 4 };
			var occurrences = array.CountOccurrences();
			Console.WriteLine("Occurrences in the array:");
			foreach (var kvp in occurrences)
			{
				Console.WriteLine($"{kvp.Key} occurs {kvp.Value} times");
			}
		}
	}
}
