using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overmind.DAL
{
    public class Context : DbContext
    {
        public Context()
            : base("name=OvermindConnection")
        {
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = false;
            this.Database.CreateIfNotExists();
        }
    }
}
