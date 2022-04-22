using Microsoft.EntityFrameworkCore;
using OA.API.Infrastructure;
using OA.Data.Context;
using OA.Repositories;
using OA.Services;
using OA.Services.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, EFProductRepository>();

var connectionString = builder.Configuration.GetConnectionString("db");
builder.Services.AddDbContext<InnovaDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddAutoMapper(typeof(MappingProfile));


var app = builder.Build();

//app.Run(async x => await x.Response.WriteAsync("This is a terminal middleware message"));
//app.UseWelcomePage();
// Configure the HTTP request pipeline.
app.Map("/test", xapp => xapp.Run(async x => {
    if (x.Request.Query.ContainsKey("id"))
    {
        var id = int.Parse(x.Request.Query["id"]);
        var scope = app.Services.CreateScope();
        var productService = scope.ServiceProvider.GetRequiredService<IProductService>();

        if (await productService.IsProductExists(id))
        {
            await x.Response.WriteAsync($"{id} id'li urun mevcut");
        }
        else
        {
            await x.Response.WriteAsync($"{id} id'li urun mevcut degil");

        }
    }
    else
    {
        await x.Response.WriteAsync("id parametresi eksik");
    }
}));

app.UseMiddleware<PostLoggerMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
