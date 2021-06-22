﻿using curso.api.Models.Usuario;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace curso.api.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase {
        [HttpPost]
        public IActionResult Logar(LoginViewModelInput loginViewModelInput) { //----> Criando ROTA 
            return Created("", loginViewModelInput);
        }
    }
}