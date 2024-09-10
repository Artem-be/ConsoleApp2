using System.Collections.Generic;

namespace ConsoleApp1
{
    internal abstract class Product
    {
        public abstract string Name { get; }
        public abstract decimal Price { get; }
        public abstract string GetInformation();
    }
}
