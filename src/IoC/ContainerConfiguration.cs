using Autofac;
using Business;
using Data;
using System.Linq;
using System.Reflection;

namespace IoC
{
    public static class ContainerConfiguration
    {
        public static void Configure(ContainerBuilder builder)
        {
            var businessAssembly = Assembly.GetAssembly(typeof(SampleBusiness));
            var dataAssembly = Assembly.GetAssembly(typeof(SampleData));

            Register(builder, businessAssembly!);
            Register(builder, dataAssembly!);
        }

        private static void Register(ContainerBuilder builder, Assembly assembly)
        {
            builder.RegisterAssemblyTypes(assembly)
                .Where(a =>
                    a.IsClass &&
                    !a.IsAbstract)
                .As(a =>
                    a.GetInterfaces()
                    .Where(i =>
                        i.IsInterface &&
                        i.Name == $"I{a.Name}"))
                .InstancePerLifetimeScope();
        }
    }
}
