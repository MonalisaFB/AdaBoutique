
using AdaBoutique.Filters;
using Dados.Repositorio.DevolverRepositorio;
using Dados.Repositorio.TrocaRepositorio;
using Dados.Repositorio.VendaRepositorio;

namespace AdaBoutique
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers(options =>
            {
                options.Filters.Add<FiltroExcecao>();
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddSingleton<IVendaRepositorio, VendaRepositorio>();
            builder.Services.AddSingleton<IDevolverRepositorio, DevolverRepositorio>();
            builder.Services.AddSingleton<ITrocaRepositorio, TrocaRepositorio >();
            


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
