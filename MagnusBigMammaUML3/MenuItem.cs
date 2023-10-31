using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagnusBigMammaUML3
{
    public abstract class MenuItem : IMenuItem
    {
        public int Number { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public MenuType Type { get; set; }
        public bool IsVegan { get; set; }
        public bool IsOrganic { get; set; }

        public MenuItem(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic)
        {
            Number = number;
            Name = name;
            Description = description;
            Price = price;
            Type = type;
            IsVegan = isVegan;
            IsOrganic = isOrganic;
        }

        public virtual string PrintInfo()
        {
            return ToString();
        }
        public override string ToString()
        {
            return $"Number: {Number} - Name: {Name} - Descrption: {Description} - Price: {Price} - Type: {Type} - Vegan: {IsVegan} - Organic: {IsOrganic}";
        }
    }
}
