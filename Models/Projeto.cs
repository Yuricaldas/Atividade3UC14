using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Exo.WebApi.Models
{
        public class Projeto
    {
        public int Id { get; set; }
        public string NomeDoProjeto {get; set; }
        public string Area { get; set; }
        public bool Status {get; set; } 
    }
}