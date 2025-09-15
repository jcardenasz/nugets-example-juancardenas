using Newtonsoft.Json;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string jsonText = @"{
    'Make': 'Toyota',
    'Model': 'Camry',
    'Year': 2020
}";

Car car = JsonConvert.DeserializeObject<Car>(jsonText);

Console.WriteLine($"Car Make: {car.Make}, Model: {car.Model}, Year: {car.Year}");

public class Car
{
    public required string Make { get; set; }
    public required string Model { get; set; }
    public required int Year { get; set; }
}