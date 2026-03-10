namespace FoodTruckPOS.Core.Models;

public class Order
{
    public List<OrderItem> Items { get; set; } = new();

    public decimal GetTotal()
    {
        return Items.Sum(i => i.TotalPrice);
    }
}