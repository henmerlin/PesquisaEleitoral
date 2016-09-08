using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PesquisaEleitoral.Models
{
    public partial class Bairro
    {
        [Key]
        int Id { get; set; }

        [Required]
        string Nome { get; set; }

    }
}