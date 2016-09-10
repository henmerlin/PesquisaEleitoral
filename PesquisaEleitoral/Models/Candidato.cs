using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PesquisaEleitoral.Models
{
    [Table("Candidatos")]
    public partial class Candidato
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(450)]
        [Index(IsUnique = true)]
        public string Nome { get; set; }

        [Required]
        [Index(IsUnique = true)]
        public int Numero { get; set; }



    }
}