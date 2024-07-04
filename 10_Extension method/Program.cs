namespace _10_Extension_method
{
	public static class String
	{
		public static bool IsPalindrome(this string input)
		{
			string cleanedInput = input.Replace(" ", "").ToLower();

			for (int i = 0; i < cleanedInput.Length / 2; i++)
			{
				if (cleanedInput[i] != cleanedInput[cleanedInput.Length - i - 1])
				{
					return false;
				}
			}
			return true;
		}

		public static string Encrypt(this string str, int key)
		{
			char[] encryptedChars = new char[str.Length];

			for (int i = 0; i < str.Length; i++)
			{
				char currentChar = str[i];
				char encryptedChar = (char)(currentChar + key);
				encryptedChars[i] = encryptedChar;
			}
			return new string(encryptedChars);
		}

		public static int CountOccurrences(this Array array, object element)
		{
			int count = 0;

			foreach (var item in array)
			{
				if (item.Equals(element))
				{
					count++;
				}
			}

			return count;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("#1");
			string palindrome1 = "A man a plan a canal Panama";
			Console.WriteLine($"Is {palindrome1} a palindrome? {palindrome1.IsPalindrome()}");
			string palindrome2 = "racecar";
			Console.WriteLine($"Is {palindrome2} a palindrome? {palindrome2.IsPalindrome()}");
			string notPalindrome = "hello world";
			Console.WriteLine($"Is {notPalindrome} a palindrome? {notPalindrome.IsPalindrome()}");
			string emptyString = "";
			Console.WriteLine($"Is {emptyString} a palindrome? {emptyString.IsPalindrome()}");


			Console.WriteLine("#2");
			string originalString = "Hello";
			int key = 3;
			string encryptedString = originalString.Encrypt(key);
			Console.WriteLine($"Encrypt String: {encryptedString}");


			Console.WriteLine("#3");
			int[] numbers = { 1, 2, 3, 4, 2, 2, 5, 6, 2 };
			int elementToCount = 2;

			int occurrences = numbers.CountOccurrences(elementToCount);
			Console.WriteLine($"Number of occurrences of {elementToCount}: {occurrences}");
		}
	}
}
