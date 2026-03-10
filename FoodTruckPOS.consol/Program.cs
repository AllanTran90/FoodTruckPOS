using FoodTruckPOS.Services;

var menuService = new MenuService();
var orderService = new OrderService();
var receiptService = new ReceiptService();

Console.WriteLine("Welcome to Allan's Food Truck POS!");

menuService.ShowMenu();

Console.Write("\nSelect item number: ");
int itemIndex = int.Parse(Console.ReadLine()!) - 1;

Console.Write("Quantity: ");
int quantity = int.Parse(Console.ReadLine()!);

var selectedItem = menuService.Menu[itemIndex];

orderService.AddItem(selectedItem, quantity);

orderService.ShowOrder();

receiptService.PrintReceipt(orderService.CurrentOrder);