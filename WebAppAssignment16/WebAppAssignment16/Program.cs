using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebAppAssignment16.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<EmpDb16Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EmpDb16Context") ?? throw new InvalidOperationException("Connection string 'EmpDb16Context' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Emps}/{action=Index}/{id?}");

app.Run();
