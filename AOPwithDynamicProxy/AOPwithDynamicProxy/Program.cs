// See https://aka.ms/new-console-template for more information
using AOPwithDynamicProxy.Aspects;
using AOPwithDynamicProxy.Services;
using Autofac;
using Autofac.Extras.DynamicProxy;

var container = BuildContainer();
using var scope = container.BeginLifetimeScope();
var writer = scope.Resolve<IWriter>();
writer.Write("witer nesnesi: Deneme");

static IContainer BuildContainer()
{
    var builder = new ContainerBuilder();
    builder.RegisterType<Logging>();

    builder.RegisterType<ConsoleWriter>()
        .As<IWriter>()
        .EnableInterfaceInterceptors()
        .InterceptedBy(typeof(Logging));

    return builder.Build();

}