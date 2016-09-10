using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PesquisaEleitoral.Models
{
    public class SingletonContext
    {
        private static readonly SingletonContext instance = new SingletonContext();

        private readonly ApplicationDbContext context;

        private SingletonContext()
        {
            context = new ApplicationDbContext();
        }

        public static SingletonContext Instance
        {
            get
            {
                return instance;
            }
        }

        public ApplicationDbContext Context
        {
            get
            {
                return context;
            }
        }
    }
}