using System.Collections.Generic;
using VerivoxTariffComparison.Entities;

namespace VerivoxTariffComparison.Interfaces {
    /// <summary>
    /// Electricity Service
    /// </summary>
    public interface IElectricityService {
        /// <summary>
        /// Get Electricity Tariffs
        /// </summary>
        /// <param name="consumption"></param>
        /// <returns></returns>
        List<Tariff> GetTariffs(int consumption);
    }
}
