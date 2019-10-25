using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Cliente
    {
        //ID - PK
        public int Id { get; set; }

        public string nomeCliente { get; set; }
        public string cpfCliente { get; set; }
        public string sexoCliente { get; set; }
        public string telCliente { get; set; }
        public DateTime dtNascCliente { get; set; }

        public string emailCliente { get; set; }
        public string senhaCliente { get; set; }

    }
}