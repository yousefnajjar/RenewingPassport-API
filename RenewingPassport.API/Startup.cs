using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using RenewingPassport.Core.Common;
using RenewingPassport.Core.DTO;
using RenewingPassport.Core.Repository;
using RenewingPassport.Core.Service;
using RenewingPassport.Infra.Common;
using RenewingPassport.Infra.Repository;
using RenewingPassport.Infra.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenewingPassport.API
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
            services.AddCors(corsOptions =>
            {
                corsOptions.AddPolicy("x",
                builder =>
                {
    //builder.WithOrigins("http://127.0.0.1:4200", "http://localhost:4200", "https://localhost:4200")
    // .AllowAnyHeader()
    // .AllowAnyMethod();


    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });




            services.AddScoped<IDbContext, DbContext>();
            services.AddScoped<IPR_RoleRepository, PR_RoleRepository>();
            services.AddScoped<IPR_RoleService, PR_RoleService>();
            services.AddScoped<IPr_PassportRepository, Pr_PassportRepository>();
            services.AddScoped<IPr_PassportService, Pr_PassportService>();
            services.AddScoped<IPr_UserloginRepository, Pr_UserloginRepository>();
            services.AddScoped<IPr_UserloginService, Pr_UserloginService>();
            services.AddScoped<IPr_TestimonialRepository, Pr_TestimonialRepository>();
            services.AddScoped<IPr_TestimonialService, Pr_TestimonialService>();
            services.AddScoped<IPr_AnnouncementRepository, Pr_AnnouncementRepository>();
            services.AddScoped<IPr_AnnouncementService, Pr_AnnouncementService>();
            services.AddScoped<IPr_WebsiteRepository, Pr_WebsiteRepository>();
            services.AddScoped<IPr_WebsiteService, Pr_WebsiteService>();
            services.AddScoped<IPr_About_UsRepository, Pr_About_UsRepository>();
            services.AddScoped<IPr_Contact_UsRepository, Pr_Contact_UsRepository>();
            services.AddScoped<IPr_ReviewRepository, Pr_ReviewRepository>();
            services.AddScoped<IPr_About_UsService, Pr_About_UsService>();
            services.AddScoped<IPr_Contact_UsService, Pr_Contact_UsService>();
            services.AddScoped<IPr_ReviewService, Pr_ReviewService>();
            services.AddScoped<IJWTRepository, JWTRepository>();
            services.AddScoped<IJWTService, JWTService>();
            services.AddScoped<IPr_GalleryRepository, Pr_GalleryRepository>();
            services.AddScoped<IPr_GalleryService, Pr_GalleryService>();
            services.AddScoped<IMailService, MailService>();
            services.AddScoped<IPr_CountryRepository, Pr_CountryRepository>();
            services.AddScoped<IPr_CountryService, Pr_CountryService>();
            services.AddScoped<IPr_CardRepository, Pr_CardRepository>();
            services.AddScoped<IPr_CardService, Pr_CardService>();
            services.AddScoped<IPr_PaymantRepository, Pr_PaymantRepository>();
            services.AddScoped<IPr_PaymantService, Pr_PaymantService>();

            services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));

            services.Configure<MailSettings>(Configuration.GetSection("MailSettings"));
            services.AddSingleton(typeof(IConverter),
            new SynchronizedConverter(new PdfTools()));
            services.AddControllers();

            services.AddAuthentication(opt => {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme; //jwt Bearer : Middleware to allow validating and extracting JWT info from auth header is used also for auth {string}
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;



                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true, //session time out
                    ValidateIssuerSigningKey = true, //?? ????? setting ??????? ???? ?????? ???? ??? services???? ?????? ???? ?? token
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("[SECRET USED TO SIGN AND VERIFY JWT TOKENS, IT CAN BE ANY STRING]")),



                };
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("x");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
