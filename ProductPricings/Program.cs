using System.Reflection;
using Microsoft.EntityFrameworkCore;
using ProductPricings.DataConfiguration;
using ProductPricings.Model.Product;
using ProductPricings.Repository;
using ProductPricings.Service;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        
        builder.Services.AddDbContext<ProductContext>(opt =>
        {
            opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
        });
       
        builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
        builder.Services.AddScoped<ProductSevice>();
        builder.Services.AddScoped<Repository<Product>>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}