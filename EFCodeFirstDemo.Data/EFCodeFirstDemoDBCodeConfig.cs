using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo.Data
{
    public class EFCodeFirstDemoDBCodeConfig : DbConfiguration
    {
        public EFCodeFirstDemoDBCodeConfig()
        {
            //Configuring the Default Connection Factory
            this.SetDefaultConnectionFactory(new SqlConnectionFactory());

            //Setting Database Provider
            this.SetProviderServices("System.Data.SqlClient", SqlProviderServices.Instance);

            //Setting Database Initializers
            this.SetDatabaseInitializer<EFCodeFirstDemoDBContext>(null);
        }
    }
}
