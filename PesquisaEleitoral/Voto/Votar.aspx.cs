using Microsoft.AspNet.Identity;
using PesquisaEleitoral.DAL;
using PesquisaEleitoral.Models;
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

        }

        protected void Cadastrar(object sender, EventArgs e)
        {

            ApplicationUser u = new ApplicationUser();
            u.UserName = System.Web.HttpContext.Current.User.Identity.GetUserName();
            u = UsuarioDAO.VerificarCandidatoPorNome(u);
            u.VotoId = Int32.Parse(ddpCandidatos.SelectedItem.Value);

            if (UsuarioDAO.AlterarUsuario(u))
            {
                Response.Redirect("/Voto/VotoSuccess");
            }
            else
            {
                Response.Redirect("/Bairro/VotoError");
            }

        }
        
    }
}