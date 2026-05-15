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
        Material = "White Leather"
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

app.UseHttpsRedirection();

app.MapGet("/interiors", () =>
{
   return interiors.Select(interior => new InteriorDTO
   {
       Id = interior.Id,
       Price = interior.Price,
       Material = interior.Material
   });
});

app.MapGet("/interiors/{id}", (int id) =>
{
    Interior interior = interiors.FirstOrDefault(interior => interior.Id == id);
    if (interior == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(new InteriorDTO
    {
        Id = interior.Id,
        Price = interior.Price,
        Material = interior.Material
    });
});

/* app.MapGet("/orders", () =>
{
    return orders.Select(o => new OrderDTO
    {
        Id = o.Id,
        TimeStamp = o.TimeStamp,
        WheelId = o.WheelId,
        TechnologyId = o.TechnologyId,
        PaintId = o.PaintId,
        InteriorId = o.InteriorId
    });
}); */

app.MapGet("/paintcolors", () =>
{
    return paintColors.Select(p => new PaintColorDTO
    {
        Id = p.Id,
        Price = p.Price,
        Color = p.Color
    });
});

app.MapGet("/paintcolors/{id}", (int id) =>
{
    PaintColor paintColor = paintColors.FirstOrDefault(paintColor => paintColor.Id == id);
    if (paintColor == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(new PaintColorDTO
    {
        Id = paintColor.Id,
        Price = paintColor.Price,
        Color = paintColor.Color
    });
});

app.MapGet("/technologies", () =>
{
    return technologies.Select(t => new TechnologyDTO
    {
        Id = t.Id,
        Price = t.Price,
        Package = t.Package
    });
});

app.MapGet("/technologies/{id}", (int id) =>
{
    Technology technology = technologies.FirstOrDefault(technology => technology.Id == id);
    if (technology == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(new TechnologyDTO
    {
        Id = technology.Id,
        Price = technology.Price,
        Package = technology.Package
    });
});

app.MapGet("/wheels", () =>
{
    return wheels.Select(w => new WheelsDTO
    {
        Id = w.Id,
        Price = w.Price,
        Style = w.Style
    });
});

app.MapGet("/wheels/{id}", (int id) =>
{
    Wheels wheels1 = wheels.FirstOrDefault(wheels1 => wheels1.Id == id);
    if (wheels1 == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(new WheelsDTO
    {
        Id = wheels1.Id,
        Price = wheels1.Price,
        Style = wheels1.Style
    });
});

app.Run();


