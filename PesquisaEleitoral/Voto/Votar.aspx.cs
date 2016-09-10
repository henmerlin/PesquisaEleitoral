using PesquisaEleitoral.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PesquisaEleitoral.Voto
{
    public partial class Votar : System.Web.UI.Page
    {

        public List<Models.Candidato> Candidatos { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Candidatos = CandidatoDAO.RetornarLista();
        }
    }
}