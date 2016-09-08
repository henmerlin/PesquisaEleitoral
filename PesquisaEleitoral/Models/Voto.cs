using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PesquisaEleitoral.Models
{
    public partial class Voto
    {

        [Key]
        int Id { get; set; }

        [Required]
        Candidato Candidato { get; set; }

        DateTime Data { get; set; }



    }
}