using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VerivoxTariffComparison.Model {
    public class Basic : IProduct {

        //Calculation model: base costs per month 5 € + consumption costs 22 cent/kWh
        public double CalculateTariff(int consumption) {
            int baseCost = 5;
            double consumptionCost = 0.22;
            return baseCost * 12 + consumption * consumptionCost;
        }

        public string GetName() {
            return "basic electricity tariff";
        }
    }
}
