using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace DAL.IService
{
    public interface IHomeDALService
    {        
        Task<WeatherForecast> CallApiMethodAsync();
    }
}
