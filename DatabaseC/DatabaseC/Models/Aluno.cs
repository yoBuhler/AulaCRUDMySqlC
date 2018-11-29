﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatabaseC.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual Turma Turma { get; set; }
    }
}