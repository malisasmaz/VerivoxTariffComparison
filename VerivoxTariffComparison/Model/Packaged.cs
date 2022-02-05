using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VerivoxTariffComparison.Model {
    public class Packaged : IProduct {

        //Calculation model: 800 € for up to 4000 kWh/year and above 4000 kWh/year additionally 30 cent/kWh
        public double CalculateTariff(int consumption) {
            int limit = 4000;
            double ConsumptionCost = 0.30;
            return consumption <= limit ? 800.00 : 800.00 + (consumption - limit) * ConsumptionCost;
        }

        public string GetName() {
            return "Packaged tariff";
        }
    }
}
