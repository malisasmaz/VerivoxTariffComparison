
namespace VerivoxTariffComparison.Interfaces {
    /// <summary>
    /// Electricity Product
    /// </summary>
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
