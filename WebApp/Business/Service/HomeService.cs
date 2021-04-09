using BusinessLogic.IService;
using Model.Models;

namespace BusinessLogic.Service
{
    public class HomeService : IHomeService
    {
        //private readonly IHomeDALService _homeDalService;

        //public HomeService()
        //{

        //}

        #region Home
        public WeatherForecast CallApiMethodAsync()
        {
            //string url = "https://localhost:44306/weatherforecast";
            //var result = await _httpClient.GetAsync<WeatherForecast>(url);
            //return result;
            return null;
        }
        #endregion 
    }
}
