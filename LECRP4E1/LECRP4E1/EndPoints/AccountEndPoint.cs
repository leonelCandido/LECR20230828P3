using LECRP4E1.Auth;

namespace LECRP4E1.EndPoints
{
    public static class AccountEndpoin
    {

        public static void AddAccountEndpoints(this WebApplication app)
        {

            app.MapPost("/account/login", (string login, string password, IJwtAuthenticationService authService) =>
            {


                if (login == "admin" && password == "12345")
                {


                    var token = authService.Authenticate(login);



                    return Results.Ok(token);
                }
                else
                {

                    return Results.Unauthorized();
                }
            });
        }
    }
}