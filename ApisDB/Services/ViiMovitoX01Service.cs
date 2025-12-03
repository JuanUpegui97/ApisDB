using ApisDB.Data;
using ApisDB.Models;
using Microsoft.EntityFrameworkCore;



namespace ApisDB.Services
{
    public class ViiMovitoX01Service
    {
        private readonly AppDbContext _context;

        public ViiMovitoX01Service(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<ViiMovitoX01>> GetAllMovito()
        {
            return await _context.ViiMovitoX01s.ToListAsync();
        }
        public async Task<List<ViiMovitoX01>> GetMovitoByType(string type)
        {
            return await _context.ViiMovitoX01s
                                 .Where(v => v.Tipo == type)
                                 .ToListAsync();
        }
        public async Task<List<ViiMovitoX01>> GetDateToDate(decimal date1, decimal date2)
        {
            return await _context.ViiMovitoX01s
                                 .Where(v => v.Fecha >= date1 && v.Fecha <= date2)
                                 .ToListAsync();
        }
        public async Task<List<ViiMovitoX01>> GetDate(decimal date)
        {
            return await _context.ViiMovitoX01s
                                 .Where(v => v.Fecha == date)
                                 .ToListAsync();
        }
        public async Task<List<ViiMovitoX01>> GetMovitoByArtic(string artic)
        {
            return await _context.ViiMovitoX01s
                                 .Where(v => v.Articulo == artic)
                                 .ToListAsync();
        }
        public async Task<List<ViiMovitoX01>> GetMovitoByBod(string bod)
        {
            return await _context.ViiMovitoX01s
                                 .Where(v => v.Bodega1 == bod)
                                 .ToListAsync();
        }
        public async Task<List<ViiMovitoX01>> GetMovitoByClas(string clas)
        {
            return await _context.ViiMovitoX01s
                                 .Where(v => v.ClaseDocto == clas)
                                 .ToListAsync();
        }
        public async Task<List<ViiMovitoX01>> DynamySearch(string campo, string criterio)
        {
            var query = _context.ViiMovitoX01s.AsQueryable();

            switch (campo.ToUpper())
            {
                case "MV_TIPO":
                    query = query.Where(v => v.Tipo == criterio);
                    break;

                case "MV2_ARTIC":
                    query = query.Where(v => v.Articulo == criterio);
                    break;
                case "MV2_BODEGA1":
                    query = query.Where(v => v.Bodega1 == criterio);
                    break;
                case "MV_FCH":
                    if (decimal.TryParse(criterio, out decimal fechaValue))
                    {
                        query = query.Where(v => v.Fecha == fechaValue);
                    }
                    else
                    {
                        return new List<ViiMovitoX01>();
                    }
                    break;
                case "TA_CLASE":
                    query = query.Where(v => v.ClaseDocto == criterio);
                    break;

                default:
                    return new List<ViiMovitoX01>();
                    

            }

            return await query.ToListAsync();

        }
    }
}