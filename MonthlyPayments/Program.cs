using Firebase.Database;
using Microsoft.Extensions.DependencyInjection;
using MonthlyPayments.FirebaseRepository;
using MonthlyPayments.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add Firebase services to the container.
//builder.Services.AddSingleton<IFirebaseClient>(new FirebaseClient("https://monthlypayments-576de-default-rtdb.europe-west1.firebasedatabase.app/"));

builder.Services.AddScoped<IGroceryRepository, GroceryRepository>();
builder.Services.AddScoped<IGroceryService, GroceryService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
