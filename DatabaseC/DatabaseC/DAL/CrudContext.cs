using DatabaseC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DatabaseC.DAL
{
    public class CrudContext : DbContext // implemento essa porcaria
    {
        public CrudContext() : base("dbconn") // nome da conexão que criou lá na Web.config
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Turma> Turmas { get; set; }
    }
}