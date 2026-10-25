using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("===== TUGAS 2: Abstract Class Item =====");
        List<Item> inventory = new()
        {
            new HealthPotion(),
            new ManaPotion(),
            new Bomb()
        };
 
        foreach (Item item in inventory)
            item.Use();
    }
}
