using Newtonsoft.Json;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var Lada = new Car(){
    Make = "Lada",
    Model = "Niva",
    Year = 2024
};

var jsonText = JsonConvert.SerializeObject(Lada);
Console.WriteLine(jsonText);

public class Car
{
    public required string Make { get; set; }
    public required string Model { get; set; }
    public required int Year { get; set; }
}
