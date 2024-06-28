namespace _06_Exceptions__namespace
{
	class Program
	{
		public class BankCard
		{
			private string cardNumber;
			private string cardholderName;
			private String cvc;
			private DateTime expirationDate;

			public BankCard(string cardNumber, string cardholderName, string cvc, DateTime expirationDate)
			{
				CardNumber = cardNumber;
				CardholderName = cardholderName;
				CVC = cvc;
				ExpirationDate = expirationDate;
			}

			public string CardNumber
			{
				get { return cardNumber; }
				set
				{
					if (string.IsNullOrEmpty(value) || value.Length != 16)
					{
						throw new ArgumentException("Invalid card number.");
					}
					cardNumber = value;
				}
			}

			public string CardholderName
			{
				get { return cardholderName; }
				set
				{
					if (string.IsNullOrEmpty(value))
					{
						throw new ArgumentException("Cardholder name cannot be empty.");
					}
					cardholderName = value;
				}
			}

			public string CVC
			{
				get { return cvc; }
				set
				{
					if (value.Length != 3)
					{
						throw new ArgumentException("Invalid CVC code.");
					}
					cvc = value;
				}
			}

			public DateTime ExpirationDate
			{
				get { return expirationDate; }
				set
				{
					if (value < DateTime.Now)
					{
						throw new ArgumentException("The card has expired.");
					}
					expirationDate = value;
				}
			}
		}



		static void Main(string[] args)
		{
			Console.WriteLine("#1");
			try
			{
				Console.WriteLine("Enter a numeric value 0-9: ");
				string inputString = Console.ReadLine();

				int number = int.Parse(inputString);

				Console.WriteLine($"Number: {number}");
			}
			catch (FormatException ex)
			{
				Console.WriteLine($"Formatting error: {ex.Message}");
			}
			catch (OverflowException ex)
			{
				Console.WriteLine($"Out of range: {ex.Message}");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Unexpected error: {ex.Message}");
			}

			Console.WriteLine("#2");
			try
			{
				Console.WriteLine("Enter card number (16 digits):");
				string cardNumber = Console.ReadLine();

				Console.WriteLine("Enter cardholder name:");
				string cardholderName = Console.ReadLine();

				Console.WriteLine("Enter CVC code (3 digits):");
				string cvc = Console.ReadLine();

				Console.WriteLine("Enter expiration date (MM/yyyy):");
				string expirationDateInput = Console.ReadLine();
				DateTime expirationDate = DateTime.ParseExact(expirationDateInput, "MM/yyyy", null);

				BankCard bankCard = new BankCard(cardNumber, cardholderName, cvc, expirationDate);

				Console.WriteLine("\nBank card created successfully:");
				Console.WriteLine($"Card Number: {bankCard.CardNumber}");
				Console.WriteLine($"Cardholder Name: {bankCard.CardholderName}");
				Console.WriteLine($"CVC: {bankCard.CVC}");
				Console.WriteLine($"Expiration Date: {bankCard.ExpirationDate:MM/yyyy}");
			}
			catch (FormatException e)
			{
				Console.WriteLine($"Input format error: {e.Message}");
			}
			catch (ArgumentException e)
			{
				Console.WriteLine($"Argument error: {e.Message}");
			}
			catch (Exception e)
			{
				Console.WriteLine($"An unexpected error occurred: {e.Message}");
			}
		}
	}
}

