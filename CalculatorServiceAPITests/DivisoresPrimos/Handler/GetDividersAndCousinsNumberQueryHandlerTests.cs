using CalculatorService.Application.Calculadora.Queries;
using CalculatorService.Application.Calculadora.Queries.Responses;
using MediatR;
using Moq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorServiceAPITests.Divisores.Handler
{
    public class GetDividersAndCousinsNumberQueryHandlerTests
    {
        public GetDividersAndCousinsNumberQueryHandlerTests()
        {
            _mediator = new Mock<IMediator>();
        }

        private Mock<IMediator> _mediator { get; set; }        

        [Fact(DisplayName = "Obter divisores e primos com erro")]
        public async Task Handler_Erro()
        {
            var number = -45;
            _mediator.Setup(m => m.Send(It.IsAny<GetDividersAndCousinsNumberQuery>(), new CancellationToken()))
                .ReturnsAsync(new DividersAndCousinsNumberResponse(number));

            var command = new GetDividersAndCousinsNumberQuery(number);

            var result = await _mediator.Object.Send(command);

            Assert.IsType<DividersAndCousinsNumberResponse>(result);
            Assert.Empty(result.Dividers);
            Assert.Empty(result.Cousins);
        }
    }
}
