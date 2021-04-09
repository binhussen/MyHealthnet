using BusinessLogic.IService;
using BusinessLogic.Service;
using DAL.IService;
using DAL.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace SQ.Senior.Quoting.External.Services
{
    public static class ServicesCollectionExtension
    {
        public static IServiceCollection AddInfrastructurServices(this IServiceCollection services)
        {
            services.AddScoped<IHomeService, HomeService>();
            services.AddScoped<IAdminService, AdminService>();

            //DalServices
            services.AddScoped<IAdminDALService, AdminDALService>();

            return services;
        }
        public static IServiceCollection AddHttpContext(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            return services;
        }

        //public static IServiceCollection AddCustomDbContext(this IServiceCollection services, IConfiguration configuration)
        //{
        //    services.AddDbContextPool<ApplicationDbContext>(item => item.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        //    return services;
        //}

        //public static IServiceCollection AddApiClient(this IServiceCollection services, IConfiguration configuration)
        //{
        //    services.AddHttpClient<IHTTPClientHelper, HTTPClientWrapper>(client =>
        //    {
        //        client.BaseAddress = new Uri(configuration.GetValue<string>("ConfigurationSettings:ApiUrl"));
        //    });
        //    return services;
        //}

        //public static IServiceCollection AddDRXAuthentication(this IServiceCollection services, IConfiguration configuration) {
        //    services.AddHttpClient<IAuthentication, Authentication>(client => {
        //        client.BaseAddress = new Uri(configuration.GetValue<string>("SelectQuoteSettings:DRXSettings:LinkAuthentication"));
        //    }).AddTransientHttpErrorPolicy(policy => policy.WaitAndRetryAsync(2, _ => TimeSpan.FromSeconds(2)));
        //    return services;
        //}


        //public static IServiceCollection AddQrsApiClient(this IServiceCollection services, IConfiguration configuration) {
        //    services.AddHttpClient("QrsApiClient", client => {
        //        client.BaseAddress = new Uri(configuration.GetValue<string>("SelectQuoteSettings:QrsSettings:BaseUri"));
        //        client.DefaultRequestHeaders.Add("x-api-key", configuration.GetValue<string>("SelectQuoteSettings:QrsSettings:QRSAPIKey"));
        //    });
        //    return services;
        //}
    }
}
