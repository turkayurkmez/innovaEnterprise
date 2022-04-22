namespace CQRSPattern.CQRS.Commands
{
    public class CreateProductCommandResponse : ICommandResponse
    {
        public bool IsSuccess { get; set; }
        public int Id { get; set; }
    }

}
