using ProductManagement.Services;

var builder = WebApplication.CreateBuilder(args);

// Register ProductService with the DI container
builder.Services.AddScoped<ProductService>(sp =>
{
    var configuration = sp.GetRequiredService<IConfiguration>();
    var connectionString = configuration.GetConnectionString("DefaultConnection");
    return new ProductService(connectionString);
});

// Add services to the container
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline
app.UseRouting();

app.MapDefaultControllerRoute();

app.Run();
