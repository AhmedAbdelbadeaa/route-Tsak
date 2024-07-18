using Microsoft.EntityFrameworkCore;
using route_Tsak.Models;
using route_Tsak.Repo;
using route_Tsak.Repositories;
using route_Tsak.Services;

namespace route_Tsak
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("OldDefaultConnection");
            builder.Services.AddDbContext<TaskDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<TaskDbContext>();
            builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
            builder.Services.AddScoped<IcostumerServices, CustomerService>();
            builder.Services.AddScoped<IOrderRepository, OrderRepository>();
            builder.Services.AddScoped<IOrderService, OrderService>();
            builder.Services.AddScoped<iProductRepository, ProductRepository>();
            builder.Services.AddScoped<IProductServices, ProductServices>();
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
}