using System;
using System.Text;

class Freezer
{
    private string name;
    private string model;
    private int capacity;
    private int minTemperature;
    private int kWhPerDay;

    public string Name
    {
        get => name;
        set => name = value;
    }

    public string Model
    {
        get => model;
        set => model = value;
    }

    public int Capacity
    {
        get => capacity;
        set => capacity = value;
    }

    public int MinTemperature
    {
        get => minTemperature;
        set => minTemperature = value;
    }

    public int KWhPerDay
    {
        get => kWhPerDay;
        set => kWhPerDay = value;
    }

    // Main constructor
    public Freezer(string name, string model, int capacity,
                   int minTemperature, int kWhPerDay)
    {
        Name = name;
        Model = model;
        Capacity = capacity;
        MinTemperature = minTemperature;
        KWhPerDay = kWhPerDay;
    }

    // Delegation
    public Freezer(string name)
        : this(name, "Unknown", 0, 0, 0)
    {
    }

    public Freezer(string name, string model)
        : this(name, model, 0, 0, 0)
    {
    }

    public Freezer(string name, string model, int capacity)
        : this(name, model, capacity, 0, 0)
    {
    }

    public Freezer(string name, string model,
                   int capacity, int minTemperature)
        : this(name, model, capacity, minTemperature, 0)
    {
    }

    // Default constructor
    public Freezer()
        : this("Unknown", "Unknown", 0, 0, 0)
    {
    }

    public override string ToString()
    {
        return $"Name: {Name}\n" +
               $"Model: {Model}\n" +
               $"Capacity: {Capacity} liters\n" +
               $"Minimum Temperature: {MinTemperature} °C\n" +
               $"Energy Consumption: {KWhPerDay} kWh/day\n";
    }
}

class Program
{
    static void Main()
    {
        Freezer[] freezers = new Freezer[5];
        freezers[0] = new Freezer("Gorenje");
        freezers[1] = new Freezer("Samsung", "RT38K5530S9");
        freezers[2] = new Freezer("Siemens", "GS36NVIEP", 300);
        freezers[3] = new Freezer("Bosch", "GSV36VW", 350, -18);
        freezers[4] = new Freezer("Miele", "FN 28263 ws", 400, -20, 1);

        for (int i = 0; i < freezers.Length; i++)
        {
            Console.WriteLine($"Freezer {i + 1}:");
            Console.WriteLine(freezers[i].ToString());
        }
    }
}
