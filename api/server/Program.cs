using FSH.Framework;
using Microsoft.AspNetCore.Mvc;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.AddFSHFramework();
var app = builder.Build();
app.UseFSHFramework();
app.UseHttpsRedirection();
app.Run();