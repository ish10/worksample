
using DataAcess.Data;
using InfiniteLocusWorkSample.DbContext;
using InfiniteLocusWorkSample.DbContext.Interfaces;
using InfiniteLocusWorkSample.Helper;
using InfiniteLocusWorkSample.Helper.Interface;
using InfiniteLocusWorkSample.Middleware;
using InfiniteLocusWorkSample.Repository;
using InfiniteLocusWorkSample.Repository.Interfaces;
using InfiniteLocusWorkSample.Service;
using InfiniteLocusWorkSample.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddDbContext<ApplicationDbcontext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddProblemDetails();
builder.Services.AddControllers();

builder.Services.AddApiVersioning(options => {
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new ApiVersion(1, 0);

});
//injecting dependencies
builder.Services.AddSingleton<ICustomValidator,CustomValidator>();
builder.Services.AddScoped < IVendorManagementDbContext, VendorManagementDbContext>();
builder.Services.AddScoped<IVendorManagementService,VendorManagementService>();
builder.Services.AddScoped<IVendorManagementRepository, VendorManagementRepository>();
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
app.UseExceptionHandler();
app.UseAuthorization();

app.MapControllers();

app.Run();
