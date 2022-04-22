using CQRSPattern.CQRS.Commands;

namespace CQRSPattern.CQRS.Handlers
{
    public interface IHandler<in TRequest, out TResponse> where TRequest: ICommandRequest
                                                          where TResponse : ICommandResponse
                                                             
    {
        TResponse ExecuteCommand(TRequest request);

    }
}
