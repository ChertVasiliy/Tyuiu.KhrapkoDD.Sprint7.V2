using System;
using System.Collections.Generic;
using Tyuiu.KhrapkoDD.Sprint7.Lib.Model;
using Tyuiu.KhrapkoDD.Sprint7.Lib.Models;
using Tyuiu.KhrapkoDD.Sprint7.Lib.Services;
using Xunit;

namespace Tyuiu.KhrapkoDD.Sprint7.Tests
{
    public class PersonalComputerTests_KhrapkoDD
    {
        [Fact]
        public void AgeYears_When2025_ShouldReturnCorrect()
        {
            var pc = new PersonalComputer_KhrapkoDD
            {
                ReleaseDate = new DateTime(2020, 6, 1)
            };
            Assert.Equal(5, pc.AgeYears);
        }

        [Fact]
        public void StatisticsService_Count_And_Avg()
        {
            var srv = new StatisticsService_KhrapkoDD();
            var pcs = new List<PersonalComputer_KhrapkoDD>
            {
                new() { CpuFrequencyMHz = 3000 },
                new() { CpuFrequencyMHz = 5000 }
            };

            Assert.Equal(2, srv.Count(pcs));
            Assert.Equal(4000.0, srv.AvgFrequency(pcs));
        }
    }
}
