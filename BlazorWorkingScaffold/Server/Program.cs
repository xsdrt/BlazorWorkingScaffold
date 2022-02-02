global using BlazorWorkingScaffold.Shared;
global using Microsoft.EntityFrameworkCore;
global using BlazorWorkingScaffold.Server.Data;
global using BlazorWorkingScaffold.Server.Services.EmployeeService;
using Microsoft.AspNetCore.ResponseCompression;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<DataContext>(options =>   
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});  //Registered the DataContext
builder.Services.AddScoped<IEmployeeService, EmployeeService>();    //Register the Interface and implication class...

builder.Services.AddEndpointsApiExplorer(); //Added to use Swagger
builder.Services.AddSwaggerGen();           //Added to use Swagger

var app = builder.Build();
app.UseSwaggerUI();                         //Added to use Swagger

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSwagger();                       //Added to use Swagger
app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
