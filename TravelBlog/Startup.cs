﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using TravelBlog.Models;


namespace TravelBlog
{
	public class Startup
	{
		public IConfigurationRoot Configuration { get; set; }
		public Startup(IHostingEnvironment env)
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(env.ContentRootPath)
				.AddJsonFile("appsettings.json");
			Configuration = builder.Build();
		}
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddEntityFramework()
				.AddDbContext<TravelBlogDbContext>(options =>
					options.UseMySql(Configuration["ConnectionStrings:DefaultConnection"]));
		}


		public void Configure(IApplicationBuilder app)
		{


			app.Run(async (context) =>
			{
				await context.Response.WriteAsync("Hello World!");
			});
		}
	}
}