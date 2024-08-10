namespace _11_Events
{
	public class PriceChangedEventArgs : EventArgs
	{
		public decimal Price { get; }
		public PriceChangedEventArgs(decimal price)
		{
			Price = price;
		}
	}
	public class Exchange
	{
		private decimal price;
		private readonly decimal maxPrice;
		private readonly decimal minPrice;

		private readonly Timer priceChangeTimer;
		private readonly Random random;
		private readonly AutoResetEvent autoEvent;

		public event EventHandler<PriceChangedEventArgs> PriceChanged;
		public event EventHandler<PriceChangedEventArgs> MaxPriceReached;
		public event EventHandler<PriceChangedEventArgs> MinPriceReached;
		public Exchange(decimal startPrice, decimal max, decimal min)
		{
			price = startPrice;
			maxPrice = max;
			minPrice = min;
			random = new Random();
			autoEvent = new AutoResetEvent(true);
			priceChangeTimer = new Timer(ChangePrice, autoEvent, 0, 1000);
		}
		private void ChangePrice(object state)
		{
			autoEvent.WaitOne();
			price += (decimal)(random.NextDouble() * 2 - 1);
			price = Math.Round(price, 2);
			PriceChanged?.Invoke(this, new PriceChangedEventArgs(price));
			if (price >= maxPrice)
			{
				MaxPriceReached?.Invoke(this, new PriceChangedEventArgs(price));
			}
			if (price <= minPrice)
			{
				MinPriceReached?.Invoke(this, new PriceChangedEventArgs(price));
			}
		}
		public void Stop() => priceChangeTimer.Change(Timeout.Infinite, 0);
		public void Pause() => autoEvent.Reset();
		public void Resume() => autoEvent.Set();
	}
	public class Trader
	{
		public string Name { get; }
		public decimal Currency { get; private set; }
		public decimal Cash { get; private set; }
		public Trader(string name, decimal currency, decimal cash)
		{
			Name = name;
			Currency = currency;
			Cash = cash;
		}
		public void Subscribe(Exchange exchange)
		{
			exchange.PriceChanged += (sender, e) => Console.WriteLine($"{Name} sees price change to {e.Price}");
			exchange.MaxPriceReached += (sender, e) => { Console.WriteLine($"{Name} max price {e.Price} reached!"); Sell(e.Price); };
			exchange.MinPriceReached += (sender, e) => { Console.WriteLine($"{Name} min price {e.Price} reached!"); Buy(e.Price); };
		}
		private void Buy(decimal price)
		{
			decimal amount = Cash / price;
			Currency += amount;
			Cash -= amount * price;
			Console.WriteLine($"{Name} bought {amount} at {price}, new balance: {Currency} currency, {Cash} cash");
		}
		private void Sell(decimal price)
		{
			Cash += Currency * price;
			Console.WriteLine($"{Name} sold {Currency} at {price}, new balance: 0 currency, {Cash} cash");
			Currency = 0;
		}
	}
	class Program
	{
		static void Main()
		{
			Exchange exchange = new Exchange(50m, 55m, 45m);

			Trader trader1 = new Trader("Trader1", 10m, 500m);
			Trader trader2 = new Trader("Trader2", 20m, 1000m);

			trader1.Subscribe(exchange);
			trader2.Subscribe(exchange);

			bool running = true;
			while (running)
			{
				Console.WriteLine("Select action:");
				Console.WriteLine("1. Pause exchange");
				Console.WriteLine("2. Resume exchange");
				Console.WriteLine("3. Stop exchange");
				switch (Console.ReadLine())
				{
					case "1":
						exchange.Pause();
						Console.WriteLine("Exchange paused.");
						break;
					case "2":
						exchange.Resume();
						Console.WriteLine("Exchange resumed.");
						break;
					case "3":
						exchange.Stop();
						Console.WriteLine("Exchange stopped.");
						running = false;
						break;
					default:
						Console.WriteLine("Invalid choice. Try again.");
						break;
				}
			}
		}
	}
}
