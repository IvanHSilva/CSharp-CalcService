using CalcService.Services;
using System;
using System.Collections.Generic;

namespace CalcService {
    internal class Program {
        static void Main(string[] args) {
            
            List<int> list = new List<int>();

            Console.Write("Quantidade de itens: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.Write($"Item {i}: ");
                int x = int.Parse(Console.ReadLine());
                list.Add(x);
            }

            CalculationService calc = new CalculationService();

            int max = calc.Max(list);

            Console.WriteLine();
            Console.WriteLine($"Máximo: {max}");
            Console.WriteLine();
        }
    }
}
