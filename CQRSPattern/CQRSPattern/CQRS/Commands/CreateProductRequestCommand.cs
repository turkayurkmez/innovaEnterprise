namespace CQRSPattern.CQRS.Commands
{
    public class CreateProductRequestCommand : ICommandRequest
    {       

        public DateTime DateCreated { get; } = DateTime.Now;
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public string ImageUrl { get; set; }


    }
}
