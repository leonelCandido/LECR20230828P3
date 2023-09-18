
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Authentication.Cookies;

using Microsoft.AspNetCore.Authentication;

using System.Security.Claims;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace LECRP3ACC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login(string login, string password)
        {

            if (login == "admin" && password == "12345")
            {

                var claims = new List<Claim> {

                    new Claim(ClaimTypes.Name, login),
                };



                var claimsIdentity = new ClaimsIdentity(claims,
                    CookieAuthenticationDefaults.AuthenticationScheme);



                var authProperties = new AuthenticationProperties
                {

                };


                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity), authProperties);


                return Ok("Inicio de sesión correctamente.");
            }
            else
            {

                return Unauthorized("Credenciales incorrectas");
            }
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {

            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);


            return Ok("Cerro sesión correctamente.");
        }
    }
 }
            