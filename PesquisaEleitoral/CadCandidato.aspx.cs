using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PesquisaEleitoral.Models;

namespace PesquisaEleitoral
{
    public partial class CadCandidato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Cadastrar(object sender, EventArgs e)
        {

            Models.Bairro b = new Models.Bairro();
            b.Nome = txtNome.Text;

            txtNome.Text = "oi";


        }


    }
}