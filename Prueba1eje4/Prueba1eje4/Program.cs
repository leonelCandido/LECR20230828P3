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

var categorias = new List<Categorias>()
{
    new Categorias { id = 0,categorias ="Ferrari"},
    new Categorias { id = 1, categorias = "RED BUL" },
    new Categorias { id = 2, categorias = "mercedes" },
};

app.MapGet("/categorias", () =>
{
    return categorias;
});
app.Run();

internal class Categorias
{
    public int id { get; set; }
    public string categorias { get; set; }
}