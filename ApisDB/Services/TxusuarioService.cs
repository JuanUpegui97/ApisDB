using ApisDB.Data;
using ApisDB.Models;
using Microsoft.EntityFrameworkCore;


namespace ApisDB.Services
{
    public class TxusuarioService
    {
        private readonly AppDbContext _context;
        public TxusuarioService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Txusuario>> GetAllTxusuarios()
        {
            return await _context.Txusuarios.ToListAsync();
        }
    }
}
