using System;
using System.Threading;
using System.Threading.Tasks;
using AutoFixture;
using FluentAssertions;
using StructureMap;
using Xunit;

namespace MediatR.StructureMap.Tests
{
    public class FlowFacts
    {
        private static readonly Fixture AutoFixture = new Fixture();

        private readonly Container _container;

        public FlowFacts()
        {
            _container = new Container();
            _container.UseMediatR();
            _container.Configure(config => config.For<IRequestHandler<QueryFixture.Query, QueryFixture.Result>>().Use<QueryFixtureHandler>());
        }

        [Fact]
        public async Task FlowWorks()
        {
            var mediator = _container.GetInstance<IMediator>();
            var input = AutoFixture.Create<QueryFixture.Query>();

            // Act
            var result = await mediator.Send(input);

            // Assert
            result.Output.Should().Be(input.Input);
        }

        public static class QueryFixture
        {
            public class Query : IRequest<Result>
            {
                public Guid Input { get; set; }
            }

            public class Result
            {
                public Guid Output { get; set; }
            }
        }

        public class QueryFixtureHandler : IRequestHandler<QueryFixture.Query, QueryFixture.Result>
        {
            public Task<QueryFixture.Result> Handle(QueryFixture.Query message, CancellationToken cancellationToken)
            {
                return Task.FromResult(new QueryFixture.Result { Output = message.Input });
            }
        }
    }
}