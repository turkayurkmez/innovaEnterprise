using CQRSPattern.CQRS.Commands;
using CQRSPattern.Data;
using CQRSPattern.Models;

namespace CQRSPattern.CQRS.Handlers
{
    public class CreateProductCommandHandler : IHandler<CreateProductRequestCommand, CreateProductCommandResponse>
    {
        private readonly innovaShopDbContext context;

        public CreateProductCommandHandler(innovaShopDbContext context)
        {
            this.context = context;
        }
        public CreateProductCommandResponse ExecuteCommand(CreateProductRequestCommand request)
        {
            var product = new Product()
            {
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                CategoryId = request.CategoryId
            };
            context.Products.Add(product);
            context.SaveChanges();
            return new CreateProductCommandResponse()
            {
                Id = product.Id,
                IsSuccess = product.Id > 0

            };
            
        }
    }
}
