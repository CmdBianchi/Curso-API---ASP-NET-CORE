using curso.api.Models.Usuario;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace curso.api.Controllers {
    [Route("api/v1/usuario")] //----- > CONTROLLER é o nome do USUARIO
    [ApiController]
    public class UsuarioController : ControllerBase {
        [HttpPost]
        [Route("logar")]
        public IActionResult Logar(LoginViewModelInput loginViewModelInput) { //----> Criando ROTA 
            return Ok(loginViewModelInput);
        }

        [HttpPost]
        [Route("registrar")]
        public IActionResult Registar(RegistroViewModelInput loginViewModelInput) { //----> Criando ROTA 
            return Created("", loginViewModelInput);
        }
    }
}
