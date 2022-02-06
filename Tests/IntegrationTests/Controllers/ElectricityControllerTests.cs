using Xunit;
using FluentAssertions;
using VerivoxTariffComparison.Services;
using System.Linq;
using System.Collections.Generic;
using VerivoxTariffComparison.Controllers;
using VerivoxTariffComparison.Interfaces;
using VerivoxTariffComparison.Entities;

namespace UnitTests.IntegrationTests {
    public class ElectricityControllerTests {
        private readonly IElectricityService _service;
        private readonly ElectricityController _controller;

        public ElectricityControllerTests() {
            _service = new ElectricityService();
            _controller = new ElectricityController(_service);
        }

        [Fact]
        public void GetTariffs_WithZeroParam_ShouldReturnStatusCode400() {
            var response = _controller.GetTariffs(0);
            ((Microsoft.AspNetCore.Mvc.StatusCodeResult)response).StatusCode.Should().Be(400);
        }
                
        [Fact]
        public void GetTariffs_ParamGreaterThanZero_ShouldReturn200() {
            var response = _controller.GetTariffs(2000);
            ((Microsoft.AspNetCore.Mvc.JsonResult)response).StatusCode.Should().Be(200);
        }

        [Fact]
        public void GetTariffs_ShouldReturn_TwoElements() {
            var response = _controller.GetTariffs(3500);
            var data = ((Microsoft.AspNetCore.Mvc.JsonResult)response).Value.As<List<Tariff>>();
            data.Should().HaveCount(2);
        }

        [Theory]
        [InlineData(3500, "Packaged tariff", 800)]
        [InlineData(4500, "Packaged tariff", 950)]
        [InlineData(6000, "basic electricity tariff", 1380)]
        public void GetTariffs_ShouldReturn_MinimumAnnualCostTariff_InTheFirstElement(int consumption, string expectedTariffName, double expectedMinAnnualCost) {
            var response = _controller.GetTariffs(consumption);
            var data = ((Microsoft.AspNetCore.Mvc.JsonResult)response).Value.As<List<Tariff>>();
            data.FirstOrDefault().TariffName.Should().Be(expectedTariffName);
            data.FirstOrDefault().AnnualCost.Should().Be(expectedMinAnnualCost);
        }

    }
}
