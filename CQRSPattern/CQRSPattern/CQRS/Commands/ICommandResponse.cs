namespace CQRSPattern.CQRS.Commands
{
    public interface ICommandResponse
    {
        bool IsSuccess { get; set; }
    }
}
