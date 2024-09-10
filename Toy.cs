using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Toy : Product
    {
        
        public decimal BasePrice { get; private set; }
        public string Material { get; private set; }

        public override string Name { get; } = "ret";

        public Toy( decimal price, string material, string customName = null)
        {
            BasePrice = price;
            Material = material;
            if (!string.IsNullOrEmpty(customName))
            {
                Name = customName;
            }
        }

        public override decimal Price => BasePrice;

        public override string GetInformation()
        {
            decimal discountedPrice = Price * 0.8m;
            return $"Название: {Name}, Материал: {Material}, Цена: {Price:C2}, Со скидкой: {discountedPrice:C2}";
        }
    }
}
