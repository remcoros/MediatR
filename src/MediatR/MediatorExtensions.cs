using System.Threading;
using System.Threading.Tasks;

namespace MediatR
{
    public static class MediatorExtensions
    {
        public static async Task<object> Send(this IMediator mediator, object request, CancellationToken cancellationToken = default)
        {
            return await mediator.Send((dynamic)request, cancellationToken);
        }
    }
}
