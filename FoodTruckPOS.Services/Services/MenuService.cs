using FoodTruckPOS.Core.Models;

namespace FoodTruckPOS.Services;

public class MenuService
{
    public List<MenuItem> Menu { get; } = new()
    {
        new MenuItem("Dumplings", 89),
        new MenuItem("Bao", 50),
        new MenuItem("Fried Rice", 89),
        new MenuItem("Korean Fried Chicken", 89)
    };

    public void ShowMenu()
    {
        Console.WriteLine("\n--- MENU ---");

        for (int i = 0; i < Menu.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Menu[i].Name} - {Menu[i].Price} kr");
        }
    }
}

