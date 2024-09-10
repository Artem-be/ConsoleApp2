using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Meat : Product
    {
        public override string Name { get; } = "Мясо";
        public decimal BasePrice { get; private set; }
        public string Type { get; private set; }

        public Meat(decimal price, string type, string customName = null)
        {
            BasePrice = price;
            Type = type;
            if (!string.IsNullOrEmpty(customName))
            {
                Name = customName;
            }
        }

        public override decimal Price => BasePrice;

        public override string GetInformation()
        {
            decimal discountedPrice = Price * 0.8m;
            return $"Название: {Name}, Тип: {Type}, Цена: {Price:C}, Со скидкой: {discountedPrice:C2}";
        }
    }
}
