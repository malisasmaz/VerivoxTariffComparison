using FluentAssertions;
using System;
using VerivoxTariffComparison.Models;
using Xunit;

namespace Tests.UnitTests.Models {
    public class PackagedTests {
        private readonly Packaged _basic;

        public PackagedTests() {
            _basic = new Packaged();
        }

        [Theory]
        [InlineData("Packaged tariff")]
        public void GetTariffName_ShouldReturn_ExpectedString(string expectedString) {
            _basic.GetName().Should().Be(expectedString);
        }

        [Theory]
        [InlineData(3500, 800)]
        [InlineData(4500, 950)]
        [InlineData(6000, 1400)]
        public void CalculateTariff_ShouldReturn_ExpectedAnnualCost(int consumption, double expectedAnnualCost) {
            _basic.CalculateTariff(consumption).Should().Be(expectedAnnualCost);
        }
    }
}
