using System;
public class Program
{
	public static void Main()
	{
		Freezer[] freezers = new Freezer[5];

		freezers[0] = new Freezer("Samsung", 200.0);
		freezers[1] = new Freezer("LG", 150.0, -20, true, DateTime.Now.AddMonths(-6));
		freezers[2] = new Freezer("Whirlpool", 250.0);
		freezers[3] = new Freezer("Bosch", 180.0, -18, false, DateTime.Now.AddYears(-1));
		freezers[4] = new Freezer("Electrolux", 300.0);

		foreach (Freezer freezer in freezers)
		{
			Console.WriteLine(freezer.ToString());
		}

		Console.WriteLine($"Total Freezers: {Freezer.GetTotalFreezers()}");
		Console.WriteLine($"Total Capacity: {Freezer.GetTotalCapacity()}L");
	}
}
public partial class Freezer
{
	private string brand;
	private double capacity;
	private int temperature;
	private bool isOn;
	private DateTime manufactureDate;

	private static int totalFreezers;
	private static double totalCapacity;

	static Freezer()
	{
		totalFreezers = 0;
		totalCapacity = 0.0;
	}

	public Freezer() : this("Unknown", 0.0, -18, false, DateTime.Now) { }
	public Freezer(string brand, double capacity)
	{
		this.brand = brand;
		this.capacity = capacity;
		this.temperature = -18;
		this.isOn = false;
		this.manufactureDate = DateTime.Now;

		totalFreezers++;
		totalCapacity += capacity;
	}

	public Freezer(string brand, double capacity, int temperature, bool isOn, DateTime manufactureDate)
	{
		this.brand = brand;
		this.capacity = capacity;
		this.temperature = temperature;
		this.isOn = isOn;
		this.manufactureDate = manufactureDate;

		totalFreezers++;
		totalCapacity += capacity;
	}

	public void SetTemperature(ref int newTemperature)
	{
		this.temperature = newTemperature;
	}

	public override string ToString()
	{
		return $"Brand: {brand}, Capacity: {capacity}L, Temperature: {temperature}°C, Is On: {isOn}, Manufacture Date: {manufactureDate.ToShortDateString()}";
	}

	public static int GetTotalFreezers()
	{
		return totalFreezers;
	}

	public static double GetTotalCapacity()
	{
		return totalCapacity;
	}
}

public partial class Freezer
{
	public void TurnOn()
	{
		isOn = true;
	}

	public void TurnOff()
	{
		isOn = false;
	}

	public void ChangeBrand(string newBrand)
	{
		brand = newBrand;
	}

	public string GetBrand()
	{
		return brand;
	}

	public double GetCapacity()
	{
		return capacity;
	}

	public int GetTemperature()
	{
		return temperature;
	}

	public bool GetIsOn()
	{
		return isOn;
	}

	public DateTime GetManufactureDate()
	{
		return manufactureDate;
	}
}