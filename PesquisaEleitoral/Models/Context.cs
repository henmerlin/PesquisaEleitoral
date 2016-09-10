using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PesquisaEleitoral.Models
{
    public class Context : DbContext
    {
        public Context() : base("ASP_PesquisaEleitoral")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Bairro> Bairros { get; set; }
        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}