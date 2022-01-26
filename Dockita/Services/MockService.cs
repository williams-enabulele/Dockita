/*using JobHut.Application.Interfaces;
using JobHut.Domain.Entities;
using JobHut.Infrastructure.Shared.Mock;
using System.Collections.Generic;

namespace JobHut.Infrastructure.Shared.Services
{
    public class MockService : IMockService
    {
        public List<Position> GetPositions(int rowCount)
        {
            var positionFaker = new PositionInsertBogusConfig();
            return positionFaker.Generate(rowCount);
        }

        public List<Employee> GetEmployees(int rowCount)
        {
            var positionFaker = new DoctorSeedBogusConfig();
            return positionFaker.Generate(rowCount);
        }

        public List<Position> SeedPositions(int rowCount)
        {
            var seedPositionFaker = new BookingSeedBogusConfig();
            return seedPositionFaker.Generate(rowCount);
        }
    }
}*/