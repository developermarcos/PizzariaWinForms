using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Domain.Compartilhado
{
    public class Endereco
    {
        public string logradouro { get; set; }
        public string bairro { get; set; }
        public string numero { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }
        public string pais { get; set; }
        public string complemento { get; set; }
        
    }
}
