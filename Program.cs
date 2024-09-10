using ConsoleApp1;
using System;

public class Program
{
    public static void Main()
    {
        ProductStore productStore = new ProductStore();

        productStore.AddProduct(new Toy(20m, "Пластик", "Плюшевый медведь"));
        productStore.AddProduct(new Meat(50m, "мясо", "Говядина"));
        productStore.AddProduct(new Meat(21m, "Рыба", "Окунь"));
        productStore.AddProduct(new Drink(15m, "1L", "Milk"));

        productStore.DisplayProducts();
    }
}
