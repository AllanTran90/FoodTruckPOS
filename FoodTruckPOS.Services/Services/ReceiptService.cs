using FoodTruckPOS.Core.Models;

namespace FoodTruckPOS.Services;

public class ReceiptService
{
    public void PrintReceipt(Order order)
    {
        Console.WriteLine("\n--- RECEIPT ---");

        foreach (var item in order.Items)
        {
            Console.WriteLine($"{item.Quantity} x {item.Item.Name} - {item.TotalPrice} kr");
        }

        Console.WriteLine($"TOTAL: {order.GetTotal()} kr");
        Console.WriteLine("Thank you!");
    }
}