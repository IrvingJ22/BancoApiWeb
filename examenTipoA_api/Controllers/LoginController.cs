using System;
using examenTipoA_api.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace examenTipoA_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public bool login([FromBody] DTO_Usuario user)
        {
            bool regreso = false;
            if (user != null)
            {
                if (user.Nombre_usuario == "Irving" && user.Contrasena_usuario == "123")
                    regreso = true;
                if (user.Nombre_usuario == "Ismael" && user.Contrasena_usuario == "123")
                    regreso = true;
            }
            return regreso;

        }
    }
}

