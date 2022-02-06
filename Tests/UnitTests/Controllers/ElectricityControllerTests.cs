using Xunit;
using FluentAssertions;
using System.Linq;
using System.Collections.Generic;
using VerivoxTariffComparison.Controllers;
using Moq;
using VerivoxTariffComparison.Interfaces;
using VerivoxTariffComparison.Entities;
using VerivoxTariffComparison.Models;

namespace Tests.UnitTests.Controllers {
    public class ElectricityControllerTests {
        private readonly Mock<IElectricityService> _mockElectricityService;

        public ElectricityControllerTests() {
            _mockElectricityService = new Mock<IElectricityService>();
        }
                        
        [Fact]
        public void GetAll_ShouldReturn_MockedTariff() {
            _mockElectricityService.Setup(t => t.GetTariffs(It.IsAny<int>())).Returns(new List<Tariff> { new Tariff(new Basic(), 3500) });

            var controller = new ElectricityController(_mockElectricityService.Object);
            var response = controller.GetTariffs(3500);

            var data = ((Microsoft.AspNetCore.Mvc.JsonResult)response).Value.As<List<Tariff>>();
            data.Should().HaveCount(1);
            data.FirstOrDefault().TariffName.Should().Be("basic electricity tariff");
            data.FirstOrDefault().AnnualCost.Should().Be(830);
        }
    }
}
