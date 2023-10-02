namespace LECRP4E1.EndPoints

    public static class ProtectedEndPoint
    {

        
        static List<object> data = new List<object>();



        public static void AddProtectedEndPoints(this WebApplication app)
        {

            app.MapGet("/protected",()=>
            {


                return data;
            }).RequireAuthorization();


            app.MapPost("/protected", (string name, string lasName) =>
            {


                data.Add(new { name, lasName });



                return Results.Ok();
            }).RequireAuthorization();
        }

    }
}