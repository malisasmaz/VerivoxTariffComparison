using VerivoxTariffComparison.Interfaces;

namespace VerivoxTariffComparison.Models {
    /// <summary>
    /// Basic Electricity Product
    /// </summary>
    public class Basic : IProduct {
        /// <summary>
        /// Calculate Tariff
        /// </summary>
        /// <param name="consumption"></param>
        /// <returns></returns>
        //Calculation model: base costs per month 5 € + consumption costs 22 cent/kWh
        public double CalculateTariff(int consumption) {
            int baseCost = 5;
            double consumptionCost = 0.22;
            return baseCost * 12 + consumption * consumptionCost;
        }
        
        /// <summary>
        /// Get Name 
        /// </summary>
        /// <returns></returns>
        public string GetName() {
            return "basic electricity tariff";
        }
    }
}
