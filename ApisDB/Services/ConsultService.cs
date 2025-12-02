using Microsoft.EntityFrameworkCore;
using ApisDB.Data;
using ApisDB.Models;


namespace ApisDB.Services
{
    public class ConsultService
    {
        private readonly AppDbContext _context;

        public ConsultService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<VistaPrueba>> GetViewTest(string id)
        {
            return await _context.VistaPruebas
                                 .Where(v => v.Tipo  == id)
                                 .Take(10)
                                 .ToListAsync();
        }

    }
}
