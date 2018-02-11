using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCodeFirstDemo.Entity.DO;

namespace EFCodeFirstDemo.Data
{
    public partial class EFCodeFirstDemoDBContext: DbContext
    {
        public EFCodeFirstDemoDBContext()
            : base("name=EFCodeFirstDemoDB")
        {
        }

        public virtual DbSet<TFltAskOrders> TFltAskOrders { get; set; }
        public virtual DbSet<TFltOrders> TFltOrders { get; set; }
    }
}
