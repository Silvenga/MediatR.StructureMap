using StructureMap;

namespace MediatR.StructureMap
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

            For<ServiceFactory>().Use<ServiceFactory>(ctx => ctx.GetInstance);
        }
    }
}