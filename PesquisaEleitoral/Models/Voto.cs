using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PesquisaEleitoral.Models
{
    [Table("Votos")]
    public partial class Voto
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public Candidato Candidato { get; set; }

        public DateTime Data { get; set; }



    }
}