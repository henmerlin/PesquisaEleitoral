﻿using PesquisaEleitoral.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PesquisaEleitoral.DAL
{
    public class UsuarioDAO : DefaultDAO
    {

        public static bool AlterarUsuario(ApplicationUser u)
        {
            try
            {
                ctx.Entry(u).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return true;
            }
        }

        public static ApplicationUser VerificarCandidatoPorNome(ApplicationUser u)
        {
            return ctx.Users.FirstOrDefault(x => x.UserName.Equals(u.UserName));
        }


    }
}