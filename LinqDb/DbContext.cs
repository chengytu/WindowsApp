using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using BusModels;
using System.Data.Entity.Infrastructure.Interception;
using System.Reflection;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Linq;

namespace DataFactory
{
    public partial class WSDContext : DbContext
    {
        static WSDContext()
        {
            Database.SetInitializer<WSDContext>(null);
#if DEBUG
           DbInterception.Add(new EFIntercepterLogging());
#endif
        }

        public WSDContext()
            : base("Name=DbContext")
        {
        }
        /// <summary>
        /// Get DbSet
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        /// <returns>DbSet</returns>
        public new DbSet<TEntity> Set<TEntity>() where TEntity : BaseModel
        {
            return base.Set<TEntity>();
        }

       

















        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
           .Where(type => !String.IsNullOrEmpty(type.Namespace))
           .Where(type => type.BaseType != null && type.BaseType.IsGenericType &&
               type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }
            //...or do it manually below. For example,
            //modelBuilder.Configurations.Add(new LanguageMap());



            base.OnModelCreating(modelBuilder);
            //modelBuilder.Configurations.Add(new RBACMENUPRIVILEGEMap());
            //modelBuilder.Configurations.Add(new RBACROLEMap());
            //modelBuilder.Configurations.Add(new RBACROLEMENUMap());
            //modelBuilder.Configurations.Add(new RBACROLEMENUFUNMap());
            //modelBuilder.Configurations.Add(new RBACROLEMENUPRIVILEGEMap());
            //modelBuilder.Configurations.Add(new RBACROLEUSERMap());
           
            //modelBuilder.Configurations.Add(new SYSBUTTONMap());
            //modelBuilder.Configurations.Add(new SysDeptMap());
            //modelBuilder.Configurations.Add(new SysDictMap());
            //modelBuilder.Configurations.Add(new SysDictCodeMap());
            //modelBuilder.Configurations.Add(new SYSFIELDMap());
            //modelBuilder.Configurations.Add(new SysFileMap());
            //modelBuilder.Configurations.Add(new SYSMENUMap());
            //modelBuilder.Configurations.Add(new SYSTABMap());
            //modelBuilder.Configurations.Add(new SYSTREEMap());
            //modelBuilder.Configurations.Add(new SysUserMap());
        

            //modelBuilder.Configurations.Add(new UserInfoExtensionMap());

          
            //modelBuilder.Configurations.Add(new SysDeptExtMap());







        }



    }
}
