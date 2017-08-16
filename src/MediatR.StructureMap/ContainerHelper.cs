using StructureMap;

namespace MediatR.StructureMap
{
    public static class ContainerHelper
    {
        public static IContainer UseMediatR(this IContainer container)
        {
            container.Configure(configure => configure.AddRegistry<MediatRRegistry>());
            return container;
        }
    }
}