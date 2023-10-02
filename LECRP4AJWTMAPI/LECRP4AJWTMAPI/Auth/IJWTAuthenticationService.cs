namespace LECRP4AJWTMAPI.Auth
{
    public interface IJWTAuthenticationService
    {

        string Authenticate(string username);
    }
}
