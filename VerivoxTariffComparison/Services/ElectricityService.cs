using System.Collections.Generic;
using System.Linq;
using VerivoxTariffComparison.Entities;
using VerivoxTariffComparison.Interfaces;
using VerivoxTariffComparison.Models;

namespace VerivoxTariffComparison.Services {
    /// <summary>
    /// Electricity Service
    /// </summary>
    public class ElectricityService : IElectricityService {
        /// <summary>
        /// Get Electricity Tariffs
        /// </summary>
        /// <param name="consumption"></param>
        /// <returns></returns>
        public List<Tariff> GetTariffs(int consumption) {

            List<Tariff> unorderedList = new List<Tariff>() {
                new Tariff(new Basic(), consumption),
                new Tariff(new Packaged(), consumption)
            };

            //sorted by costs in ascending order.
            var result = unorderedList.OrderBy(x => x.AnnualCost)?.ToList();

            return result;
        }
    }
}
