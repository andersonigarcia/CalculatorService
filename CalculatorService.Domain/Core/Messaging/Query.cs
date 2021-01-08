using MediatR;

namespace CalculatorService.Domain.Core.Messaging
{
    public class Query<TResponse> : Message, IRequest<TResponse>
    {
    }
}
