using Microsoft.IdentityModel.Tokens; // Para criptografía
using System.IdentityModel.Tokens.Jwt; // Para crear el Token
using System.Security.Claims; // Para los datos del usuario
using System.Text; // Para Encoding
using ApisDB.Data;
using ApisDB.Models;
using Microsoft.EntityFrameworkCore;




namespace ApisDB.Services
{
    public class AuthService
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;

        public AuthService(AppDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<string?> Login(LoginDto loginDto)
        {
            string nombRole = "Estandar";
            var user = await _context.Txusuarios
                                     .FirstOrDefaultAsync(u => u.UxCod == loginDto.Username && u.UxClaveAut == loginDto.Password);
            if (user == null)
            {
                return null; 
            }

            switch (user.UxPerfilUsu)
            {
                case "1":
                    nombRole = "Administrador"; 
                    break;
                case "2":
                    nombRole = "Consulta";
                    break;
                case "5":
                    nombRole = "Usuario";
                    break;
                default:
                    nombRole = "Estandar";
                    break;
            }

            // llenamos el formulario con el usuario y el rol
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.UxCod.ToString()),
                new Claim(ClaimTypes.Role, nombRole) 
            };


            // Generar la clave secreta
            var key = _configuration["Jwt:Key"]!;
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            // Crear el token
            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
