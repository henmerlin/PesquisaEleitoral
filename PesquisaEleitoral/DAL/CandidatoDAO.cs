using PesquisaEleitoral.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PesquisaEleitoral.DAL
{
    public class CandidatoDAO
    {
        private static Context ctx = SingletonContext.Instance.Context;

        public static bool AdicionarCandidato(Models.Candidato c)
        {
            try
            {
                ctx.Candidatos.Add(c);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }

}