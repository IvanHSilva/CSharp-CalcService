using System;
using System.Collections.Generic;

namespace CalcService.Services {
    public class CalculationService {

        public int Max(List<int> list) {
            if (list.Count == 0) throw new ArgumentException("Lista Vazia!");

            int max = list[0];
            for (int i = 1; i < list.Count; i++) {
                if (list[i] > max) {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
