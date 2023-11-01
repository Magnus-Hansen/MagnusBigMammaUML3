using MagnusBigMammaUML3;
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        IMenuCatalog menuCatalog = new MenuCatalogList();
        //IMenuCatalog menuCatalog = new MenuCatalog();

        Pizza pizza1 = new Pizza(1, "margarita", "with microplast", 30.5, MenuType.Pizza, false, false, true);
        Beverage beverage = new Beverage(2, "femboy", "milk", 6.9, MenuType.SoftDrink, true, true, false);
        Pasta pasta1 = new Pasta(3, "spagetti", "code", 42.0, MenuType.Pasta, true, true);
        Pizza pizza2 = new Pizza(4, "why do we exist", "just to suffer", 55.5, MenuType.Pizza, true, true, false);
        Pasta pasta2 = new Pasta(5, "skirt", "pls give", 50, MenuType.Pasta, false, true);

        menuCatalog.Add(pizza1);
        menuCatalog.Add(beverage);
        menuCatalog.Add(pasta1);

        Console.WriteLine($"{menuCatalog.Search(2)}");

        menuCatalog.Delete(2);
        Console.WriteLine($"{menuCatalog.Search(2)}");

        menuCatalog.Add(pizza2);

        menuCatalog.PrintPizzasMenu();

        menuCatalog.Add(pasta2);
        List<IMenuItem> list = menuCatalog.FindAllOrganic(MenuType.Pasta);
        Console.WriteLine("Find organic:");
        foreach (IMenuItem item in list)
        {
            Console.WriteLine(item.ToString());
        }
        Console.WriteLine("most expensive:");
        Console.WriteLine(menuCatalog.MostExpensiveMenuItem());

        try
        {
            menuCatalog.Add(pizza1);
        }
        catch (MenuItemNumberExist aex)
        {
            Console.WriteLine("you tried to add a pizza - " + aex.Message);
        }
    }
}