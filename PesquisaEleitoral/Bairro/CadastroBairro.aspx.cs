using PesquisaEleitoral.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PesquisaEleitoral.Bairro
{
    public partial class CadastroBairro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Cadastrar(object sender, EventArgs e)
        {

            Models.Bairro b = new Models.Bairro();
            b.Nome = txtNome.Text;

            Models.Bairro b1 = BairroDAO.VerificarBairroPorNome(b);

            if (b1 == null)
            {
                if (BairroDAO.AdicionarBairro(b))
                {
                    Response.Redirect("/Bairro/CadastroSuccess");
                }
                else
                {
                    Response.Redirect("/Bairro/CadastroError");
                }
            }
            else
            {
                Response.Redirect("/Bairro/CadastroExistente");
            }
        }
    }
}