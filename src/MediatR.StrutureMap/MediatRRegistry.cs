using StructureMap;

namespace MediatR.StrutureMap
{
    public class MediatRRegistry : Registry
    {
        public MediatRRegistry()
        {
            Scan(scanner =>
            {
                scanner.AssemblyContainingType<IMediator>();
                scanner.WithDefaultConventions();
            });

            For<SingleInstanceFactory>().Use<SingleInstanceFactory>(ctx => t => ctx.GetInstance(t));
            For<MultiInstanceFactory>().Use<MultiInstanceFactory>(ctx => t => ctx.GetAllInstances(t));
        }
    }
}