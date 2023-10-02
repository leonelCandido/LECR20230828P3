namespace LECRP4E1.Auth
{
    public interface IJwtAuthenticationService
    {
        string Authenticate(string username);
    }
}
