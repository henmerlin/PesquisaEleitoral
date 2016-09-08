using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PesquisaEleitoral.Models
{
    public class Context : DbContext
    {
        public Context() : base("PesquisaEleitoral")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Bairro> Bairros { get; set; }
        public DbSet<Voto> Votos { get; set; }

    }
}