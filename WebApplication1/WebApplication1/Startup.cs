using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;

namespace WebApplication1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)

        {
            app.Map("/mypop", appbiulder =>
            {
                appbiulder.Use(async (context, next) =>
                {
                    var name=context.Request.Query["name"];
                    if(!string.IsNullOrWhiteSpace(name))
                        context.Items.Add("name",name);

                    await next.Invoke();
                });

                appbiulder.Run(async (context) =>
                {
                    var name = context.Items["name"];
                    await context.Response.WriteAsync($"my name is :{name}");
                });
            });
            app.Use(async (context, next) =>
            {
                context.Items.Add("name","hossien");
                await next.Invoke();
            });
            #region defilt midle ware
            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("this firs midle ware");
            //});//the last midle ware
        

            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Home/Error");

            //    app.UseHsts();
            //}
            //app.UseHttpsRedirection();
            //app.UseStaticFiles();

            //app.UseRouting();

            //app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id?}");
            //});

            #endregion

            app.Run( async context =>
            {
                var name=context.Items["name"];
                await context.Response.WriteAsync("this is first my back up");
            });

        }
    }
}
