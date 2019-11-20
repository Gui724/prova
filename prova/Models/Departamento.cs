using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Models
{
    [Table("departamento")]
    public class Departamento
    {
        [Key]
        public int id_departamento { get; set; }

        public string nomeDepart { get; set; }

        public string cidade { get; set; }

        public int fg_ativo { get; set; }
    }
}
