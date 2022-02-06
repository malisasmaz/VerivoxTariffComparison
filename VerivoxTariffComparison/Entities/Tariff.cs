using VerivoxTariffComparison.Interfaces;

namespace VerivoxTariffComparison.Entities {
    /// <summary>
    /// Tariff
    /// </summary>
    public class Tariff {
        private readonly IProduct product;
        private readonly int consumption;

        /// <summary>
        /// Tariff Constructor
        /// </summary>
        /// <param name="product">product type</param>
        /// <param name="consumption">consumption kWh/year</param>
        public Tariff(IProduct product, int consumption) {
            this.product = product;
            this.consumption = consumption;
        }

        /// <summary>
        /// Tariff Name
        /// </summary>
        public string TariffName {
            get { return product.GetName(); }
        }

        /// <summary>
        /// Annual Cost
        /// </summary>
        public double AnnualCost {
            get { return product.CalculateTariff(consumption); }
        }
    }
}
