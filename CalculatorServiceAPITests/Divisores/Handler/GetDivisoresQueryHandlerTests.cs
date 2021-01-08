using CalculatorService.Application.Calculadora.Queries;
using CalculatorService.Application.Calculadora.Queries.Responses;
using MediatR;
using Moq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorServiceAPITests.Divisores.Handler
{
    public class GetDivisoresQueryHandlerTests
    {
        public GetDivisoresQueryHandlerTests()
        {
            _mediator = new Mock<IMediator>();
        }

        private Mock<IMediator> _mediator { get; set; }

        [Fact(DisplayName = "Obter divisores com sucesso")]
        public async Task Handler_Sucesso()
        {
            int number = 45;
            var expected = new List<int>() { 1, 3, 5, 9, 15, 45 };
            _mediator.Setup(m => m.Send(It.IsAny<GetDividersQuery>(), new CancellationToken()))
                .ReturnsAsync(new DividersResponse(number));

            var command = new GetDividersQuery(number);

            var result = await _mediator.Object.Send(command);

            Assert.IsType<DividersResponse>(result);
            Assert.Equal(expected, result.Dividers);
        }

        [Fact(DisplayName = "Obter divisores com erro")]
        public async Task Handler_Erro()
        {
            int number = -45;
            _mediator.Setup(m => m.Send(It.IsAny<GetDividersQuery>(), new CancellationToken()))
                .ReturnsAsync(new DividersResponse(number));

            var command = new GetDividersQuery(number);

            var result = await _mediator.Object.Send(command);

            Assert.IsType<DividersResponse>(result);
            Assert.Empty(result.Dividers);
        }
    }
}
