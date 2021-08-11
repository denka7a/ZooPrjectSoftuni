using Moq;
using ZooUni.Services.Home;

namespace ZooUni.Test.Mocks
{
    public static class StatisticsServiceMock
    {
        public static IStatisticsService Instance
        {
            get
            {
                var statisticsServiceMock = new Mock<IStatisticsService>();

                statisticsServiceMock
                    .Setup(s => s.GetAll())
                    .Returns(new StatisticsServiceModel
                    {
                        TotalAnimals = 10,
                        TotalUsers = 2
                    });

                return statisticsServiceMock.Object;
            }
        }
        
    }
}
