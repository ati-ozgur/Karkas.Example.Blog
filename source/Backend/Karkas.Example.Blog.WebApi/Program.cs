using Karkas.Core.DataUtil;
using Karkas.Example.Blog.BackendLibrary.Dal.LtCommon;
using Karkas.Example.Blog.BackendLibrary.TypeLibrary.LtCommon;
using Microsoft.Data.SqlClient;
using System.Data.Common;

string dbProviderName = "Microsoft.Data.SqlClient";
DbProviderFactories.RegisterFactory(dbProviderName, SqlClientFactory.Instance);
DbProviderFactories.RegisterFactory("System.Data.SqlClient", SqlClientFactory.Instance);

string connectionString = "Data Source=localhost;Initial Catalog=BLOG;Persist Security Info=True;User ID=sa;Password=yourStrong2022Password;Encrypt=False";
ConnectionSingleton.Instance.AddConnection("Blog", dbProviderName, connectionString);



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
