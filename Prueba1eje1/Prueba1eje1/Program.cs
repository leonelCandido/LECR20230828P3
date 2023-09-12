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

var productos = new List<Producto>();

app.MapGet("/productos", () =>
{
    return productos;
});

app.MapGet("/productos/{id}", (int id) =>
{
    var producto = productos.FirstOrDefault(p => p.Id == id);
    return producto;
});

app.MapPost("/productos", (Producto producto) =>
{
    productos.Add(producto);
});



app.MapPut("/productos/{id}", (int id, Producto producto) =>
{
    var existingProducto = productos.FirstOrDefault(p => p.Id == id);
    if (existingProducto != null)
    {
        existingProducto.Name = producto.Name;
        return Results.Ok();
    }
    else
    {
        return Results.NotFound();
    }
});

app.MapDelete("/productos/{id}",(int id) =>
{
    var existingProducto = productos.FirstOrDefault(p => p.Id ==id); 
    if(existingProducto != null)
    {
        productos.Remove(existingProducto);
        return Results.Ok();
    }
    else
    {
        return Results.Ok();
    }
});

app.Run();

internal class Producto
{
    public int Id { get; set;}

    public string Name { get; set;}
}