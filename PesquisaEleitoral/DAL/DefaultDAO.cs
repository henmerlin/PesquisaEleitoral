using PesquisaEleitoral.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PesquisaEleitoral.DAL
{
    public class DefaultDAO
    {
        protected static ApplicationDbContext ctx = SingletonContext.Instance.Context;
    }
}