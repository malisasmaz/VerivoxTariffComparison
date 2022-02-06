using VerivoxTariffComparison.Interfaces;

namespace VerivoxTariffComparison.Models {
    /// <summary>
    /// Packaged Electricity Product
    /// </summary>
    public class Packaged : IProduct {
        /// <summary>
        /// Calculate Tariff
        /// </summary>
        /// <param name="consumption"></param>
        /// <returns></returns>
        //Calculation model: 800 € for up to 4000 kWh/year and above 4000 kWh/year additionally 30 cent/kWh
        public double CalculateTariff(int consumption) {
            int limit = 4000;
            double ConsumptionCost = 0.30;
            return consumption <= limit ? 800.00 : 800.00 + (consumption - limit) * ConsumptionCost;
        }

        /// <summary>
        /// Get Name 
        /// </summary>
        /// <returns></returns>
        public string GetName() {
            return "Packaged tariff";
        }
    }
}
