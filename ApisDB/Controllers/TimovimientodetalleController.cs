using ApisDB.Data;
using ApisDB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApisDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimovimientodetalleController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TimovimientodetalleController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetTimovimientodetalle()
        {
            // Consultamos la tabla generada automáticamente
            var datos = await _context.Timovimientodetalles
                                      .Take(10) // Traemos solo 10 para probar
                                      .ToListAsync();
            return Ok(datos);
        }
    }
}
