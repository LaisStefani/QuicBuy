using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QuickBuy.Repositorio.Contexto;
using QuickBuy.Repositorio.Repositorios;

namespace QuickBuy.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("config.json", optional:false, reloadOnChange:true);

            Configuration = builder.Build();
        }



        // Este método é chamado pelo tempo de execução. Use este método para adicionar serviços ao contêiner.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            var connectionString = Configuration.GetConnectionString("QuickBuyDB");
            services.AddDbContext<QuickBuyContexto>(option => option
                                                        .UseLazyLoadingProxies()
                                                        .UseMySql(connectionString, m => m
                                                        .MigrationsAssembly("QuickBuy.Repositorio")));

            services.AddScoped<Dominio.Contratos.IProdutoRepositorio, ProdutoRepositorio>();

            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
        }

        // Este método é chamado pelo tempo de execução. Use este método para configurar o pipeline de solicitação HTTP.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //definir uma pagina de erro
                app.UseExceptionHandler("/Error");
                // O valor HSTS padrão é 30 dias. Você pode querer mudar isso para cenários de produção, consulte https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
                //forçar a https
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // Para saber mais sobre as opções para servir um SPA Angular do ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    //Esse start junto
                     spa.UseAngularCliServer(npmScript: "start");
                    //esse start separado
                  //  spa.UseProxyToSpaDevelopmentServer("http://localhost:4200/");
                }
            });
        }
    }
}
