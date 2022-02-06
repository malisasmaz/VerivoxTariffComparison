using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VerivoxTariffComparison.Model {
    public class Tariff {
        private readonly IProduct product;
        private readonly int consumption;

        public Tariff(IProduct product, int consumption) {
            this.product = product;
            this.consumption = consumption;
        }

        public string TariffName {
            get { return product.GetName(); }
        }

        public double AnnualCosts {
            get { return product.CalculateTariff(consumption); }
        }
    }
}
