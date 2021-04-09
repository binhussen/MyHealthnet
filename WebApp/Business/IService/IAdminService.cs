using System.Threading.Tasks;
using Model.Models;

namespace BusinessLogic.IService
{
    public interface IAdminService
    {
        Task<string> TestMetohd();
        Task<Content> GetContent();

    }
}
