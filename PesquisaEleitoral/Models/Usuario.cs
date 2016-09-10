using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PesquisaEleitoral.Models
{
    [Table("Usuarios")]
    public partial class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(150)]
        [Index(IsUnique = true)]
        [Required]
        public string Email { get; set; }

        [Required, Column(TypeName = "Date"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        public int BairroId { get; set; }
        [ForeignKey("Id")]
        public Bairro Bairro { get; set; }


        public int Voto { get; set; }
        [ForeignKey("Id")]
        public Candidato CandVoto { get; set; }

    }
}