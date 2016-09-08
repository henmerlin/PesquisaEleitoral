using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PesquisaEleitoral.Models
{
    public class Candidato
    {

        int Numero { get; set; }

        [Required]
        string Nome { get; set; }


    }
}