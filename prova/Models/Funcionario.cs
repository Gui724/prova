using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Models
{
    [Table("funcionario")]
    public class Funcionario
    {
        [Key]
        public int id_funcionario { get; set; }
        public int id_gerente { get; set; }
        [ForeignKey("departamento")]
        [Column("id_departamento")]
        public int id_departamento { get; set; }
        public DateTime dt_nascimento { get; set; }
        public double salariofunc { get; set; }
        public string cargofunc { get; set; }
        public int fg_ativo { get; set; }

        public virtual Departamento Departamento { get; set; }
    }
}
