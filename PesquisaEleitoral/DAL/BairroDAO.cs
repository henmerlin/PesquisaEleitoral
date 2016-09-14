using PesquisaEleitoral.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PesquisaEleitoral.DAL
{
    public class BairroDAO : DefaultDAO
    {

        public static bool AdicionarBairro(Models.Bairro b)
        {
            try
            {
                ctx.Bairros.Add(b);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Models.Bairro VerificarBairroPorNome(Models.Bairro b)
        {
            return ctx.Bairros.FirstOrDefault(x => x.Nome.Equals(b.Nome));
        }

        public static Models.Bairro VerificarBairroPorId(Models.Bairro b)
        {
            return ctx.Bairros.FirstOrDefault(x => x.Id == b.Id);
        }
    }

}