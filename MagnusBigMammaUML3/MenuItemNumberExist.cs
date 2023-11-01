using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagnusBigMammaUML3
{
    public class MenuItemNumberExist : Exception
    {
        public MenuItemNumberExist(string message):base(message)
        {
        }
    }
}
