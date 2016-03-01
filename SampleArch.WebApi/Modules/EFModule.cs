using System.Data.Entity;
using Autofac;
using SampleArch.Model;
using SampleArch.Repository.Common;

namespace SampleArch.WebApi.Modules
{

    /// <summary>
    /// EfModule
    /// </summary>
    /// <seealso cref="Autofac.Module" />
    public class EfModule : Autofac.Module
    {
        /// <summary>
        /// Override to add registrations to the container.
        /// </summary>
        /// <param name="builder">The builder through which components can be
        /// registered.</param>
        /// <remarks>
        /// Note that the ContainerBuilder parameter is unique to this module.
        /// </remarks>
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new RepositoryModule());
            builder.RegisterType(typeof(SampleArchContext)).As(typeof(DbContext)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).InstancePerRequest();     
        }
    }
}