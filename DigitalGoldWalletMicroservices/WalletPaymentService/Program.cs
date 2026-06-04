
using Microsoft.EntityFrameworkCore;
using WalletPaymentService.Data;
using WalletPaymentService.HttpClients;

namespace WalletPaymentService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<WalletPaymentDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WalletPaymentServiceConnection")));

            builder.Services.AddHttpClient<CustomerClient>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7001");
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
