using EF___Homework.DataAccess.Data;
using Microsoft.EntityFrameworkCore;

var context = new AppDbContext();

var displayCars = context.Cars
    .Include(c => c.Model)
    .ThenInclude(m => m.Brand)
    .Include(c => c.CarColors)
    .ThenInclude(cc => cc.Color)
    .ToList();

foreach (var car in displayCars)
{
    string colors = string.Join(", ", car.CarColors.Select(cc => cc.Color.Name));

    Console.WriteLine($"Id - {car.Id}" + " , " +
                      $"Brand - {car.Model.Brand.Name}" + " , " +
                      $"Model - {car.Model.Name}" + " , " +
                      $"MaxSpeed - {car.MaxSpeed}" + " , " +
                      $"Fuel Capacity - {car.FuelTankCapacity}" + " , " +
                      $"Power - {car.Power}" + " , " +
                      $"Door Count - {car.DoorCount}" + " , " +
                      $"Colors - " + colors);
}
