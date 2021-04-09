using System;
using System.Linq;
using System.Threading.Tasks;
using DAL.Context;
using DAL.IService;
using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace DAL.Service
{
    public class AdminDALService : IAdminDALService
    {
        ApplicationDbContext _context;

        public AdminDALService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Content> GetContent()
        {
            try
            {
                var client = await _context.Content.FirstOrDefaultAsync();
                return client;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
