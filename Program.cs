using Microsoft.AspNetCore.Cors.Infrastructure;
using WebApplication13.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors((options) =>
{
	options.AddPolicy("DevCors", (CorsPolicyBuilder) =>
	{
		CorsPolicyBuilder.WithOrigins("http://localhost:4200", "http://localhost:3000", "http://localhost:8000")
		.AllowCredentials()
		.AllowAnyHeader()
		.AllowAnyMethod();
	});
	options.AddPolicy("ProdCors", (CorsPolicyBuilder) =>
	{
		CorsPolicyBuilder.WithOrigins("https://www.vibinSoftwareSolutions.com")
		.AllowCredentials()
		.AllowAnyHeader()
		.AllowAnyMethod();
	});
});

builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//string? token = builder.Configuration.GetSection("TokenKey").Value;

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseCors("DevCors");
	app.UseSwaggerUI();
}
else
{
	app.UseCors("ProdCors");
	app.UseHttpsRedirection();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
