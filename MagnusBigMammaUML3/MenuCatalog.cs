using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MagnusBigMammaUML3
{
    public class MenuCatalog : IMenuCatalog
    {
        public int Count { get; set; }

        public Dictionary<int, IMenuItem> _iMenuItem = new Dictionary<int, IMenuItem>();

        public void Add(IMenuItem aMenuItem)
        {
            if (!_iMenuItem.ContainsKey(aMenuItem.Number))
            {
                _iMenuItem.Add(aMenuItem.Number, aMenuItem);
                Count++;
            }
            else throw new MenuItemNumberExist($"number {aMenuItem.Number} already exist");
        }
        public IMenuItem Search(int number)
        {
            if (_iMenuItem.ContainsKey(number))
                return _iMenuItem[number];
            return null;
        }
        public void Delete(int number)
        {
            if (_iMenuItem.ContainsKey(number))
            {
                _iMenuItem.Remove(number);
                Count--;
            }
        }
        public void PrintPizzasMenu()
        {
            foreach (IMenuItem aMenuItem in _iMenuItem.Values)
                if (aMenuItem.Type == MenuType.Pizza)
                    Console.WriteLine(aMenuItem.ToString());
        }
        public void PrintBeveragesMenu()
        {
            foreach (IMenuItem aMenuItem in _iMenuItem.Values)
                if (aMenuItem.Type == MenuType.SoftDrink)
                    Console.WriteLine(aMenuItem.ToString());
        }
        public void PrintToppingsMenu()
        {
            foreach (IMenuItem aMenuItem in _iMenuItem.Values)
                if (aMenuItem.Type == MenuType.Topping)
                    Console.WriteLine(aMenuItem.ToString());
        }
        public void Update(int number, IMenuItem theMenuItem)
        {
            if (_iMenuItem.ContainsKey(number))
                _iMenuItem[number] = theMenuItem;
        }
        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            List<IMenuItem> list = new List<IMenuItem>();
            foreach (IMenuItem aMenuItem in _iMenuItem.Values)
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
            foreach (IMenuItem aMenuItem in _iMenuItem.Values)
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
            foreach (IMenuItem aMenuItem in _iMenuItem.Values)
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
