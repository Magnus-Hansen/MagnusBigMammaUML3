using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagnusBigMammaUML3
{
    public class Pasta : MenuItem
    {
        public Pasta(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic) : base(number, name, description, price, type, isVegan, isOrganic)
        {
            
        }
    }
}
