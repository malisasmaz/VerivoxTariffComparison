using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VerivoxTariffComparison.Model;

namespace VerivoxTariffComparison.Services {
    public interface IElectricityService {
        List<Tariff> GetAll(int consumption);
    }
}
