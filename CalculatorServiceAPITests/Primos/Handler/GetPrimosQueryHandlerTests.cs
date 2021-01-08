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
    public class GetPrimosQueryHandlerTests
    {
        public GetPrimosQueryHandlerTests()
        {
            _mediator = new Mock<IMediator>();
        }

        private Mock<IMediator> _mediator { get; set; }

        [Fact(DisplayName = "Obter primos com sucesso")]
        public async Task Handler_Sucesso()
        {
            var numbers = new List<int>() { 1, 3, 5, 9, 15, 45 };
            var expected = new List<int>() { 1, 3, 5 };
            _mediator.Setup(m => m.Send(It.IsAny<GetCousinsQuery>(), new CancellationToken()))
                .ReturnsAsync(new CousinsResponse(numbers));

            var command = new GetCousinsQuery(numbers);

            var result = await _mediator.Object.Send(command);

            Assert.IsType<CousinsResponse>(result);
            Assert.Equal(expected, result.Cousins);
        }

        [Fact(DisplayName = "Obter primos com erro")]
        public async Task Handler_Erro()
        {
            var numbers = new List<int>() { -1, -3 };
            _mediator.Setup(m => m.Send(It.IsAny<GetCousinsQuery>(), new CancellationToken()))
                .ReturnsAsync(new CousinsResponse(numbers));

            var command = new GetCousinsQuery(numbers);

            var result = await _mediator.Object.Send(command);

            Assert.IsType<CousinsResponse>(result);
            Assert.Empty(result.Cousins);
        }
    }
}
