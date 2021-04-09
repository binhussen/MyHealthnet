using System.Threading.Tasks;
using BusinessLogic.IService;
using DAL.IService;
using Model.Models;

namespace BusinessLogic.Service
{
    public class AdminService : IAdminService
    {
        private readonly IAdminDALService _adminService;
        public AdminService(IAdminDALService adminService)
        {
            _adminService = adminService;
        }
        public async Task<string> TestMetohd() {
            return null;
        }

        public async Task<Content> GetContent()
        {
            return await _adminService.GetContent();
        }
    }
}
