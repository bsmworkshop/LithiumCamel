using MediatR;

namespace LithiumCamel.Shared
{
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}
