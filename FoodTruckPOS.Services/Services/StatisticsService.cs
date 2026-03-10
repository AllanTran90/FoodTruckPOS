using FoodTruckPOS.Core.Models;

namespace FoodTruckPOS.Services;

public class StatisticsService
{
    private List<Order> orders = new();

    public void AddOrder(Order order)
    {
        orders.Add(order);
    }

    public void ShowStatistics()
    {
        Console.WriteLine("\n--- SALES STATISTICS ---");

        int totalOrders = orders.Count;
        decimal totalRevenue = orders.Sum(o => o.GetTotal());

        Console.WriteLine($"Orders today: {totalOrders}");
        Console.WriteLine($"Revenue today: {totalRevenue} kr");

        var mostSoldItem = orders
            .SelectMany(o => o.Items)
            .GroupBy(i => i.Item.Name)
            .OrderByDescending(g => g.Sum(x => x.Quantity))
            .FirstOrDefault();

        if (mostSoldItem != null)
        {
            Console.WriteLine($"Most sold item: {mostSoldItem.Key}");
        }
    }
}