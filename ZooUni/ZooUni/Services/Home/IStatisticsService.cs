using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooUni.Services.Home
{
    public interface IStatisticsService
    {
        StatisticsServiceModel GetAll();
    }
}
