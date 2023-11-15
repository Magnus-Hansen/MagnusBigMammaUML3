using MagnusBigMammaUML3;

namespace MenuCatalogTestProject
{
    [TestClass]
    public class CatalogTest
    {
        IMenuCatalog menuCatalog = new MenuCatalog();
        public void Setup()
        {
            Pizza pizza = new Pizza(1, "Margherita", "Tomat & ost", 69, MenuType.Pizza, true, true, false);
            Beverage beverage = new Beverage(2, "Vand", "Lige fra hanen", 40, MenuType.SoftDrink, true, true, true);
            menuCatalog.Add(pizza);
            menuCatalog.Add(beverage);
        }
        [TestMethod]
        public void AddMenuItem()
        {
            Setup();

            int numberBefore = menuCatalog.Count;
            Pizza p1 = new Pizza(3, "test", "testing", 2, MenuType.Pizza, false, false, true);
            menuCatalog.Add(p1);
            int numberAfter = menuCatalog.Count;

            Assert.AreEqual(++numberBefore, numberAfter);
        }
        [TestMethod]
        public void SearchItem()
        {
            Setup();

            Pizza p1 = new Pizza(3, "test", "testing", 2, MenuType.Pizza, false, false, true);
            menuCatalog.Add(p1);

            Assert.AreEqual(p1, menuCatalog.Search(3));
        }
        [TestMethod]
        public void DeleteMenuItem()
        {
            Setup();

            int numberBefore = menuCatalog.Count;
            menuCatalog.Delete(2);
            int numberAfter = menuCatalog.Count;

            Assert.AreEqual(--numberBefore, numberAfter);
        }
    }
}