using FluentAssertions.Common;
using Microsoft.EntityFrameworkCore;
using Project.NET1;
using Project.NET1.Data;

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
        builder.Services.AddDbContext<StudentDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("EFConnection")));

        builder.Services.AddSingleton<ISingletonOperation, Operation>();
        builder.Services.AddTransient<ITransientOperation, Operation>();
        builder.Services.AddScoped<IScopedOperation, Operation>();


        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        app.UseStaticFiles();

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}