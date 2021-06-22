using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace curso.api.Models.Usuario {
    public class RegistroViewModelInput {
        [Required(ErrorMessage = "O login é obrigadorio")]
        public string Login { get; set; }
        [Required(ErrorMessage = "O Email é obrigadorio")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O Senha é obrigadorio")]
        public string Senha { get; set; }

    }
}
