using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagnusBigMammaUML3
{
    public class MenuCatalog : IMenuCatalog
    {
        public int Count { get; set; }

        public Dictionary<IMenuItem, int> _iMenuItem = new Dictionary<IMenuItem, int>();

        public void Add(IMenuItem aMenuItem)
        {
            if (!_iMenuItem.ContainsKey(aMenuItem))
                _iMenuItem.Add(aMenuItem, Count);
        }
        //IMenuItem Search(int number)
        //{
            
        //}
        //void Delete(int number)
        //{

        //}
        //void PrintPizzasMenu()
        //{

        //}
        //void PrintBeveragesMenu()
        //{

        //}
        //void PrintToppingsMenu()
        //{

        //}
        //void Update(int number, IMenuItem theMenuItem)
        //{

        //}
        //List<IMenuItem> FindAllVegan(MenuType type)
        //{

        //}
        //List<IMenuItem> FindAllOrganic(MenuType type)
        //{

        //}
        //IMenuItem MostExpensiveMenuItem()
        //{

        //}

    }
}
