using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagnusBigMammaUML3
{
    public class MenuCatalogList : IMenuCatalog
    {
        public int Count { get; set; }

        public List<IMenuItem> _iMenuItem = new List<IMenuItem>();

        public void Add(IMenuItem aMenuItem)
        {
            bool itemNotExist = true;
            foreach (IMenuItem item in _iMenuItem)
            {
                if (aMenuItem.Number == item.Number)
                    itemNotExist = false;
            }
            if (itemNotExist)
            {
                _iMenuItem.Add(aMenuItem);
                Count++;
            }
            else throw new MenuItemNumberExist($"number {aMenuItem.Number} already exist");

        }
        public IMenuItem Search(int number)
        {
            foreach (IMenuItem item in _iMenuItem)
                if (item.Number == number)
                    return item;
            return null;
        }
        public void Delete(int number)
        {
            foreach (IMenuItem item in _iMenuItem)
                if (item.Number == number)
                {
                    _iMenuItem.Remove(item);
                    Count--;
                    break;
                }

        }
        public void PrintPizzasMenu()
        {
            foreach (IMenuItem aMenuItem in _iMenuItem)
                if (aMenuItem.Type == MenuType.Pizza)
                    Console.WriteLine(aMenuItem.ToString());
        }
        public void PrintBeveragesMenu()
        {
            foreach (IMenuItem aMenuItem in _iMenuItem)
                if (aMenuItem.Type == MenuType.SoftDrink)
                    Console.WriteLine(aMenuItem.ToString());
        }
        public void PrintToppingsMenu()
        {
            foreach (IMenuItem aMenuItem in _iMenuItem)
                if (aMenuItem.Type == MenuType.Topping)
                    Console.WriteLine(aMenuItem.ToString());
        }
        public void Update(int number, IMenuItem theMenuItem)
        {
            foreach (IMenuItem item in _iMenuItem)
                if (item.Number == number)
                    _iMenuItem[number] = theMenuItem;
        }
        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            List<IMenuItem> list = new List<IMenuItem>();
            foreach (IMenuItem aMenuItem in _iMenuItem)
                if (aMenuItem.Type == type)
                {
                    if (aMenuItem.IsVegan)
                    {
                        list.Add(aMenuItem);
                    }
                }
            return list;
        }
        public List<IMenuItem> FindAllOrganic(MenuType type)
        {
            List<IMenuItem> list = new List<IMenuItem>();
            foreach (IMenuItem aMenuItem in _iMenuItem)
                if (aMenuItem.Type == type)
                {
                    if (aMenuItem.IsOrganic)
                    {
                        list.Add(aMenuItem);
                    }
                }
            return list;
        }
        public IMenuItem MostExpensiveMenuItem()
        {
            double mostExpensivePrice = 0.0;
            IMenuItem mostExpensiveMenuItem = null;
            foreach (IMenuItem aMenuItem in _iMenuItem)
            {
                if (aMenuItem.Price > mostExpensivePrice)
                {
                    mostExpensivePrice = aMenuItem.Price;
                    mostExpensiveMenuItem = aMenuItem;
                }
            }
            return mostExpensiveMenuItem;
        }
    }
}
