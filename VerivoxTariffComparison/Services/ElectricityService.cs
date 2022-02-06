using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VerivoxTariffComparison.Model;

namespace VerivoxTariffComparison.Services {
    public class ElectricityService : IElectricityService {
        public List<Tariff> GetAll(int consumption) {

            List<Tariff> unorderedList = new List<Tariff>() {
                new Tariff(new Basic(), consumption),
                new Tariff(new Packaged(), consumption)
            };

            //sorted by costs in ascending order.
            var result = unorderedList.OrderBy(x => x.AnnualCosts)?.ToList();

            return result;
        }
    }
}
