using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.IService
{
    public interface IHomeService
    {
        WeatherForecast CallApiMethodAsync();
    }
}
