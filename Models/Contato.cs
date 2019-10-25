using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace lojaVirtual.Models
{
    public class Contato
    {

        //TODO - Criar arquivo de traducao de recurso mensagens ==> Libraries/Lang/Mensagem.resx


        [Required(ErrorMessage = "O campo Nome nao pode estar em branco")]
        [MinLength(4, ErrorMessage = "O campo Nome deve ter pelo menos 4 caracteres")]
        public string Nome { get; set;}

        [Required(ErrorMessage = "O campo Email e obrigatorio")]
        [EmailAddress(ErrorMessage = "O campo Email e invalido")]
        public string Email { get; set;}

        [Required(ErrorMessage = "O campo Texto e obrigatorio")]
        [MinLength(10, ErrorMessage = "O campo Texto deve ter pelo menos 10 caracteres")]
        [MaxLength(500, ErrorMessage = "O campo Texto deve ter no maximo 500 caracteres")]
        public string Texto { get; set;}
    }
}