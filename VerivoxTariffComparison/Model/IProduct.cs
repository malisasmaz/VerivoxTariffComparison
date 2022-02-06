using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VerivoxTariffComparison.Model {
    public interface IProduct {
        /// <summary>
        /// Product Name
        /// </summary>
        /// <returns></returns>
        string GetName();

        /// <summary>
        /// Calculate Product annual cost 
        /// </summary>
        /// <param name="consumption">required consumption amount</param>
        /// <returns></returns>
        double CalculateTariff(int consumption);
    }
}
