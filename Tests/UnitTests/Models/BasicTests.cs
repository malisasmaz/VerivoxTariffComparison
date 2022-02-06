using FluentAssertions;
using VerivoxTariffComparison.Models;
using Xunit;

namespace Tests.UnitTests.Models {
    public class BasicTests {
        private readonly Basic _basic;

        public BasicTests() {
            _basic = new Basic();
        }

        [Theory]
        [InlineData("basic electricity tariff")]
        public void GetTariffName_ShouldReturn_ExpectedString(string expectedString) {
            _basic.GetName().Should().Be(expectedString);
        }

        [Theory]
        [InlineData(3500, 830)]
        [InlineData(4500, 1050)]
        [InlineData(6000, 1380)]
        public void CalculateTariff_ShouldReturn_ExpectedAnnualCost(int consumption, double expectedAnnualCost) {
            _basic.CalculateTariff(consumption).Should().Be(expectedAnnualCost);
        }
    }
}
