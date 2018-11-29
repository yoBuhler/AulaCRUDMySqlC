using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatabaseC.Models
{
    public class Turma
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Código")]
        public string Codigo { get; set; }

        public virtual ICollection<Aluno> alunos { get; set; }
    }
}