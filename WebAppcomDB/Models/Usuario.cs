using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppcomDB.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Apellido { get; set; }
        public DateTime Nacimiento { get; set; }
        public string ImagemUri { get; set; }
    }
}
