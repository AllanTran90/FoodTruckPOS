using FoodTruckPOS.Core.Models;

namespace FoodTruckPOS.Services;

public class OrderService
{
    public Order CurrentOrder { get; private set; } = new();

    public void AddItem(MenuItem item, int quantity)
    {
        CurrentOrder.Items.Add(new OrderItem(item, quantity));
    }

    public void ShowOrder()
    {
        Console.WriteLine("\n--- CURRENT ORDER ---");

        foreach (var orderItem in CurrentOrder.Items)
        {
            Console.WriteLine($"{orderItem.Quantity} x {orderItem.Item.Name} - {orderItem.TotalPrice} kr");
        }
        Console.WriteLine($"Total: {CurrentOrder.GetTotal()} kr");
    }
}