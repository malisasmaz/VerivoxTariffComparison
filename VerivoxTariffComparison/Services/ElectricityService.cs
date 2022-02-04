using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VerivoxTariffComparison.Model;

namespace VerivoxTariffComparison.Services {
    public class ElectricityService : IElectricityService {
        public List<Tariff> GetAll(int consumption) {

            List<Tariff> unorderedList = new List<Tariff>();
            double baseCost = 0.00;
            double consumptionCost = 0.00;

            //ProductA A
            Tariff productA = new Tariff { TariffName = "basic electricity tariff" };
            baseCost = 5;//Euro
            consumptionCost = 0.22;//22 Cent
            productA.AnnualCosts = baseCost * 12 + consumption * consumptionCost;
            unorderedList.Add(productA);

            //Product B
            Tariff productB = new Tariff { TariffName = "Packaged tariff" };
            int limit = 4000;

            if (consumption <= limit) {
                productB.AnnualCosts = 800.00;
            }
            else {
                consumptionCost = 0.30;
                productB.AnnualCosts = 800.00 + (consumption - limit) * consumptionCost;
            }
            unorderedList.Add(productB);

            //sorted by costs in ascending order.
            var result = unorderedList.OrderBy(x => x.AnnualCosts)?.ToList();

            return result;
        }
    }
}
