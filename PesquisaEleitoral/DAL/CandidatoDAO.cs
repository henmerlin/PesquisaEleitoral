using PesquisaEleitoral.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PesquisaEleitoral.DAL
{
    public class CandidatoDAO : DefaultDAO
    {

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

        public static Models.Candidato VerificarCandidatoPorNome(Models.Candidato c)
        {
            return ctx.Candidatos.FirstOrDefault(x => x.Nome.Equals(c.Nome));
        }

        public static Models.Candidato VerificarCandidatoPorNumero(Models.Candidato c)
        {
            return ctx.Candidatos.FirstOrDefault(x => x.Numero == c.Numero);
        }

        public static List<Models.Candidato> RetornarLista()
        {
            return ctx.Candidatos.ToList();
        }


    }

}