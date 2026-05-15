using CarBuilder.Models;
using CarBuilder.Models.DTOs;

List<Interior> interiors = new List<Interior>
{
    new Interior()
    {
        Id = 1,
        Price = 35.50M,
        Material = "Beige Fabric"
    },
     new Interior()
    {
        Id = 2,
        Price = 38.50M,
        Material = "Charcoal Fabric"
    },
     new Interior()
    {
        Id = 3,
        Price = 51.25M,
        Material = "White Leather
    },
     new Interior()
    {
        Id = 4,
        Price = 49.50M,
        Material = "Black Leather"
    }
};

List<Order> orders = new List<Order>
{};

List<PaintColor> paintColors = new List<PaintColor>
{
    new PaintColor()
    {
        Id = 1,
        Price = 11.15M,
        Color = "Silver"
    },
    new PaintColor()
    {
        Id = 2,
        Price = 10.95M,
        Color = "Midnight Blue"
    },
    new PaintColor()
    {
        Id = 3,
        Price = 12.55M,
        Color = "Firebrick Red"
    },
    new PaintColor()
    {
        Id = 4,
        Price = 12.25M,
        Color = "Spring Green"
    }
};

List<Technology> technologies = new List<Technology>
{
    new Technology()
    {
        Id = 1,
        Price = 850.95M,
        Package = "Basic Package (basic sound system)"
    },
    new Technology()
    {
        Id = 2,
        Price = 1015.75M,
        Package = "Navigation Package (includes integrated navigation controls)"
    },
    new Technology()
    {
        Id = 3,
        Price = 1239.95M,
        Package = "Visibility Package (includes side and rear cameras)"
    },
    new Technology()
    {
        Id = 4,
        Price = 1675.95M,
        Package = "Ultra Package (includes navigation and visibility packages)"
    }
};

List<Wheels> wheels = new List<Wheels>
{
    new Wheels()
    {
        Id = 1,
        Price = 855.15M,
        Style = "17-inch Pair Radial"
    },
    new Wheels()
    {
        Id = 2,
        Price = 1125.95M,
        Style = "17-inch Pair Radial Black"
    },
    new Wheels()
    {
        Id = 3,
        Price = 1750.75M,
        Style = "18-inch Pair Spoke Silver"
    },
    new Wheels()
    {
        Id = 4,
        Price = 2050.95M,
        Style = "18-inch Pair Spoke Black"
    }
};

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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





app.Run();


