using MediatR;

namespace LithiumCamel.Shared
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }
}
