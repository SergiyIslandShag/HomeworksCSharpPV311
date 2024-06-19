namespace String;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;


internal class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("#1");
		string originalString = "Hello, world!";
		string insertString = "beautiful ";
		Console.WriteLine("Enter position : ");
		int position = int.Parse(Console.ReadLine());
		string newString = originalString.Insert(position, insertString);
		Console.WriteLine(newString);
		Console.WriteLine();


		Console.WriteLine("#2");
		string str;
		Console.Write("Enter the string : ");
		str = Console.ReadLine();
		char[] stringArray = str.ToCharArray();
		Array.Reverse(stringArray);
		string reversedStr = new string(stringArray);
		Console.WriteLine(reversedStr);
		if (str == reversedStr)
		{
			Console.WriteLine("The string is a palindrome");
		}
		else
		{
			Console.WriteLine("String is not a palindrome");
		}
		Console.WriteLine();

		Console.WriteLine("#3");
		string Text = "The text is given. " +
			"Determine the percentage ratio of lowercase and uppercase " +
			"letters to the total number of characters in it.";
		Console.WriteLine(Text);
		int totalChars = Text.Length;
		int lowerCase = 0;
		int upperCase = 0;

		foreach (char c in Text)
		{
			if (char.IsLower(c))
				lowerCase++;
			else if (char.IsUpper(c))
				upperCase++;
		}

		double lowerCasePercentage = (double)lowerCase / totalChars * 100;
		double upperCasePercentage = (double)upperCase / totalChars * 100;

		Console.WriteLine($"Lowercase letters: {lowerCasePercentage:F2}%");
		Console.WriteLine($"Uppercase letters: {upperCasePercentage:F2}%");
		Console.WriteLine();


		Console.WriteLine("#4");
		string[] array = { "Home", "Italia", "Europa", "Car" };
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].Length >= 5)
			{
				array[i] = array[i].Substring(0, array[i].Length - 3) + "$$$";
			}
		}

		foreach (string word in array)
		{
			Console.WriteLine(word);
		}
		Console.WriteLine();


		Console.WriteLine("#5");
		string text = "Find the word that is in the text under a certain number, " +
			"and display its first letter.";
		string words = "display";

		int wordIndex = Array.IndexOf(text.Split(), words);
		char firstLetter = text.Split()[wordIndex][0];
		Console.WriteLine($"The first letter of the word '{words}' in the text: {firstLetter}");
		Console.WriteLine();


		Console.WriteLine("#6");
		static string FixString(string inputString)
		{
			inputString = inputString.Replace(" ", " ");
			inputString = inputString.Trim();
			inputString = inputString.Replace(" ", "*");
			return inputString;
		}

		string originalString1 = "Example   string   with   several   spaces.";
		string fixedString = FixString(originalString1);
		Console.WriteLine($"Original string: {originalString1}");
		Console.WriteLine($"Fixed String: {fixedString}");
		Console.WriteLine();


		Console.WriteLine("#7");
		string input;
		StringBuilder result = new StringBuilder();

		while (true)
		{
			input = Console.ReadLine();
			if (input.EndsWith("."))
			{
				result.Append(input);
				break;
			}
			else
			{
				if (result.Length > 0)
				{
					result.Append(", ");
				}
				result.Append(input);
			}
		}

		Console.WriteLine(result.ToString());






	}
}

