using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OPTATIVOIII3ERPARCIAL.Models;
using System.Linq;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System;

namespace OPTATIVOIII3ERPARCIAL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        // POST: api/Auth/GetToken
        [HttpPost("GetToken")]
        public async Task<ActionResult<string>> GetToken(LoginModel login)
        {
            var user = await _context.Usuarios.Include(u => u.Persona).FirstOrDefaultAsync(u => u.NOMBREUSUARIO == login.Username && u.CONTRASEÑA == login.Password);

            if (user == null)
            {
                return Unauthorized();
            }

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.NOMBREUSUARIO),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.IDUSUARIO.ToString()),
                new Claim("Nombre", user.Persona.Nombre),
                new Claim("Apellido", user.Persona.Apellido),
                new Claim("Email", user.Persona.Email)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("your_secret_key_here"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken("your_token_issuer", "your_token_audience", claims, expires: DateTime.Now.AddMinutes(30), signingCredentials: creds);

            return Ok(new JwtSecurityTokenHandler().WriteToken(token));
        }
    }

    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

}

