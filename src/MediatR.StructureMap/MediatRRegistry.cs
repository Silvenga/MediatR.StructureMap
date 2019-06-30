using StructureMap;

namespace MediatR.StructureMap
{
    public class MediatRRegistry : Registry
    {
        public MediatRRegistry()
        {
            For<IMediator>().Use<Mediator>();
            For<ServiceFactory>().Use<ServiceFactory>(ctx => ctx.GetInstance);
        }
    }
}