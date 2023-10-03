using LECRP4E1.Modelo;

namespace LECRP4E1.EndPoints
 
  
{
    public static class CategoriaProductoEndPoint
    {
        static List<Categoria> categorias = new List<Categoria>();


        public static void AddCategoriaProductoEndpoints(this WebApplication app)
        {
            app.MapGet("/Categoria", () =>
            {


                return categorias;
            }).AllowAnonymous();



            app.MapPost("/Categoria", (Categoria categoria) =>
            {
                categorias.Add(categoria);

                return Results.Ok();
            }).RequireAuthorization();
        }
    }
}