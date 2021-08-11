using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZooUni.Controllers.Api;
using ZooUni.Test.Mocks;

namespace ZooUni.Test.Controllers.Api
{
    public class ApiControllerTest
    {
        [Fact]
        public void GetStatistics()
        {
            // Arrange
            var statisticsController = new StatisticsApiController(StatisticsServiceMock.Instance);
            // Act
            var result = statisticsController.GetAnimals();
            //Assert
            Assert.NotNull(result);
            Assert.Equal(10, result.TotalAnimals);
            Assert.Equal(2, result.TotalUsers);
        }

    }
}
