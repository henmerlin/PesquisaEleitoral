using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PesquisaEleitoral.Models
{
    public class SingletonContext
    {
        private static readonly SingletonContext instance = new SingletonContext();

        private readonly Context context;

        private SingletonContext()
        {
            context = new Context();
        }

        public static SingletonContext Instance
        {
            get
            {
                return instance;
            }
        }

        public Context Context
        {
            get
            {
                return context;
            }
        }
    }
}