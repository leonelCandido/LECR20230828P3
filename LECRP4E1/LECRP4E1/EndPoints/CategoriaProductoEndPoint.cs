namespace LECRP4E1.EndPoints
 
  
{
    public static class CategoriaProductoEndPoint
    {
        static List<object> data = new List<object>();


        public static void AddTestEndpoints(this WebApplication app)
        {
            app.MapGet("/test", () =>
            {


                return data;
            }).AllowAnonymous();



            app.MapPost("/test", (string name, string lastName) =>
            {
                data.Add(new { name, lastName });

                return Results.Ok();
            }).RequireAuthorization();
        }
    }
}