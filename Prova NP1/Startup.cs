using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Prova_NP1.Models;
using Prova_NP1.Models.Interface;
using Prova_NP1.Models.Repository;
using Prova_NP1.View;
using Prova_NP1.View.FilterDTO;

namespace Prova_NP1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Prova_NP1", Version = "v1" });
            });

            #region Automapper
            var autoMapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Habilitado, HabilitadoDTO>().ReverseMap();
                cfg.CreateMap<CreateViewModel, HabilitadoDTO>().ReverseMap();
                //cfg.CreateMap<UpdateViewModel, ProdutoDTO>().ReverseMap();
            });
            services.AddSingleton(autoMapperConfig.CreateMapper());
            #endregion
            #region InjecaoDepedencia
            services.AddScoped<IHabilitadoRepository, HabilitadoRepository>();

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Prova_NP1 v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
