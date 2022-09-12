using CalcService.Entities;
using CalcService.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace CalcService {
    internal class Program {
        static void Main(string[] args) {

            List<Product> list = new List<Product>();

            Console.Write("Quantidade de itens: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.Write($"Produto {i}: ");
                string[] vect = Console.ReadLine().Split(',');
                list.Add(new Product(vect[0], double.Parse(vect[1], CultureInfo.InvariantCulture)));
            }

            CalculationService calc = new CalculationService();

            Product max = calc.Max(list);

            Console.WriteLine();
            Console.WriteLine($"Máximo: {max}");
            Console.WriteLine();
        }
    }
}
