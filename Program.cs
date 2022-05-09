using AutoMapper;
using FluentAssertions.Common;
using FluentNHibernate.Automapping;
using WebApplication7;
using System.Reflection;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddFluentValidation(c => c.RegisterValidatorsFromAssembly(Assembly.GeyExecutionAssembly()));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
var mapperconfig = new MapperConfiguration(m => {
    m.AddProfile(new MappingProfile());
});
IMapper mapper = mapperconfig.CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddMvc();
