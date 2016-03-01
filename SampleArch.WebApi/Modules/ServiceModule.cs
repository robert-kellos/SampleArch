﻿using System.Reflection;
using Autofac;

namespace SampleArch.WebApi.Modules
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Autofac.Module" />
    public class ServiceModule : Autofac.Module
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

            builder.RegisterAssemblyTypes(Assembly.Load("SampleArch.Service"))

                      .Where(t => t.Name.EndsWith("Service"))

                      .AsImplementedInterfaces()

                      .InstancePerLifetimeScope();

        }

    }
}