

using LECRP4AJWTMAPI.Auth;

namespace LECRP4AJWTMAPI.Endpoints
{
    public static class AccountEndpoin
    {

         public static void AddAccountEndpoints(this WebApplication app)
         {
            
            
            
            
            
            
           
            
            app.MapPost("/account/login",(string login, string password, IJWTAuthenticationService authService) =>
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
