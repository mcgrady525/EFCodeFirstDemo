using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCodeFirstDemo.Entity.DO;
using System.Data.Entity.Infrastructure;

namespace EFCodeFirstDemo.Data
{
    public partial class EFCodeFirstDemoDBContext: DbContext
    {
        public EFCodeFirstDemoDBContext()
            : base("name=EFCodeFirstDemoDB")
        {
            //关闭数据库初始化器!!!(重要)
            Database.SetInitializer<EFCodeFirstDemoDBContext>(null);

            //关闭延迟加载
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
        }

        /// <summary>
        /// 关闭fluent API
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<TFltAskOrders> TFltAskOrders { get; set; }
        public virtual DbSet<TFltOrders> TFltOrders { get; set; }
    }
}
