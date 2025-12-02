using ApisDB.Data;
using ApisDB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApisDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Timovimientoencabs : ControllerBase
    {
        private readonly AppDbContext _context;

        public Timovimientoencabs(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult> GetTimovimientoencabs()
        {
            // Consultamos la tabla generada automáticamente
            var datos = await _context.Timovimientoencabs
                                      .Take(10) // Traemos solo 10 para probar
                                      .ToListAsync();
            return Ok(datos);
        }
<<<<<<< HEAD

=======
>>>>>>> b3600821eece5eadadb88f7a3b03b5ea4ddad402
    }
}
