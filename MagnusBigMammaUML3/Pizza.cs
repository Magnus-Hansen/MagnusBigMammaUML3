using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagnusBigMammaUML3
{
    public class Pizza : MenuItem
    {
        public bool DeepPan { get; set; }
        public Pizza(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool deepPan) : base(number, name, description, price, type, isVegan, isOrganic)
        {
            DeepPan = deepPan;
        }
        public override string PrintInfo()
        {
            return $"{base.PrintInfo()} - Deepan: {DeepPan}";
        }
    }
}
