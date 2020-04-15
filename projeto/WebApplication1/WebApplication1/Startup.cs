using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplication1.repositories;
using WebApplication1.services;

namespace WebApplication1
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
			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
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

			app.UseHttpsRedirection();
			app.UseMvc();
		}

		/*
		injecao de dependencia em 3 camadas... 
		repositories representam acesso a dados, 
		services regras de negocio
		controllers estao os endpoints da web api.

		passo a interface no construtor e o registo de dependencias decide qual
		implementacao deve ser injetada, com exceção do teste unitário que devemos
		criar um mock/fake pra testar somente a regra de negócio.. 
		teste unitário não faz conexão com banco de dados

		tambem controlo o ciclo de vida das dependencias (transient, scoped e singleton) no registro.
		o método GetGuid do BusinessServiceA retornará um Guid novo toda vez se estiver como transient 
		mas sempre retornará o mesmo Guid se estiver como singleton do controller utilizado,
		vc pode testar isso fazendo um GET no GuidController e no ValuesController/Guid
		
		abaixo vc pode brincar com a injecao das dependencias.
		*/
		private void AddDependencies(IServiceCollection services)
		{
			// services.AddTransient<IDatabaseRepository, SqlServerRepository>();
			services.AddTransient<IDatabaseRepository, OracleRepository>();

			// services.AddSingleton<IBusinessService, BusinessServiceA>();
			services.AddTransient<IBusinessService, BusinessServiceA>();
			// services.AddTransient<IBusinessService, BusinessServiceB>();
		}
	}
}
