using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Drink : Product
    {
       
        public decimal BasePrice { get; private set; }

        public override string Name { get; } = "Напиток";
        public string Volume { get; private set; }

        public Drink(decimal price, string volume, string customName = null)
        {
            BasePrice = price;
            Volume = volume;
            if (!string.IsNullOrEmpty(customName))
            {
                Name = customName;
            }
        }

        public override decimal Price => BasePrice;

        public override string GetInformation()
        {
            decimal discountedPrice = Price * 0.8m;
            return $"Название: {Name}, Объем: {Volume}, Цена: {Price:C}, Со скидкой: {discountedPrice:C2}";
        }
    }
}
