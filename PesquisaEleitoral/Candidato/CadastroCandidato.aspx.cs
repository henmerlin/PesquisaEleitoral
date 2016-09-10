using PesquisaEleitoral.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PesquisaEleitoral.Candidato
{
    public partial class CadastroCandidato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Cadastrar(object sender, EventArgs e)
        {

            try
            {
                Models.Candidato c = new Models.Candidato();
                c.Nome = txtNome.Text;
               // c.Numero = Int32.Parse(txtNumero.Text);


                if (CandidatoDAO.AdicionarCandidato(c))
                {

                    Response.Redirect("/Candidato/CadastroSuccess");
                }
                else
                {
                    Response.Redirect("/Candidato/CadastroError");
                }

            }
            catch (Exception)
            {
                Response.Redirect("/Candidato/CadastroError");
            }
        }
    }
}