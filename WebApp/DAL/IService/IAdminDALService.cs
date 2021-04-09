using System.Threading.Tasks;
using Model.Models;

namespace DAL.IService
{
    public interface IAdminDALService
    {
        Task<Content> GetContent();
    }
}
