using LECRP4E1.Modelo;

namespace LECRP4E1.EndPoints
{

    public static class BodegaEndPoint
    {


        static List<Bodega> bodegas = new List<Bodega>();



        public static void AddBodegaEndPoints(this WebApplication app)
        {


            app.MapPost("/bodega", (Bodega bodega) =>
            {
                bodegas.Add(bodega);

                return Results.Ok();
            }).RequireAuthorization();


            app.MapGet("/api/bodega/{id}", (int id) =>
                {
                    var bodega = bodegas.Find(p => p.Id == id);

                    if (bodega == null)
                    {
                        return Results.NotFound(); 
                    }

                    return Results.Ok(bodega); 
                }).RequireAuthorization();


            app.MapPut("/bodega/{id}", (int id, Bodega bodega) =>
            {
                var existingBodega = bodegas.FirstOrDefault(p => p.Id == id);
                if (existingBodega != null)
                {
                    
                    existingBodega.Name = bodega.Name;

                    return Results.Ok(); 
                }
                else
                {
                    return Results.NotFound(); 
                }
            }).RequireAuthorization();
        }
    }
}