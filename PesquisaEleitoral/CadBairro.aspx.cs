using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PesquisaEleitoral.Models;

namespace PesquisaEleitoral
{
    public partial class CadBairro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Cadastrar(object sender, EventArgs e)
        {

            HttpContext context = HttpContext.Current;

            Models.Bairro b = new Models.Bairro();
            b.Nome = txtNome.Text;

            txtNome.Text = "oi";


        }


    }
}