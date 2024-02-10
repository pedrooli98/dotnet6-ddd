namespace BuberDinner.Application.Authentication;

public interface IAuthenticationService
{
    AuthResult Register(string firstName, string lastName, string email, string password);
    AuthResult Login(string email, string password);
}