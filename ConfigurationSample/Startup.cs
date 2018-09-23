using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConfigurationSample.Interfaces;
using ConfigurationSample.Settings;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ConfigurationSample
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddSingleton<IApplicationInitializer, ApplicationInitializer>();
            services.Configure<ApplicationSettings>(Configuration.GetSection("application"));

            services.AddSingleton<MessageOfTheDay>();
            services.Configure<MessageOfTheDaySettings>(Configuration.GetSection("messageOfTheDay"));

            var greetingsSettings = new GreetingsSettings();
            Configuration.GetSection("greetings").Bind(greetingsSettings);
            services.AddSingleton(greetingsSettings);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            var application = app.ApplicationServices.GetService<IApplicationInitializer>();

            if (application.ShowGreetings)
            {
                var greetings = app.ApplicationServices.GetService<GreetingsSettings>();
                Console.WriteLine(greetings.Content);
            }

            if (application.ShowMotd)
            {
                var messageOfTheDay = app.ApplicationServices.GetService<MessageOfTheDay>();
                Console.Write("MOTD: ");
                Console.WriteLine(messageOfTheDay.Content);
                Console.WriteLine(messageOfTheDay.Author);
            }

            if (application.ShowFooter)
            {
                Console.WriteLine(Configuration["footer:content"]);
            }
            
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}