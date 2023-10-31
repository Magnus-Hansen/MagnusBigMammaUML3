using MagnusBigMammaUML3;

internal class Program
{
    private static void Main(string[] args)
    {
        IMenuCatalog menuCatalog = new MenuCatalog();
        Pizza pizza = new Pizza(1, "margarita", "with microplast", 30.5, MenuType.Pizza, false, false, true);
        Beverage beverage = new Beverage(2, "femboy", "milk", 6.9, MenuType.SoftDrink, true, true, false);
        Pasta pasta = new Pasta(3, "spagetti", "code", 42.0, MenuType.Pasta, true, true);

        menuCatalog.Add(pizza);
        menuCatalog.Add(beverage); 
        menuCatalog.Add(pasta);
    }
}