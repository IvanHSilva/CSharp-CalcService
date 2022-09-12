using System;
using System.Globalization;

namespace CalcService.Entities {
    public class Product : IComparable {
        // Attributes
        public string Name { get; set; }
        public double Price { get; set; }

        // Constructor
        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        // Methods
        public override string ToString() {
            return $"{Name}, ${Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object obj) {
            if (!(obj is Product)) throw new ArgumentException("Impossível comparar, objeto não é produto!");
            Product other = (Product)obj;
            return Price.CompareTo(other.Price);
        }
    }
}
