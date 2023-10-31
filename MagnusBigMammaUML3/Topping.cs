using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagnusBigMammaUML3
{
    public class Topping : MenuItem
    {
        public Topping(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool alcohol) : base(number, name, description, price, type, isVegan, isOrganic)
        {
            
        }
    }
}
